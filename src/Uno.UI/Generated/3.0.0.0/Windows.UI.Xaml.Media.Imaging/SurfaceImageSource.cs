#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Imaging
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SurfaceImageSource : global::Windows.UI.Xaml.Media.ImageSource
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SurfaceImageSource( int pixelWidth,  int pixelHeight) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.SurfaceImageSource", "SurfaceImageSource.SurfaceImageSource(int pixelWidth, int pixelHeight)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Imaging.SurfaceImageSource.SurfaceImageSource(int, int)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SurfaceImageSource( int pixelWidth,  int pixelHeight,  bool isOpaque) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Imaging.SurfaceImageSource", "SurfaceImageSource.SurfaceImageSource(int pixelWidth, int pixelHeight, bool isOpaque)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Imaging.SurfaceImageSource.SurfaceImageSource(int, int, bool)
	}
}
