#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NetworkUsage 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong BytesReceived
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong NetworkUsage.BytesReceived is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20NetworkUsage.BytesReceived");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong BytesSent
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong NetworkUsage.BytesSent is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20NetworkUsage.BytesSent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan ConnectionDuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan NetworkUsage.ConnectionDuration is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20NetworkUsage.ConnectionDuration");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsage.BytesSent.get
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsage.BytesReceived.get
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsage.ConnectionDuration.get
	}
}
