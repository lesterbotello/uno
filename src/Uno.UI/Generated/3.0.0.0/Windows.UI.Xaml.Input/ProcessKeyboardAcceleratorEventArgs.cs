#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ProcessKeyboardAcceleratorEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ProcessKeyboardAcceleratorEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20ProcessKeyboardAcceleratorEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs", "bool ProcessKeyboardAcceleratorEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.VirtualKey Key
		{
			get
			{
				throw new global::System.NotImplementedException("The member VirtualKey ProcessKeyboardAcceleratorEventArgs.Key is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VirtualKey%20ProcessKeyboardAcceleratorEventArgs.Key");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.VirtualKeyModifiers Modifiers
		{
			get
			{
				throw new global::System.NotImplementedException("The member VirtualKeyModifiers ProcessKeyboardAcceleratorEventArgs.Modifiers is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VirtualKeyModifiers%20ProcessKeyboardAcceleratorEventArgs.Modifiers");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs.Key.get
		// Forced skipping of method Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs.Modifiers.get
		// Forced skipping of method Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs.Handled.get
		// Forced skipping of method Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs.Handled.set
	}
}
