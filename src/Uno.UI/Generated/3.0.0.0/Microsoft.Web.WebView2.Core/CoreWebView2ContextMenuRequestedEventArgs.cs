#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2ContextMenuRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int SelectedCommandId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs", "int CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2ContextMenuRequestedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs", "bool CoreWebView2ContextMenuRequestedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuTarget ContextMenuTarget
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2ContextMenuTarget CoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Point Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point CoreWebView2ContextMenuRequestedEventArgs.Location is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem> MenuItems
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<CoreWebView2ContextMenuItem> CoreWebView2ContextMenuRequestedEventArgs.MenuItems is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.MenuItems.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.ContextMenuTarget.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.Location.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.Handled.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.Handled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral CoreWebView2ContextMenuRequestedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
