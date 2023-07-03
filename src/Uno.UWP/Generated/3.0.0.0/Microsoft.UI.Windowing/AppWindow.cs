#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindow 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Title
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppWindow.Title is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AppWindow.Title");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "string AppWindow.Title");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsShownInSwitchers
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindow.IsShownInSwitchers is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AppWindow.IsShownInSwitchers");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "bool AppWindow.IsShownInSwitchers");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.WindowId Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member WindowId AppWindow.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WindowId%20AppWindow.Id");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsVisible
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindow.IsVisible is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AppWindow.IsVisible");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.WindowId OwnerWindowId
		{
			get
			{
				throw new global::System.NotImplementedException("The member WindowId AppWindow.OwnerWindowId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WindowId%20AppWindow.OwnerWindowId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.PointInt32 Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member PointInt32 AppWindow.Position is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PointInt32%20AppWindow.Position");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Windowing.AppWindowPresenter Presenter
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppWindowPresenter AppWindow.Presenter is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppWindowPresenter%20AppWindow.Presenter");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.SizeInt32 Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member SizeInt32 AppWindow.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SizeInt32%20AppWindow.Size");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Windowing.AppWindowTitleBar TitleBar
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppWindowTitleBar AppWindow.TitleBar is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppWindowTitleBar%20AppWindow.TitleBar");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.SizeInt32 ClientSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member SizeInt32 AppWindow.ClientSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SizeInt32%20AppWindow.ClientSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void MoveAndResize( global::Windows.Graphics.RectInt32 rect,  global::Microsoft.UI.Windowing.DisplayArea displayarea)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.MoveAndResize(RectInt32 rect, DisplayArea displayarea)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.IsShownInSwitchers.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.IsShownInSwitchers.set
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.IsVisible.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.OwnerWindowId.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Position.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Presenter.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Size.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Title.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Id.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.TitleBar.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Destroy()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.Destroy()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Hide()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.Hide()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Move( global::Windows.Graphics.PointInt32 position)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.Move(PointInt32 position)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void MoveAndResize( global::Windows.Graphics.RectInt32 rect)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.MoveAndResize(RectInt32 rect)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Title.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Resize( global::Windows.Graphics.SizeInt32 size)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.Resize(SizeInt32 size)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetIcon( string iconPath)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.SetIcon(string iconPath)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetIcon( global::Microsoft.UI.IconId iconId)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.SetIcon(IconId iconId)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetPresenter( global::Microsoft.UI.Windowing.AppWindowPresenter appWindowPresenter)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.SetPresenter(AppWindowPresenter appWindowPresenter)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetPresenter( global::Microsoft.UI.Windowing.AppWindowPresenterKind appWindowPresenterKind)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.SetPresenter(AppWindowPresenterKind appWindowPresenterKind)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Show()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.Show()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Show( bool activateWindow)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.Show(bool activateWindow)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Changed.add
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Changed.remove
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Closing.add
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Closing.remove
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Destroying.add
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.Destroying.remove
		// Forced skipping of method Microsoft.UI.Windowing.AppWindow.ClientSize.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void MoveInZOrderAtBottom()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.MoveInZOrderAtBottom()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void MoveInZOrderAtTop()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.MoveInZOrderAtTop()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void MoveInZOrderBelow( global::Microsoft.UI.WindowId windowId)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.MoveInZOrderBelow(WindowId windowId)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ResizeClient( global::Windows.Graphics.SizeInt32 size)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.ResizeClient(SizeInt32 size)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ShowOnceWithRequestedStartupState()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "void AppWindow.ShowOnceWithRequestedStartupState()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.AppWindow Create()
		{
			throw new global::System.NotImplementedException("The member AppWindow AppWindow.Create() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppWindow%20AppWindow.Create%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.AppWindow Create( global::Microsoft.UI.Windowing.AppWindowPresenter appWindowPresenter)
		{
			throw new global::System.NotImplementedException("The member AppWindow AppWindow.Create(AppWindowPresenter appWindowPresenter) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppWindow%20AppWindow.Create%28AppWindowPresenter%20appWindowPresenter%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.AppWindow Create( global::Microsoft.UI.Windowing.AppWindowPresenter appWindowPresenter,  global::Microsoft.UI.WindowId ownerWindowId)
		{
			throw new global::System.NotImplementedException("The member AppWindow AppWindow.Create(AppWindowPresenter appWindowPresenter, WindowId ownerWindowId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppWindow%20AppWindow.Create%28AppWindowPresenter%20appWindowPresenter%2C%20WindowId%20ownerWindowId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.AppWindow GetFromWindowId( global::Microsoft.UI.WindowId windowId)
		{
			throw new global::System.NotImplementedException("The member AppWindow AppWindow.GetFromWindowId(WindowId windowId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppWindow%20AppWindow.GetFromWindowId%28WindowId%20windowId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.AppWindow, global::Microsoft.UI.Windowing.AppWindowChangedEventArgs> Changed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "event TypedEventHandler<AppWindow, AppWindowChangedEventArgs> AppWindow.Changed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "event TypedEventHandler<AppWindow, AppWindowChangedEventArgs> AppWindow.Changed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.AppWindow, global::Microsoft.UI.Windowing.AppWindowClosingEventArgs> Closing
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "event TypedEventHandler<AppWindow, AppWindowClosingEventArgs> AppWindow.Closing");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "event TypedEventHandler<AppWindow, AppWindowClosingEventArgs> AppWindow.Closing");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.AppWindow, object> Destroying
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "event TypedEventHandler<AppWindow, object> AppWindow.Destroying");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindow", "event TypedEventHandler<AppWindow, object> AppWindow.Destroying");
			}
		}
		#endif
	}
}
