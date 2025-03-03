#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GridViewItemDataAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public GridViewItemDataAutomationPeer( object item,  global::Windows.UI.Xaml.Automation.Peers.GridViewAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer", "GridViewItemDataAutomationPeer.GridViewItemDataAutomationPeer(object item, GridViewAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer.GridViewItemDataAutomationPeer(object, Windows.UI.Xaml.Automation.Peers.GridViewAutomationPeer)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer", "void GridViewItemDataAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}
