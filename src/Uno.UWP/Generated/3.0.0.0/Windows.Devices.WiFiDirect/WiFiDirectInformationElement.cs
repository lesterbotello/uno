#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WiFiDirectInformationElement 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer WiFiDirectInformationElement.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20WiFiDirectInformationElement.Value");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectInformationElement", "IBuffer WiFiDirectInformationElement.Value");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte OuiType
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte WiFiDirectInformationElement.OuiType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%20WiFiDirectInformationElement.OuiType");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectInformationElement", "byte WiFiDirectInformationElement.OuiType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Oui
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer WiFiDirectInformationElement.Oui is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20WiFiDirectInformationElement.Oui");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectInformationElement", "IBuffer WiFiDirectInformationElement.Oui");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public WiFiDirectInformationElement() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFiDirect.WiFiDirectInformationElement", "WiFiDirectInformationElement.WiFiDirectInformationElement()");
		}
		#endif
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.WiFiDirectInformationElement()
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.Oui.get
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.Oui.set
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.OuiType.get
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.OuiType.set
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.Value.get
		// Forced skipping of method Windows.Devices.WiFiDirect.WiFiDirectInformationElement.Value.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IList<global::Windows.Devices.WiFiDirect.WiFiDirectInformationElement> CreateFromBuffer( global::Windows.Storage.Streams.IBuffer buffer)
		{
			throw new global::System.NotImplementedException("The member IList<WiFiDirectInformationElement> WiFiDirectInformationElement.CreateFromBuffer(IBuffer buffer) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CWiFiDirectInformationElement%3E%20WiFiDirectInformationElement.CreateFromBuffer%28IBuffer%20buffer%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IList<global::Windows.Devices.WiFiDirect.WiFiDirectInformationElement> CreateFromDeviceInformation( global::Windows.Devices.Enumeration.DeviceInformation deviceInformation)
		{
			throw new global::System.NotImplementedException("The member IList<WiFiDirectInformationElement> WiFiDirectInformationElement.CreateFromDeviceInformation(DeviceInformation deviceInformation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CWiFiDirectInformationElement%3E%20WiFiDirectInformationElement.CreateFromDeviceInformation%28DeviceInformation%20deviceInformation%29");
		}
		#endif
	}
}
