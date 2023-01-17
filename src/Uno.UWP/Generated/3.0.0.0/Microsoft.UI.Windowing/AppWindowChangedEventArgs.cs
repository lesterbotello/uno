#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class AppWindowChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidPositionChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidPositionChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidPresenterChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidPresenterChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidSizeChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidSizeChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidVisibilityChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidVisibilityChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool DidZOrderChange
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.DidZOrderChange is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsZOrderAtBottom
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.IsZOrderAtBottom is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsZOrderAtTop
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowChangedEventArgs.IsZOrderAtTop is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.WindowId ZOrderBelowWindowId
		{
			get
			{
				throw new global::System.NotImplementedException("The member WindowId AppWindowChangedEventArgs.ZOrderBelowWindowId is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidSizeChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidPresenterChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidPositionChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidVisibilityChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.DidZOrderChange.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.IsZOrderAtBottom.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.IsZOrderAtTop.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowChangedEventArgs.ZOrderBelowWindowId.get
	}
}
