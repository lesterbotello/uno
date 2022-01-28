﻿#nullable enable

// #define TRACE_EFFECTIVE_VIEWPORT

#if !(IS_NATIVE_ELEMENT && __IOS__)
// On iOS lots of native elements are not using the Layouter and will never invoke the IFrameworkElement_EffectiveViewport.OnLayoutUpdated()
// so avoid check of the '_isLayouted' flag
#define CHECK_LAYOUTED
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Primitives;
using Uno;
using Uno.Disposables;
using Uno.UI;
using Uno.UI.Extensions;
using _This = Windows.UI.Xaml.FrameworkElement;
#if __IOS__
using UIKit;
#elif __MACOS__
using AppKit;
#endif

namespace Windows.UI.Xaml
{
	partial class FrameworkElement : IFrameworkElement_EffectiveViewport
	{
		private static readonly RoutedEventHandler ReconfigureViewportPropagationOnLoad = (snd, e) => ((_This)snd).ReconfigureViewportPropagation();
		private event TypedEventHandler<_This, EffectiveViewportChangedEventArgs>? _effectiveViewportChanged;
		private bool _hasNewHandler;
		private int _childrenInterestedInViewportUpdates;
		private IDisposable? _parentViewportUpdatesSubscription;
		private ViewportInfo _parentViewport = ViewportInfo.Empty; // WARNING: Stored in parent's coordinates space, use GetParentViewport()
		private ViewportInfo _lastEffectiveViewport;
#if CHECK_LAYOUTED
		private bool _isLayouted;
#endif

		public event TypedEventHandler<_This, EffectiveViewportChangedEventArgs> EffectiveViewportChanged
		{
			add
			{
				_hasNewHandler = true;
				_effectiveViewportChanged += value;
				ReconfigureViewportPropagation(isInternal: true);
			}
			remove
			{
				_effectiveViewportChanged -= value;
				ReconfigureViewportPropagation(isInternal: true);
			}
		}

		// ctor (invoked by IFrameworkElement.Initialize())
		void IFrameworkElement_EffectiveViewport.InitializeEffectiveViewport()
		{
			Loaded += ReconfigureViewportPropagationOnLoad;
			Unloaded += ReconfigureViewportPropagationOnLoad;
		}

		/// <summary>
		/// Indicates if the effective viewport should/will be propagated to/by this element
		/// </summary>
		private bool IsEffectiveViewportEnabled => _childrenInterestedInViewportUpdates > 0 || _effectiveViewportChanged != null;

		/// <summary>
		/// Make sure to request or disable effective viewport changes from the parent
		/// </summary>
		private void ReconfigureViewportPropagation(bool isInternal = false, IFrameworkElement_EffectiveViewport? child = null)
		{
			if (IsLoaded && IsEffectiveViewportEnabled)
			{
#if CHECK_LAYOUTED
				if (IsLoaded)
				{
					_isLayouted = true;
				}
#endif

				if (_parentViewportUpdatesSubscription == null)
				{
					TRACE_EFFECTIVE_VIEWPORT("Enabling effective viewport propagation.");

					var parent = this.GetVisualTreeParent();
					if (parent is IFrameworkElement_EffectiveViewport parentFwElt)
					{
						_parentViewportUpdatesSubscription = parentFwElt.RequestViewportUpdates(isInternal, this);
					}
					else
					{
						global::System.Diagnostics.Debug.Assert(IsVisualTreeRoot);

						// We are the root of the visual tree, we update the effective viewport
						// in order to initialize the _parentViewport of children.
						PropagateEffectiveViewportChange(isInitial: true, isInternal: isInternal);
					}
				}
				else if (child != null)
				{
					TRACE_EFFECTIVE_VIEWPORT("New child requested viewport propagation which has already been enabled, forwarding current viewport to it.");

					// We are already subscribed, the parent won't send any update (and our _parentViewport is expected to be up-to-date).
					// But if this "reconfigure" was made for a new child (child != null), we have to initialize its own _parentViewport.

					var parentViewport = GetParentViewport();
					var viewport = GetEffectiveViewport(parentViewport);

					child.OnParentViewportChanged(isInitial: true, isInternal: true, this, viewport);
				}
			}
			else
			{
#if CHECK_LAYOUTED
				if (!IsLoaded)
				{
					_isLayouted = false;
				}
#endif

				if (_parentViewportUpdatesSubscription != null)
				{
					TRACE_EFFECTIVE_VIEWPORT("Disabling effective viewport propagation.");

					_parentViewportUpdatesSubscription.Dispose();
					_parentViewportUpdatesSubscription = null;

					_parentViewport = ViewportInfo.Empty;
				}
			}
		}

