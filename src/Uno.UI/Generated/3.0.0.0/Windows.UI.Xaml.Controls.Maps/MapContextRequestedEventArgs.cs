#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapContextRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member Geopoint MapContextRequestedEventArgs.Location is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Geopoint%20MapContextRequestedEventArgs.Location");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Xaml.Controls.Maps.MapElement> MapElements
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<MapElement> MapContextRequestedEventArgs.MapElements is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CMapElement%3E%20MapContextRequestedEventArgs.MapElements");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Point Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member Point MapContextRequestedEventArgs.Position is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Point%20MapContextRequestedEventArgs.Position");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapContextRequestedEventArgs() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs", "MapContextRequestedEventArgs.MapContextRequestedEventArgs()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs.MapContextRequestedEventArgs()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs.Position.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs.Location.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapContextRequestedEventArgs.MapElements.get
	}
}
