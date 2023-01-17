#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2ClientCertificateRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate SelectedCertificate
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2ClientCertificate CoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs", "CoreWebView2ClientCertificate CoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2ClientCertificateRequestedEventArgs.Handled is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs", "bool CoreWebView2ClientCertificateRequestedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2ClientCertificateRequestedEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs", "bool CoreWebView2ClientCertificateRequestedEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<string> AllowedCertificateAuthorities
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> CoreWebView2ClientCertificateRequestedEventArgs.AllowedCertificateAuthorities is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Host
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2ClientCertificateRequestedEventArgs.Host is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsProxy
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreWebView2ClientCertificateRequestedEventArgs.IsProxy is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate> MutuallyTrustedCertificates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<CoreWebView2ClientCertificate> CoreWebView2ClientCertificateRequestedEventArgs.MutuallyTrustedCertificates is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Port
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CoreWebView2ClientCertificateRequestedEventArgs.Port is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Host.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Port.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.IsProxy.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.AllowedCertificateAuthorities.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.MutuallyTrustedCertificates.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.SelectedCertificate.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Cancel.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Cancel.set
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Handled.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateRequestedEventArgs.Handled.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral CoreWebView2ClientCertificateRequestedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
