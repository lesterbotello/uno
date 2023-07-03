#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.UserActivities
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UserActivitySessionHistoryItem 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset? EndTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset? UserActivitySessionHistoryItem.EndTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%3F%20UserActivitySessionHistoryItem.EndTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset StartTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset UserActivitySessionHistoryItem.StartTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20UserActivitySessionHistoryItem.StartTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.UserActivities.UserActivity UserActivity
		{
			get
			{
				throw new global::System.NotImplementedException("The member UserActivity UserActivitySessionHistoryItem.UserActivity is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UserActivity%20UserActivitySessionHistoryItem.UserActivity");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem.UserActivity.get
		// Forced skipping of method Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem.StartTime.get
		// Forced skipping of method Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem.EndTime.get
	}
}
