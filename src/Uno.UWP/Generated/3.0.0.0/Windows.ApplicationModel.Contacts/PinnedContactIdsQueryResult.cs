#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PinnedContactIdsQueryResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> ContactIds
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> PinnedContactIdsQueryResult.ContactIds is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3Cstring%3E%20PinnedContactIdsQueryResult.ContactIds");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.PinnedContactIdsQueryResult.ContactIds.get
	}
}
