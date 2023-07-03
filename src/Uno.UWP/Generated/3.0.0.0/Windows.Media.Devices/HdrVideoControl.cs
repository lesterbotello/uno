#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HdrVideoControl 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Devices.HdrVideoMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member HdrVideoMode HdrVideoControl.Mode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HdrVideoMode%20HdrVideoControl.Mode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Devices.HdrVideoControl", "HdrVideoMode HdrVideoControl.Mode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Supported
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool HdrVideoControl.Supported is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HdrVideoControl.Supported");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Devices.HdrVideoMode> SupportedModes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<HdrVideoMode> HdrVideoControl.SupportedModes is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CHdrVideoMode%3E%20HdrVideoControl.SupportedModes");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Devices.HdrVideoControl.Supported.get
		// Forced skipping of method Windows.Media.Devices.HdrVideoControl.SupportedModes.get
		// Forced skipping of method Windows.Media.Devices.HdrVideoControl.Mode.get
		// Forced skipping of method Windows.Media.Devices.HdrVideoControl.Mode.set
	}
}
