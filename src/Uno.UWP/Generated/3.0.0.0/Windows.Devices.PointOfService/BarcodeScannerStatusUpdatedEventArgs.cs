#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class BarcodeScannerStatusUpdatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ExtendedStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint BarcodeScannerStatusUpdatedEventArgs.ExtendedStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20BarcodeScannerStatusUpdatedEventArgs.ExtendedStatus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.PointOfService.BarcodeScannerStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarcodeScannerStatus BarcodeScannerStatusUpdatedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BarcodeScannerStatus%20BarcodeScannerStatusUpdatedEventArgs.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs.Status.get
		// Forced skipping of method Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs.ExtendedStatus.get
	}
}
