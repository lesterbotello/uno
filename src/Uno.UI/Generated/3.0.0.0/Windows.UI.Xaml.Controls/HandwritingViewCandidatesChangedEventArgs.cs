#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HandwritingViewCandidatesChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint CandidatesSessionId
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint HandwritingViewCandidatesChangedEventArgs.CandidatesSessionId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20HandwritingViewCandidatesChangedEventArgs.CandidatesSessionId");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.HandwritingViewCandidatesChangedEventArgs.CandidatesSessionId.get
	}
}
