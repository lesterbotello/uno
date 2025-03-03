#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SemanticZoomAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IToggleProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Automation.ToggleState ToggleState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ToggleState SemanticZoomAutomationPeer.ToggleState is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ToggleState%20SemanticZoomAutomationPeer.ToggleState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SemanticZoomAutomationPeer( global::Windows.UI.Xaml.Controls.SemanticZoom owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer", "SemanticZoomAutomationPeer.SemanticZoomAutomationPeer(SemanticZoom owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer.SemanticZoomAutomationPeer(Windows.UI.Xaml.Controls.SemanticZoom)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer.ToggleState.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Toggle()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer", "void SemanticZoomAutomationPeer.Toggle()");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.IToggleProvider
	}
}
