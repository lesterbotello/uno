#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapActualCameraChangingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.Maps.MapCamera Camera
		{
			get
			{
				throw new global::System.NotImplementedException("The member MapCamera MapActualCameraChangingEventArgs.Camera is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MapCamera%20MapActualCameraChangingEventArgs.Camera");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason ChangeReason
		{
			get
			{
				throw new global::System.NotImplementedException("The member MapCameraChangeReason MapActualCameraChangingEventArgs.ChangeReason is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MapCameraChangeReason%20MapActualCameraChangingEventArgs.ChangeReason");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapActualCameraChangingEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs", "MapActualCameraChangingEventArgs.MapActualCameraChangingEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs.MapActualCameraChangingEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs.Camera.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs.ChangeReason.get
	}
}
