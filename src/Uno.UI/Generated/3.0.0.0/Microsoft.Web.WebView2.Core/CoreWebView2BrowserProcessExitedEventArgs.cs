#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2BrowserProcessExitedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2BrowserProcessExitKind BrowserProcessExitKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2BrowserProcessExitKind CoreWebView2BrowserProcessExitedEventArgs.BrowserProcessExitKind is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint BrowserProcessId
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CoreWebView2BrowserProcessExitedEventArgs.BrowserProcessId is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2BrowserProcessExitedEventArgs.BrowserProcessExitKind.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2BrowserProcessExitedEventArgs.BrowserProcessId.get
	}
}
