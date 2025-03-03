#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectorItemAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsSelected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SelectorItemAutomationPeer.IsSelected is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SelectorItemAutomationPeer.IsSelected");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple SelectionContainer
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRawElementProviderSimple SelectorItemAutomationPeer.SelectionContainer is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IRawElementProviderSimple%20SelectorItemAutomationPeer.SelectionContainer");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SelectorItemAutomationPeer( object item,  global::Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer", "SelectorItemAutomationPeer.SelectorItemAutomationPeer(object item, SelectorAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer.SelectorItemAutomationPeer(object, Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer.IsSelected.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer.SelectionContainer.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddToSelection()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer", "void SelectorItemAutomationPeer.AddToSelection()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RemoveFromSelection()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer", "void SelectorItemAutomationPeer.RemoveFromSelection()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Select()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer", "void SelectorItemAutomationPeer.Select()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
	}
}
