#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DragUI 
	{
		// Skipping already declared method Windows.UI.Xaml.DragUI.SetContentFromBitmapImage(Windows.UI.Xaml.Media.Imaging.BitmapImage)
		// Skipping already declared method Windows.UI.Xaml.DragUI.SetContentFromBitmapImage(Windows.UI.Xaml.Media.Imaging.BitmapImage, Windows.Foundation.Point)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetContentFromSoftwareBitmap( global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DragUI", "void DragUI.SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetContentFromSoftwareBitmap( global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap,  global::Windows.Foundation.Point anchorPoint)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DragUI", "void DragUI.SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetContentFromDataPackage()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DragUI", "void DragUI.SetContentFromDataPackage()");
		}
		#endif
	}
}
