#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapModel3D : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapModel3D() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapModel3D", "MapModel3D.MapModel3D()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapModel3D.MapModel3D()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.UI.Xaml.Controls.Maps.MapModel3D> CreateFrom3MFAsync( global::Windows.Storage.Streams.IRandomAccessStreamReference source)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<MapModel3D> MapModel3D.CreateFrom3MFAsync(IRandomAccessStreamReference source) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CMapModel3D%3E%20MapModel3D.CreateFrom3MFAsync%28IRandomAccessStreamReference%20source%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.UI.Xaml.Controls.Maps.MapModel3D> CreateFrom3MFAsync( global::Windows.Storage.Streams.IRandomAccessStreamReference source,  global::Windows.UI.Xaml.Controls.Maps.MapModel3DShadingOption shadingOption)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<MapModel3D> MapModel3D.CreateFrom3MFAsync(IRandomAccessStreamReference source, MapModel3DShadingOption shadingOption) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CMapModel3D%3E%20MapModel3D.CreateFrom3MFAsync%28IRandomAccessStreamReference%20source%2C%20MapModel3DShadingOption%20shadingOption%29");
		}
		#endif
	}
}
