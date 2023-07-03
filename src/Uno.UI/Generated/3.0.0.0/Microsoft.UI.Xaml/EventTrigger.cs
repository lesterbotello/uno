#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	[global::Microsoft.UI.Xaml.Markup.ContentPropertyAttribute(Name = "Actions")]
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EventTrigger : global::Microsoft.UI.Xaml.TriggerBase
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.RoutedEvent RoutedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent EventTrigger.RoutedEvent is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RoutedEvent%20EventTrigger.RoutedEvent");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.EventTrigger", "RoutedEvent EventTrigger.RoutedEvent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.TriggerActionCollection Actions
		{
			get
			{
				throw new global::System.NotImplementedException("The member TriggerActionCollection EventTrigger.Actions is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TriggerActionCollection%20EventTrigger.Actions");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public EventTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.EventTrigger", "EventTrigger.EventTrigger()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.EventTrigger.EventTrigger()
		// Forced skipping of method Microsoft.UI.Xaml.EventTrigger.RoutedEvent.get
		// Forced skipping of method Microsoft.UI.Xaml.EventTrigger.RoutedEvent.set
		// Forced skipping of method Microsoft.UI.Xaml.EventTrigger.Actions.get
	}
}
