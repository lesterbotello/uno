#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CleanUpVirtualizedItemEventArgs : global::Windows.UI.Xaml.RoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CleanUpVirtualizedItemEventArgs.Cancel is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CleanUpVirtualizedItemEventArgs.Cancel");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs", "bool CleanUpVirtualizedItemEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.UIElement UIElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement CleanUpVirtualizedItemEventArgs.UIElement is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UIElement%20CleanUpVirtualizedItemEventArgs.UIElement");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member object CleanUpVirtualizedItemEventArgs.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20CleanUpVirtualizedItemEventArgs.Value");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs.Value.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs.UIElement.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs.Cancel.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs.Cancel.set
	}
}
