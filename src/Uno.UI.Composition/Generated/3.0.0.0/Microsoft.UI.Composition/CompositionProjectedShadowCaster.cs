#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompositionProjectedShadowCaster : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Visual CastingVisual
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionProjectedShadowCaster.CastingVisual is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionProjectedShadowCaster", "Visual CompositionProjectedShadowCaster.CastingVisual");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionBrush Brush
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionProjectedShadowCaster.Brush is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionProjectedShadowCaster", "CompositionBrush CompositionProjectedShadowCaster.Brush");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowCaster.Brush.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowCaster.CastingVisual.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowCaster.Brush.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionProjectedShadowCaster.CastingVisual.get
	}
}
