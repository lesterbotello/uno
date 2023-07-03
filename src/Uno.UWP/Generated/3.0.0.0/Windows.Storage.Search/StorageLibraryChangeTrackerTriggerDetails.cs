#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StorageLibraryChangeTrackerTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.StorageLibraryChangeTracker ChangeTracker
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageLibraryChangeTracker StorageLibraryChangeTrackerTriggerDetails.ChangeTracker is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageLibraryChangeTracker%20StorageLibraryChangeTrackerTriggerDetails.ChangeTracker");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.StorageFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder StorageLibraryChangeTrackerTriggerDetails.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20StorageLibraryChangeTrackerTriggerDetails.Folder");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.Search.StorageLibraryChangeTrackerTriggerDetails.Folder.get
		// Forced skipping of method Windows.Storage.Search.StorageLibraryChangeTrackerTriggerDetails.ChangeTracker.get
	}
}