		/// <summary>
		/// Used by a child of this element, in order to subscribe to viewport updates
		/// (so the OnParentViewportChanged will be invoked on this given child)
		/// </summary>
		IDisposable IFrameworkElement_EffectiveViewport.RequestViewportUpdates(bool isInternalUpdate, IFrameworkElement_EffectiveViewport? child)
		{
			global::System.Diagnostics.Debug.Assert(Uno.UI.Extensions.DependencyObjectExtensions.GetChildren(this).OfType<IFrameworkElement_EffectiveViewport>().Contains(child));

			_childrenInterestedInViewportUpdates++;
			ReconfigureViewportPropagation(isInternalUpdate, child);

			return Disposable.Create(() =>
			{
				_childrenInterestedInViewportUpdates--;
				ReconfigureViewportPropagation();
			});
		}

		/// <summary>
		/// Used by a parent element to propagate down the viewport change
		/// </summary>
		void IFrameworkElement_EffectiveViewport.OnParentViewportChanged(
			bool isInitial, // Update is intended to initiate the _parentViewport and should be "public" only if not due to a new event listener while tree is live (e.g. load)
			bool isInternal, // Indicates that this update is due to a new event handler
			IFrameworkElement_EffectiveViewport parent, // We propagate the parent to avoid costly lookup
			ViewportInfo viewport) // The viewport of the parent, expressed in parent's coordinates
		{
			if (!IsEffectiveViewportEnabled)
			{
				// We do not keep the _parentViewport up-to-date if not needed.
				// It's expected to the root parent to update its children when propagation activated. 
				return;
			}

			if (!isInitial && viewport == _parentViewport)
			{
				return;
			}

			_parentViewport = viewport;
			PropagateEffectiveViewportChange(isInitial, isInternal);
		}

#if IS_NATIVE_ELEMENT
		private bool IsScrollPort { get; } = false;
		private bool IsVisualTreeRoot { get; } = false;
		private Windows.Foundation.Point ScrollOffsets { get; } = default;

		// Native elements cannot be clipped (using Uno), so the _localViewport will always be an empty rect, and we only react to LayoutSlot updates
		void IFrameworkElement_EffectiveViewport.OnLayoutUpdated()
		{
#if CHECK_LAYOUTED
			_isLayouted = true;
#endif
			PropagateEffectiveViewportChange();
		}
#else
		void IFrameworkElement_EffectiveViewport.OnLayoutUpdated() { }  // Nothing to do here: this won't be invoked for real FrameworkElement, instead we receive OnViewportUpdated

		private protected sealed override void OnViewportUpdated(Rect viewport) // a.k.a. OnLayoutUpdated / OnClippingApplied
		{
			// The 'viewport' (a.k.a. the clipping) is actually not used to compute the EffectiveViewport ...
			// except for element flagged as ScrollHost!
			// For now we are using the LayoutSlot + ScrollOffsets (which is internal only!), but we should use that 'viewport'.

			_isLayouted = true;
			PropagateEffectiveViewportChange();
		}

		[NotImplemented] // Supported only for internal elements, cf. comment below
		protected void InvalidateViewport()
		{
			if (!IsScrollPort)
			{
				throw new InvalidOperationException("InvalidateViewport can only be called on elements that have been registered as scroll ports.");
			}

			// Here we should use the clipping to determine the actual view port for external controls,
			// but for now we support only internal controls that can set the ScrollOffsets property on UIElement.
			PropagateEffectiveViewportChange();
		}
#endif

		private ViewportInfo GetEffectiveViewport(ViewportInfo parentViewport)
		{
			global::System.Diagnostics.Debug.Assert(parentViewport.Reference == this || parentViewport.Reference == null);

			if (IsVisualTreeRoot)
			{
				var slot = LayoutInformation.GetLayoutSlot(this);

				return new ViewportInfo(this, slot, Rect.Infinite);
			}

			if (IsScrollPort)
			{
				var viewport = parentViewport.Clip;

				// Pseudo intersect:
				// A normal intersect would return `Empty` as soon as the `viewport` and the `scrollport` does not overlap,
				// but on UWP the viewport is `Empty` only if the `viewport` is below the `scrollport` (for vertical scroll).
				// It means for an item in a list which is not yet visible on load (while vertical offset is 0), its EffVP will be empty.
				// Then when you scroll, its effVP will be something like [slot.Width,10 @ slot.X,slot.Y] when its first top 10px becomes visible.
				// Then if you continue to scroll and the item goes above the 'scrollport', its effVP will be [slot.Width,slot.Height @ slot.X,slot.Y]
				// while a normal intersect would be `Empty` (which is logic as the item is no longer visible at all,
				// but it make sense to not request to not go back to empty so element won't unload its content when scrolling up)!
				// However, nested scroll host has to do a real intersect.

				if (viewport.Right <= 0
					|| viewport.Bottom <= 0)
				{
					return new ViewportInfo(this, Rect.Empty);
				}

				// The visible window of the SCP
				// TODO: We should constrains the clip only on axis on which we can scroll
				var scrollport = new Rect(
					new Point(ScrollOffsets.X, ScrollOffsets.Y),
					LayoutInformation.GetLayoutSlot(this).Size);

				if (viewport.IsInfinite)
				{
					viewport = scrollport;
				}
				else
				{
					viewport.Intersect(scrollport);
				}

				return new ViewportInfo(this, viewport);
			}

			return parentViewport;
		}

