#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BrushTransition 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Duration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan BrushTransition.Duration is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20BrushTransition.Duration");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.BrushTransition", "TimeSpan BrushTransition.Duration");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public BrushTransition() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.BrushTransition", "BrushTransition.BrushTransition()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.BrushTransition.BrushTransition()
		// Forced skipping of method Windows.UI.Xaml.BrushTransition.Duration.get
		// Forced skipping of method Windows.UI.Xaml.BrushTransition.Duration.set
	}
}
