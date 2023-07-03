#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RemoteSystemSessionValueSetReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet Message
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet RemoteSystemSessionValueSetReceivedEventArgs.Message is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20RemoteSystemSessionValueSetReceivedEventArgs.Message");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.RemoteSystems.RemoteSystemSessionParticipant Sender
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionParticipant RemoteSystemSessionValueSetReceivedEventArgs.Sender is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemSessionParticipant%20RemoteSystemSessionValueSetReceivedEventArgs.Sender");
			}
		}
		#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionValueSetReceivedEventArgs.Sender.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionValueSetReceivedEventArgs.Message.get
	}
}
