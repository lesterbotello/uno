#nullable disable

using System;
using System.Globalization;
using Android.Graphics;
using Android.Runtime;
using Android.Webkit;
using Microsoft.Web.WebView2.Core;
using Uno.Foundation.Logging;
using Windows.Web;

namespace Uno.UI.Xaml.Controls;

internal class InternalClient : Android.Webkit.WebViewClient
{
	private readonly CoreWebView2 _coreWebView;
	private readonly NativeWebViewWrapper _nativeWebViewWrapper;
#pragma warning disable CS0414 //TODO:MZ:
	//_owner is because we go through onReceivedError() and OnPageFinished() when the call fail.
	private bool _coreWebViewSuccess = true;
	//_owner is to not have duplicate event call
	private WebErrorStatus _webErrorStatus = WebErrorStatus.Unknown;

	// Track whether NavigationCompleted was already raised for this navigation
	private bool _navigationCompletedRaised;

	// Track the last navigation URL for anchor detection
	private string _lastNavigationUrl;

	internal InternalClient(CoreWebView2 coreWebView, NativeWebViewWrapper webViewWrapper)
	{
		_coreWebView = coreWebView;
		_nativeWebViewWrapper = webViewWrapper;
	}

	public override void DoUpdateVisitedHistory(Android.Webkit.WebView view, string url, bool isReload)
	{
		System.Diagnostics.Debug.WriteLine($"InternalClient.DoUpdateVisitedHistory: Started method execution for URL '{url}'");

		base.DoUpdateVisitedHistory(view, url, isReload);

		_nativeWebViewWrapper.DocumentTitle = view.Title;

		_nativeWebViewWrapper.RefreshHistoryProperties();

		_coreWebView.Source = url;
		_coreWebView.RaiseHistoryChanged();

		var uri = new Uri(url);
		_coreWebView.RaiseNavigationCompleted(uri, true, 200, CoreWebView2WebErrorStatus.Unknown, shouldSetSource: true);
		_navigationCompletedRaised = true;
		_lastNavigationUrl = url;
	}

#pragma warning disable CS0672 // Member overrides obsolete member
	public override bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, string url)
#pragma warning restore CS0672 // Member overrides obsolete member
	{
		if (url.StartsWith(Uri.UriSchemeMailto, true, CultureInfo.InvariantCulture))
		{
			_nativeWebViewWrapper.CreateAndLaunchMailtoIntent(view.Context, url);
			return true;
		}

		 // Always raise NavigationStarting, even for anchor navigation
		_coreWebViewSuccess = true;
		_navigationCompletedRaised = false;

		return false;
	}

	public override void OnPageStarted(Android.Webkit.WebView view, string url, Bitmap favicon)
	{
		base.OnPageStarted(view, url, favicon);
		//Reset Webview Success on page started so that if we have successful navigation we don't send an webView error if a previous error happened.
		_coreWebViewSuccess = true;
		_navigationCompletedRaised = false; // Reset for new navigation
	}

#pragma warning disable 0672, 618, CA1422
	public override void OnReceivedError(Android.Webkit.WebView view, [GeneratedEnum] ClientError errorCode, string description, string failingUrl)
	{
		_coreWebViewSuccess = false;
		_webErrorStatus = ConvertClientError(errorCode);

		base.OnReceivedError(view, errorCode, description, failingUrl);
	}
#pragma warning restore 0672, 618, CA1422

	public override void OnPageFinished(Android.Webkit.WebView view, string url)
	{
		_nativeWebViewWrapper.DocumentTitle = view.Title;

		// Only raise NavigationCompleted if it wasn't already raised in DoUpdateVisitedHistory
		// This helps avoid duplicate NavigationCompleted events
		if (!_navigationCompletedRaised)
		{
			var uri = !_nativeWebViewWrapper._wasLoadedFromString && !string.IsNullOrEmpty(url) ? new Uri(url) : null;
			_coreWebView.RaiseNavigationCompleted(uri, true, 200, CoreWebView2WebErrorStatus.Unknown);
		}

		base.OnPageFinished(view, url);
	}

	//Matched using these two sources
	//http://developer.xamarin.com/api/type/Android.Webkit.ClientError/
	//https://msdn.microsoft.com/en-ca/library/windows/apps/windows.web.weberrorstatus
	private WebErrorStatus ConvertClientError(ClientError clientError) => clientError switch
	{
		ClientError.Authentication => WebErrorStatus.Unauthorized,
		ClientError.BadUrl => WebErrorStatus.BadRequest,
		ClientError.Connect => WebErrorStatus.CannotConnect,
		ClientError.FailedSslHandshake => WebErrorStatus.UnexpectedClientError,
		ClientError.File => WebErrorStatus.UnexpectedClientError,
		ClientError.FileNotFound => WebErrorStatus.NotFound,
		ClientError.HostLookup => WebErrorStatus.HostNameNotResolved,
		ClientError.Io => WebErrorStatus.InternalServerError,
		ClientError.ProxyAuthentication => WebErrorStatus.ProxyAuthenticationRequired,
		ClientError.RedirectLoop => WebErrorStatus.RedirectFailed,
		ClientError.Timeout => WebErrorStatus.Timeout,
		ClientError.TooManyRequests => WebErrorStatus.UnexpectedClientError,
		ClientError.Unknown => WebErrorStatus.Unknown,
		ClientError.UnsupportedAuthScheme => WebErrorStatus.Unauthorized,
		ClientError.UnsupportedScheme => WebErrorStatus.UnexpectedClientError,
		_ => WebErrorStatus.UnexpectedClientError,
	};
}
