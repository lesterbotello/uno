#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AutomationProviderRequestedEventArgs : global::Windows.UI.Core.ICoreWindowEventArgs
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object AutomationProvider
		{
			get
			{
				throw new global::System.NotImplementedException("The member object AutomationProviderRequestedEventArgs.AutomationProvider is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=object%20AutomationProviderRequestedEventArgs.AutomationProvider");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.AutomationProviderRequestedEventArgs", "object AutomationProviderRequestedEventArgs.AutomationProvider");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AutomationProviderRequestedEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AutomationProviderRequestedEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.AutomationProviderRequestedEventArgs", "bool AutomationProviderRequestedEventArgs.Handled");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.AutomationProvider.get
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.AutomationProvider.set
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Core.AutomationProviderRequestedEventArgs.Handled.set
		// Processing: Windows.UI.Core.ICoreWindowEventArgs
	}
}
