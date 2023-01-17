#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class DisplayAreaWatcher 
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Windowing.DisplayAreaWatcherStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayAreaWatcherStatus DisplayAreaWatcher.Status is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Added.add
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Start()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "void DisplayAreaWatcher.Start()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Stop()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "void DisplayAreaWatcher.Stop()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Status.get
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Added.remove
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.EnumerationCompleted.add
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.EnumerationCompleted.remove
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Removed.add
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Removed.remove
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Stopped.add
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Stopped.remove
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Updated.add
		// Forced skipping of method Microsoft.UI.Windowing.DisplayAreaWatcher.Updated.remove
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.DisplayAreaWatcher, global::Microsoft.UI.Windowing.DisplayArea> Added
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, DisplayArea> DisplayAreaWatcher.Added");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, DisplayArea> DisplayAreaWatcher.Added");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.DisplayAreaWatcher, object> EnumerationCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, object> DisplayAreaWatcher.EnumerationCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, object> DisplayAreaWatcher.EnumerationCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.DisplayAreaWatcher, global::Microsoft.UI.Windowing.DisplayArea> Removed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, DisplayArea> DisplayAreaWatcher.Removed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, DisplayArea> DisplayAreaWatcher.Removed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.DisplayAreaWatcher, object> Stopped
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, object> DisplayAreaWatcher.Stopped");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, object> DisplayAreaWatcher.Stopped");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Windowing.DisplayAreaWatcher, global::Microsoft.UI.Windowing.DisplayArea> Updated
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, DisplayArea> DisplayAreaWatcher.Updated");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.DisplayAreaWatcher", "event TypedEventHandler<DisplayAreaWatcher, DisplayArea> DisplayAreaWatcher.Updated");
			}
		}
		#endif
	}
}
