#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompositionMaskBrush : global::Microsoft.UI.Composition.CompositionBrush
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionBrush Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionMaskBrush.Source is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionMaskBrush", "CompositionBrush CompositionMaskBrush.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionBrush Mask
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionBrush CompositionMaskBrush.Mask is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionMaskBrush", "CompositionBrush CompositionMaskBrush.Mask");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Source.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Mask.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Mask.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionMaskBrush.Source.get
	}
}
