#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FlipViewAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public FlipViewAutomationPeer( global::Windows.UI.Xaml.Controls.FlipView owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.FlipViewAutomationPeer", "FlipViewAutomationPeer.FlipViewAutomationPeer(FlipView owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.FlipViewAutomationPeer.FlipViewAutomationPeer(Windows.UI.Xaml.Controls.FlipView)
	}
}
