#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Graphics.Display
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DisplayInformation : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Dispatching.DispatcherQueue DispatcherQueue
		{
			get
			{
				throw new global::System.NotImplementedException("The member DispatcherQueue DisplayInformation.DispatcherQueue is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsStereoEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DisplayInformation.IsStereoEnabled is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.IsStereoEnabled.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.Streams.IRandomAccessStream> GetColorProfileAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IRandomAccessStream> DisplayInformation.GetColorProfileAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.IsStereoEnabledChanged.add
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.IsStereoEnabledChanged.remove
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.DispatcherQueue.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IRandomAccessStream GetColorProfile()
		{
			throw new global::System.NotImplementedException("The member IRandomAccessStream DisplayInformation.GetColorProfile() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.ColorProfileChanged.add
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.ColorProfileChanged.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Graphics.Display.DisplayAdvancedColorInfo GetAdvancedColorInfo()
		{
			throw new global::System.NotImplementedException("The member DisplayAdvancedColorInfo DisplayInformation.GetAdvancedColorInfo() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.AdvancedColorInfoChanged.add
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.AdvancedColorInfoChanged.remove
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.Destroyed.add
		// Forced skipping of method Microsoft.Graphics.Display.DisplayInformation.Destroyed.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "void DisplayInformation.Dispose()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.Graphics.Display.DisplayInformation CreateForWindowId( global::Microsoft.UI.WindowId windowId)
		{
			throw new global::System.NotImplementedException("The member DisplayInformation DisplayInformation.CreateForWindowId(WindowId windowId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.Graphics.Display.DisplayInformation CreateForDisplayId( global::Microsoft.UI.DisplayId displayId)
		{
			throw new global::System.NotImplementedException("The member DisplayInformation DisplayInformation.CreateForDisplayId(DisplayId displayId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Graphics.Display.DisplayInformation, object> AdvancedColorInfoChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.AdvancedColorInfoChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.AdvancedColorInfoChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Graphics.Display.DisplayInformation, object> ColorProfileChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.ColorProfileChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.ColorProfileChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Graphics.Display.DisplayInformation, object> Destroyed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.Destroyed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.Destroyed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.Graphics.Display.DisplayInformation, object> IsStereoEnabledChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.IsStereoEnabledChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.Graphics.Display.DisplayInformation", "event TypedEventHandler<DisplayInformation, object> DisplayInformation.IsStereoEnabledChanged");
			}
		}
		#endif
		// Processing: System.IDisposable
	}
}
