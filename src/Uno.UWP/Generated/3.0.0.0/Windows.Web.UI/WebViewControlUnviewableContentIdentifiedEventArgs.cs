#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.UI
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebViewControlUnviewableContentIdentifiedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string MediaType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebViewControlUnviewableContentIdentifiedEventArgs.MediaType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WebViewControlUnviewableContentIdentifiedEventArgs.MediaType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Referrer
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebViewControlUnviewableContentIdentifiedEventArgs.Referrer is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20WebViewControlUnviewableContentIdentifiedEventArgs.Referrer");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebViewControlUnviewableContentIdentifiedEventArgs.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20WebViewControlUnviewableContentIdentifiedEventArgs.Uri");
			}
		}
		#endif
		// Forced skipping of method Windows.Web.UI.WebViewControlUnviewableContentIdentifiedEventArgs.Uri.get
		// Forced skipping of method Windows.Web.UI.WebViewControlUnviewableContentIdentifiedEventArgs.Referrer.get
		// Forced skipping of method Windows.Web.UI.WebViewControlUnviewableContentIdentifiedEventArgs.MediaType.get
	}
}
