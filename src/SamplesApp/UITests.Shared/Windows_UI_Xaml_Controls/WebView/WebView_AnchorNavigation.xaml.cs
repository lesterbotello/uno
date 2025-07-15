using System;
using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml.Controls;
using Uno.Extensions;
using Uno.Logging;

namespace Uno.UI.Samples.Content.UITests.WebView
{
	[Sample(Description = "This sample tests that anchor navigation raises the proper events. The 2 uris received from the NavigationStarting and NavigationCompleted must update whether you tap the NavigateToAnchor button or tap on anchors from the web content.")]
	public sealed partial class WebView_AnchorNavigation : UserControl
	{
		public WebView_AnchorNavigation()
		{
			InitializeComponent();

			webView.Navigate(new Uri("https://uno-assets.platform.uno/tests/docs/WebView_NavigateToAnchor.html"));
			webView.NavigationStarting += WebView_NavigationStarting;
			webView.NavigationCompleted += WebView_NavigationCompleted;
		}

		private void WebView_NavigationStarting(Microsoft.UI.Xaml.Controls.WebView sender, WebViewNavigationStartingEventArgs args)
		{
			NavigationStartingTextBlock.Text = args.Uri.AbsoluteUri;
			System.Diagnostics.Debug.WriteLine($"WebView_AnchorNavigation: URI for Navigation Started: {args.Uri.AbsoluteUri}");
		}

		private void WebView_NavigationCompleted(Microsoft.UI.Xaml.Controls.WebView sender, WebViewNavigationCompletedEventArgs args)
		{
			NavigationCompletedTextBlock.Text = args.Uri.AbsoluteUri;
			System.Diagnostics.Debug.WriteLine($"WebView_AnchorNavigation: URI for Navigation Completed: {args.Uri.AbsoluteUri}");
		}

		private void ButtonClicked()
		{
			webView.Navigate(new Uri("https://uno-assets.platform.uno/tests/docs/WebView_NavigateToAnchor.html#section-1"));
		}

		private void OnClickAnchor()
		{
			var uri = new Uri(webView.Source, "#page-4");
			webView.Source = uri;
		}
	}
}
