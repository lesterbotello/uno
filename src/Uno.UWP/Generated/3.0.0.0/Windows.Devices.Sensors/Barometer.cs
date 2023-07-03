#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if false || false || false || false || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class Barometer 
	{
		#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Barometer.ReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Barometer.ReportInterval");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Barometer", "uint Barometer.ReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Barometer.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Barometer.DeviceId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Barometer.MinimumReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Barometer.MinimumReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportLatency
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Barometer.ReportLatency is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Barometer.ReportLatency");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Barometer", "uint Barometer.ReportLatency");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxBatchSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint Barometer.MaxBatchSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20Barometer.MaxBatchSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.BarometerDataThreshold ReportThreshold
		{
			get
			{
				throw new global::System.NotImplementedException("The member BarometerDataThreshold Barometer.ReportThreshold is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BarometerDataThreshold%20Barometer.ReportThreshold");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.BarometerReading GetCurrentReading()
		{
			throw new global::System.NotImplementedException("The member BarometerReading Barometer.GetCurrentReading() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BarometerReading%20Barometer.GetCurrentReading%28%29");
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.Barometer.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.Barometer.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReportInterval.set
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReadingChanged.remove
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReportLatency.set
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReportLatency.get
		// Forced skipping of method Windows.Devices.Sensors.Barometer.MaxBatchSize.get
		// Forced skipping of method Windows.Devices.Sensors.Barometer.ReportThreshold.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.Barometer> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Barometer> Barometer.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CBarometer%3E%20Barometer.FromIdAsync%28string%20deviceId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string Barometer.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20Barometer.GetDeviceSelector%28%29");
		}
		#endif
		#if false || false || false || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Devices.Sensors.Barometer GetDefault()
		{
			throw new global::System.NotImplementedException("The member Barometer Barometer.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Barometer%20Barometer.GetDefault%28%29");
		}
		#endif
		#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.Barometer, global::Windows.Devices.Sensors.BarometerReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Barometer", "event TypedEventHandler<Barometer, BarometerReadingChangedEventArgs> Barometer.ReadingChanged");
			}
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.Barometer", "event TypedEventHandler<Barometer, BarometerReadingChangedEventArgs> Barometer.ReadingChanged");
			}
		}
		#endif
	}
}
