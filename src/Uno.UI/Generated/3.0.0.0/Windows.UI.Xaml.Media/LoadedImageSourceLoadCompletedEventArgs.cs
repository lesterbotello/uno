#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class LoadedImageSourceLoadCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.LoadedImageSourceLoadStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member LoadedImageSourceLoadStatus LoadedImageSourceLoadCompletedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=LoadedImageSourceLoadStatus%20LoadedImageSourceLoadCompletedEventArgs.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.LoadedImageSourceLoadCompletedEventArgs.Status.get
	}
}
