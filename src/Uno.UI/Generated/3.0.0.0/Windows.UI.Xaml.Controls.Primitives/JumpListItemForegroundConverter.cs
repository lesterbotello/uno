#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class JumpListItemForegroundConverter : global::Windows.UI.Xaml.DependencyObject,global::Windows.UI.Xaml.Data.IValueConverter
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Brush Enabled
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(EnabledProperty);
			}
			set
			{
				this.SetValue(EnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Brush Disabled
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(DisabledProperty);
			}
			set
			{
				this.SetValue(DisabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DisabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Disabled), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty EnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Enabled), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public JumpListItemForegroundConverter() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter", "JumpListItemForegroundConverter.JumpListItemForegroundConverter()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.JumpListItemForegroundConverter()
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.Enabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.Enabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.Disabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.Disabled.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Convert( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object JumpListItemForegroundConverter.Convert(object value, Type targetType, object parameter, string language) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20JumpListItemForegroundConverter.Convert%28object%20value%2C%20Type%20targetType%2C%20object%20parameter%2C%20string%20language%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object ConvertBack( object value,  global::System.Type targetType,  object parameter,  string language)
		{
			throw new global::System.NotImplementedException("The member object JumpListItemForegroundConverter.ConvertBack(object value, Type targetType, object parameter, string language) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20JumpListItemForegroundConverter.ConvertBack%28object%20value%2C%20Type%20targetType%2C%20object%20parameter%2C%20string%20language%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.EnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Primitives.JumpListItemForegroundConverter.DisabledProperty.get
		// Processing: Windows.UI.Xaml.Data.IValueConverter
	}
}
