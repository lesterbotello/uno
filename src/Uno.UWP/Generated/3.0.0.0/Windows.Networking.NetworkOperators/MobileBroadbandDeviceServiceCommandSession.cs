#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandDeviceServiceCommandSession 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult> SendQueryCommandAsync( uint commandId,  global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> MobileBroadbandDeviceServiceCommandSession.SendQueryCommandAsync(uint commandId, IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CMobileBroadbandDeviceServiceCommandResult%3E%20MobileBroadbandDeviceServiceCommandSession.SendQueryCommandAsync%28uint%20commandId%2C%20IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult> SendSetCommandAsync( uint commandId,  global::Windows.Storage.Streams.IBuffer data)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<MobileBroadbandDeviceServiceCommandResult> MobileBroadbandDeviceServiceCommandSession.SendSetCommandAsync(uint commandId, IBuffer data) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CMobileBroadbandDeviceServiceCommandResult%3E%20MobileBroadbandDeviceServiceCommandSession.SendSetCommandAsync%28uint%20commandId%2C%20IBuffer%20data%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void CloseSession()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession", "void MobileBroadbandDeviceServiceCommandSession.CloseSession()");
		}
		#endif
	}
}
