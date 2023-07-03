#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input.Custom
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class XusbGameControllerProvider : global::Windows.Gaming.Input.Custom.IGameControllerProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Gaming.Input.Custom.GameControllerVersionInfo FirmwareVersionInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member GameControllerVersionInfo XusbGameControllerProvider.FirmwareVersionInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GameControllerVersionInfo%20XusbGameControllerProvider.FirmwareVersionInfo");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort HardwareProductId
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort XusbGameControllerProvider.HardwareProductId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20XusbGameControllerProvider.HardwareProductId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort HardwareVendorId
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort XusbGameControllerProvider.HardwareVendorId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ushort%20XusbGameControllerProvider.HardwareVendorId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Gaming.Input.Custom.GameControllerVersionInfo HardwareVersionInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member GameControllerVersionInfo XusbGameControllerProvider.HardwareVersionInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=GameControllerVersionInfo%20XusbGameControllerProvider.HardwareVersionInfo");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsConnected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool XusbGameControllerProvider.IsConnected is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20XusbGameControllerProvider.IsConnected");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetVibration( double lowFrequencyMotorSpeed,  double highFrequencyMotorSpeed)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.Custom.XusbGameControllerProvider", "void XusbGameControllerProvider.SetVibration(double lowFrequencyMotorSpeed, double highFrequencyMotorSpeed)");
		}
		#endif
		// Forced skipping of method Windows.Gaming.Input.Custom.XusbGameControllerProvider.FirmwareVersionInfo.get
		// Forced skipping of method Windows.Gaming.Input.Custom.XusbGameControllerProvider.HardwareProductId.get
		// Forced skipping of method Windows.Gaming.Input.Custom.XusbGameControllerProvider.HardwareVendorId.get
		// Forced skipping of method Windows.Gaming.Input.Custom.XusbGameControllerProvider.HardwareVersionInfo.get
		// Forced skipping of method Windows.Gaming.Input.Custom.XusbGameControllerProvider.IsConnected.get
		// Processing: Windows.Gaming.Input.Custom.IGameControllerProvider
	}
}
