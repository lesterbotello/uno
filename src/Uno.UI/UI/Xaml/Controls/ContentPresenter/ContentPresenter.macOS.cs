﻿using System;
using System.Drawing;
using AppKit;
using Uno.Extensions;
using Uno.UI;
using Uno.UI.DataBinding;
using Windows.UI.Xaml.Shapes;

namespace Windows.UI.Xaml.Controls
{
	/// <summary>
	/// Declares a Content presenter
	/// </summary>
	/// <remarks>
	/// The content presenter is used for compatibility with WPF concepts,
	/// but the ContentSource property is not available, because there are ControlTemplates for now.
	/// </remarks>
	public partial class ContentPresenter
	{
		partial void SetUpdateTemplatePartial()
		{
			this.InvalidateMeasure();
		}

		partial void RegisterContentTemplateRoot()
		{
			if (Subviews.Length != 0)
			{
				throw new Exception("A Xaml control may not contain more than one child.");
			}

			ContentTemplateRoot.Frame = Bounds;
			ContentTemplateRoot.AutoresizingMask = NSViewResizingMask.HeightSizable | NSViewResizingMask.WidthSizable;
			AddSubview(ContentTemplateRoot);
		}

		partial void UnregisterContentTemplateRoot()
		{
			// If Content is a view it may have already been set as Content somewhere else in certain scenarios, eg virtualizing collections
			if (ContentTemplateRoot.Superview == this)
			{
				ContentTemplateRoot?.RemoveFromSuperview();
			}
		}

		public override void Layout()
		{
			base.Layout();
			UpdateBorder();
		}

		bool ICustomClippingElement.AllowClippingToLayoutSlot => CornerRadius == CornerRadius.None;

		bool ICustomClippingElement.ForceClippingToLayoutSlot => false;
	}
}
