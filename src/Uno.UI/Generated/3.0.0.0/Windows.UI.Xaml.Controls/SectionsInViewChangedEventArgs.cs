#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SectionsInViewChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> AddedSections
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<HubSection> SectionsInViewChangedEventArgs.AddedSections is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CHubSection%3E%20SectionsInViewChangedEventArgs.AddedSections");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> RemovedSections
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<HubSection> SectionsInViewChangedEventArgs.RemovedSections is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CHubSection%3E%20SectionsInViewChangedEventArgs.RemovedSections");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs.AddedSections.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs.RemovedSections.get
	}
}
