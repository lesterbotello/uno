#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarHighlighterButton : global::Windows.UI.Xaml.Controls.InkToolbarPenButton
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InkToolbarHighlighterButton() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarHighlighterButton", "InkToolbarHighlighterButton.InkToolbarHighlighterButton()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarHighlighterButton.InkToolbarHighlighterButton()
	}
}
