#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Window 
	{
		#if false || __IOS__ || false || false || false || false || false
		[global::Uno.NotImplemented("__IOS__")]
		public  string Title
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Window.Title is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Window.Title");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Window", "string Window.Title");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ExtendsContentIntoTitleBar
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool Window.ExtendsContentIntoTitleBar is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20Window.ExtendsContentIntoTitleBar");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Window", "bool Window.ExtendsContentIntoTitleBar");
			}
		}
		#endif
		// Skipping already declared property Content
		// Skipping already declared property Bounds
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Compositor Compositor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Compositor Window.Compositor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Compositor%20Window.Compositor");
			}
		}
		#endif
		// Skipping already declared property CoreWindow
		// Skipping already declared property Dispatcher
		// Skipping already declared property DispatcherQueue
		// Skipping already declared property Visible
		// Skipping already declared property Current
		// Skipping already declared method Microsoft.UI.Xaml.Window.Window()
		// Forced skipping of method Microsoft.UI.Xaml.Window.Window()
		// Forced skipping of method Microsoft.UI.Xaml.Window.Bounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Visible.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Window.CoreWindow.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Compositor.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Dispatcher.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.DispatcherQueue.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Title.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.Title.set
		// Forced skipping of method Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar.get
		// Forced skipping of method Microsoft.UI.Xaml.Window.ExtendsContentIntoTitleBar.set
		// Forced skipping of method Microsoft.UI.Xaml.Window.Activated.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.Activated.remove
		// Forced skipping of method Microsoft.UI.Xaml.Window.Closed.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.Closed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Window.SizeChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.SizeChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Window.VisibilityChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Window.VisibilityChanged.remove
		// Skipping already declared method Microsoft.UI.Xaml.Window.Activate()
		// Skipping already declared method Microsoft.UI.Xaml.Window.Close()
		// Skipping already declared method Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)
		// Forced skipping of method Microsoft.UI.Xaml.Window.Current.get
		// Skipping already declared event Microsoft.UI.Xaml.Window.Activated
		// Skipping already declared event Microsoft.UI.Xaml.Window.Closed
		// Skipping already declared event Microsoft.UI.Xaml.Window.SizeChanged
		// Skipping already declared event Microsoft.UI.Xaml.Window.VisibilityChanged
	}
}
