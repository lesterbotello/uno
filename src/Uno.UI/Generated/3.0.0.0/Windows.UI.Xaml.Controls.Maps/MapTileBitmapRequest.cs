#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapTileBitmapRequest 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IRandomAccessStreamReference PixelData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStreamReference MapTileBitmapRequest.PixelData is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IRandomAccessStreamReference%20MapTileBitmapRequest.PixelData");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest", "IRandomAccessStreamReference MapTileBitmapRequest.PixelData");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapTileBitmapRequest() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest", "MapTileBitmapRequest.MapTileBitmapRequest()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest.MapTileBitmapRequest()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest.PixelData.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequest.PixelData.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member MapTileBitmapRequestDeferral MapTileBitmapRequest.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MapTileBitmapRequestDeferral%20MapTileBitmapRequest.GetDeferral%28%29");
		}
		#endif
	}
}