		private ViewportInfo GetParentViewport()
			// As the conversion form parent to local coordinates of the viewport is impacted by LayoutSlot and RenderTransforms,
			// we do have to keep it in parent coordinates spaces, and convert it to local coordinate space on each use.
			//
			// Also on iOS the Arrange is "async": When arranged an element only arranges its direct children (set their Frame)
			// which then waits for their 'LayoutSubView' to arrange their own children.
			// The issue is that after having arrange its children, the element will also apply its clipping,
			// which will cause an update of the EffectiveViewport and more specifically invoke the OnParentViewportChanged
			// on all children (direct and sub children), including children that might not be arranged yet.
			// If we convert the viewport into local element coordinate space at this time,
			// we won't have a valid LayoutSlot (and LayoutSlotWithMarginsAndAlignment used in GetTransform).
			=> _parentViewport.GetRelativeTo(this);

		private void PropagateEffectiveViewportChange(
			bool isInitial = false,
			bool isInternal = false
#if TRACE_EFFECTIVE_VIEWPORT
			, [CallerMemberName] string? caller = null) {
#else
			)
		{
			const string caller = "--unavailable--";
#endif
			if (!IsEffectiveViewportEnabled)
			{
				TRACE_EFFECTIVE_VIEWPORT($"Effective viewport disabled, stop propagation (reason:{caller} | isInitial:{isInitial} | isInternal:{isInternal}).");
				return;
			}

#if CHECK_LAYOUTED
			if (!_isLayouted) // For perf consideration, we try to not propagate the VP until teh element get a valid LayoutSlot
			{
				TRACE_EFFECTIVE_VIEWPORT($"Element has been layouted yet, stop propagation (reason:{caller} | isInitial:{isInitial} | isInternal:{isInternal}).");
				return;
			}
#endif

			var parentViewport = GetParentViewport();
			var viewport = GetEffectiveViewport(parentViewport);
			var viewportUpdated = _lastEffectiveViewport != viewport;

			_lastEffectiveViewport = viewport;

			TRACE_EFFECTIVE_VIEWPORT(
				$"viewport: {viewport} (updated: {viewportUpdated}) "
				+ $"| slot: {LayoutInformation.GetLayoutSlot(this).ToDebugString()} "
				+ $"| isInitial: {isInitial} "
				+ $"| isInternal: {isInternal} "
				+ $"| parent: {parentViewport} "
				+ $"| scroll: {(IsScrollPort ? $"{ScrollOffsets.ToDebugString()}" : "--none--")} "
				+ $"| reason: {caller} "
				+ $"| children: {_childrenInterestedInViewportUpdates}");

			if (viewportUpdated
				&& (
					!isInternal // We don't want to raise the event when we are only initializing the tree due to a new event handler somewhere in sub tree
					|| _hasNewHandler // but if we have a new local handler, we do need to raise the event!
				))
			{
				_hasNewHandler = false;

				// Note: The event only notify about the parentViewport (expressed in local coordinate space!),
				//		 the "local effective viewport" is used only by our children.
				_effectiveViewportChanged?.Invoke(this, new EffectiveViewportChangedEventArgs(parentViewport.Effective));
			}

			if (_childrenInterestedInViewportUpdates > 0 && (isInitial || viewportUpdated))
			{
				var children = Uno.UI.Extensions.DependencyObjectExtensions.GetChildren(this);
				foreach (var child in children)
				{
					if (child is IFrameworkElement_EffectiveViewport childFwElt)
					{
						childFwElt.OnParentViewportChanged(isInitial, isInternal, this, viewport);
					}
				}
			}
		}

		[Conditional("TRACE_EFFECTIVE_VIEWPORT")]
		private void TRACE_EFFECTIVE_VIEWPORT(string text)
		{
#if TRACE_EFFECTIVE_VIEWPORT
			Console.WriteLine($"{this.GetDebugIdentifier()} {text}");
#endif
		}
	}
}
