#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListViewHeaderItemAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ListViewBaseHeaderItemAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ListViewHeaderItemAutomationPeer( global::Windows.UI.Xaml.Controls.ListViewHeaderItem owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListViewHeaderItemAutomationPeer", "ListViewHeaderItemAutomationPeer.ListViewHeaderItemAutomationPeer(ListViewHeaderItem owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListViewHeaderItemAutomationPeer.ListViewHeaderItemAutomationPeer(Windows.UI.Xaml.Controls.ListViewHeaderItem)
	}
}
