#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListViewAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ListViewAutomationPeer( global::Windows.UI.Xaml.Controls.ListView owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListViewAutomationPeer", "ListViewAutomationPeer.ListViewAutomationPeer(ListView owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListViewAutomationPeer.ListViewAutomationPeer(Windows.UI.Xaml.Controls.ListView)
	}
}
