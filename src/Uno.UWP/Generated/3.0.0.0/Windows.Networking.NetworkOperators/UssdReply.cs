#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UssdReply 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.UssdMessage Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member UssdMessage UssdReply.Message is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UssdMessage%20UssdReply.Message");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.NetworkOperators.UssdResultCode ResultCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member UssdResultCode UssdReply.ResultCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UssdResultCode%20UssdReply.ResultCode");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.UssdReply.ResultCode.get
		// Forced skipping of method Windows.Networking.NetworkOperators.UssdReply.Message.get
	}
}
