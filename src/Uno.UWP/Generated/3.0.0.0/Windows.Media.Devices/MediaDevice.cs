#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class MediaDevice 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetAudioCaptureSelector()
		{
			throw new global::System.NotImplementedException("The member string MediaDevice.GetAudioCaptureSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MediaDevice.GetAudioCaptureSelector%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetAudioRenderSelector()
		{
			throw new global::System.NotImplementedException("The member string MediaDevice.GetAudioRenderSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MediaDevice.GetAudioRenderSelector%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetVideoCaptureSelector()
		{
			throw new global::System.NotImplementedException("The member string MediaDevice.GetVideoCaptureSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MediaDevice.GetVideoCaptureSelector%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDefaultAudioCaptureId( global::Windows.Media.Devices.AudioDeviceRole role)
		{
			throw new global::System.NotImplementedException("The member string MediaDevice.GetDefaultAudioCaptureId(AudioDeviceRole role) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MediaDevice.GetDefaultAudioCaptureId%28AudioDeviceRole%20role%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDefaultAudioRenderId( global::Windows.Media.Devices.AudioDeviceRole role)
		{
			throw new global::System.NotImplementedException("The member string MediaDevice.GetDefaultAudioRenderId(AudioDeviceRole role) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MediaDevice.GetDefaultAudioRenderId%28AudioDeviceRole%20role%29");
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.MediaDevice.DefaultAudioCaptureDeviceChanged.add
		// Forced skipping of method Windows.Media.Devices.MediaDevice.DefaultAudioCaptureDeviceChanged.remove
		// Forced skipping of method Windows.Media.Devices.MediaDevice.DefaultAudioRenderDeviceChanged.add
		// Forced skipping of method Windows.Media.Devices.MediaDevice.DefaultAudioRenderDeviceChanged.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::Windows.Foundation.TypedEventHandler<object, global::Windows.Media.Devices.DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.MediaDevice", "event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> MediaDevice.DefaultAudioCaptureDeviceChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.MediaDevice", "event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> MediaDevice.DefaultAudioCaptureDeviceChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::Windows.Foundation.TypedEventHandler<object, global::Windows.Media.Devices.DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.MediaDevice", "event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> MediaDevice.DefaultAudioRenderDeviceChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.MediaDevice", "event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> MediaDevice.DefaultAudioRenderDeviceChanged");
			}
		}
		#endif
	}
}
