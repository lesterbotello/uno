#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2CompositionController : global::Microsoft.Web.WebView2.Core.CoreWebView2Controller
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object RootVisualTarget
		{
			get
			{
				throw new global::System.NotImplementedException("The member object CoreWebView2CompositionController.RootVisualTarget is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20CoreWebView2CompositionController.RootVisualTarget");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2CompositionController", "object CoreWebView2CompositionController.RootVisualTarget");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Core.CoreCursor Cursor
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreCursor CoreWebView2CompositionController.Cursor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreCursor%20CoreWebView2CompositionController.Cursor");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.RootVisualTarget.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.RootVisualTarget.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.CursorChanged.add
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.CursorChanged.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SendMouseInput( global::Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind eventKind,  global::Microsoft.Web.WebView2.Core.CoreWebView2MouseEventVirtualKeys virtualKeys,  uint mouseData,  global::Windows.Foundation.Point point)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2CompositionController", "void CoreWebView2CompositionController.SendMouseInput(CoreWebView2MouseEventKind eventKind, CoreWebView2MouseEventVirtualKeys virtualKeys, uint mouseData, Point point)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SendPointerInput( global::Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind eventKind,  global::Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo pointerInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2CompositionController", "void CoreWebView2CompositionController.SendPointerInput(CoreWebView2PointerEventKind eventKind, CoreWebView2PointerInfo pointerInfo)");
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2CompositionController.Cursor.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2CompositionController, object> CursorChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2CompositionController", "event TypedEventHandler<CoreWebView2CompositionController, object> CoreWebView2CompositionController.CursorChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2CompositionController", "event TypedEventHandler<CoreWebView2CompositionController, object> CoreWebView2CompositionController.CursorChanged");
			}
		}
		#endif
	}
}
