﻿using System;
using Uno.Disposables;
using Uno.UI.Xaml;

namespace Windows.UI.Xaml.Media
{
	public partial class AcrylicBrush
	{
		private const string BlurSize = "20px";
		private const string CssSupportCondition =
			"(backdrop-filter: blur(20px)) or (-webkit-backdrop-filter: blur(20px))";

		private static bool? _isBackdropFilterSupported;

		/// <summary>
		/// Subscribes to AcrylicBrush for a given UI element and applies it.
		/// </summary>
		/// <param name="uiElement">UI element.</param>
		/// <returns>Disposable.</returns>
		internal IDisposable Subscribe(UIElement uiElement)
		{
			var compositeDisposable = new CompositeDisposable(6);

			this.RegisterDisposablePropertyChangedCallback(
				AlwaysUseFallbackProperty,
				(_, __) => Apply(uiElement))
					.DisposeWith(compositeDisposable);

			this.RegisterDisposablePropertyChangedCallback(
				FallbackColorProperty,
				(_, __) => Apply(uiElement))
					.DisposeWith(compositeDisposable);

			this.RegisterDisposablePropertyChangedCallback(
				TintColorProperty,
				(_, __) => Apply(uiElement))
					.DisposeWith(compositeDisposable);

			this.RegisterDisposablePropertyChangedCallback(
				TintOpacityProperty,
				(_, __) => Apply(uiElement))
					.DisposeWith(compositeDisposable);

			this.RegisterDisposablePropertyChangedCallback(
				OpacityProperty,
				(_, __) => Apply(uiElement))
					.DisposeWith(compositeDisposable);

			// Apply the current state of the brush
			Apply(uiElement);

			Disposable.Create(() => ResetStyle(uiElement))
				.DisposeWith(compositeDisposable);

			return compositeDisposable;
		}

		/// <summary>
		/// Applies the current state of Acrylic brush to a given UI element
		/// </summary>
		/// <param name="uiElement">UI element to set background brush to.</param>
		internal void Apply(UIElement uiElement)
		{
			var isBackdropSupported = IsBackdropFilterSupported();
			ResetStyle(uiElement);
			if (AlwaysUseFallback || !isBackdropSupported)
			{
				// Use plain fallback color
				uiElement.SetStyle("background-color", FallbackColorWithOpacity.ToCssString());
			}
			else
			{
				// "real" acrylic
				uiElement.SetStyle(
					("-webkit-backdrop-filter", $"blur({BlurSize})"),
					("backdrop-filter", $"blur({BlurSize})"),
					("background-color", TintColorWithTintOpacity.ToCssString()));
			}
		}

		/// <summary>
		/// Resets the AcrylicBrush-related properties on a given UIElement.
		/// </summary>
		/// <param name="element">Element.</param>
		internal static void ResetStyle(UIElement element)
		{
			element.ResetStyle(
				"-webkit-backdrop-filter",
				"backdrop-filter",
				"background-color");
		}

		/// <summary>
		/// Verifies if the current browser supports backdrop filter in CSS.
		/// </summary>
		/// <returns>Value indicating whether backdrop filter is supported.</returns>
		private static bool IsBackdropFilterSupported() =>
			_isBackdropFilterSupported ??= WindowManagerInterop.IsCssFeatureSupported(CssSupportCondition);
	}
}
