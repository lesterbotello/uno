#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapLayer : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZIndex
		{
			get
			{
				return (int)this.GetValue(ZIndexProperty);
			}
			set
			{
				this.SetValue(ZIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Visible
		{
			get
			{
				return (bool)this.GetValue(VisibleProperty);
			}
			set
			{
				this.SetValue(VisibleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MapTabIndex
		{
			get
			{
				return (int)this.GetValue(MapTabIndexProperty);
			}
			set
			{
				this.SetValue(MapTabIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MapTabIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MapTabIndex), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapLayer), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty VisibleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Visible), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapLayer), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ZIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ZIndex), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapLayer), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapLayer() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapLayer", "MapLayer.MapLayer()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.MapLayer()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.MapTabIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.MapTabIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.Visible.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.Visible.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.ZIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.ZIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.MapTabIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.VisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapLayer.ZIndexProperty.get
	}
}
