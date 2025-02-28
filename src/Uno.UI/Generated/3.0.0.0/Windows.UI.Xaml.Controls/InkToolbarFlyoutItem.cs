#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarFlyoutItem : global::Windows.UI.Xaml.Controls.Primitives.ButtonBase
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItemKind Kind
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItemKind)this.GetValue(KindProperty);
			}
			set
			{
				this.SetValue(KindProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsChecked
		{
			get
			{
				return (bool)this.GetValue(IsCheckedProperty);
			}
			set
			{
				this.SetValue(IsCheckedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsCheckedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsChecked), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KindProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Kind), typeof(global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItemKind), 
			typeof(global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItemKind)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InkToolbarFlyoutItem() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarFlyoutItem", "InkToolbarFlyoutItem.InkToolbarFlyoutItem()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.InkToolbarFlyoutItem()
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.Kind.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.Kind.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.IsChecked.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.IsChecked.set
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.Checked.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.Checked.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.Unchecked.add
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.Unchecked.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.KindProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarFlyoutItem.IsCheckedProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItem, object> Checked
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarFlyoutItem", "event TypedEventHandler<InkToolbarFlyoutItem, object> InkToolbarFlyoutItem.Checked");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarFlyoutItem", "event TypedEventHandler<InkToolbarFlyoutItem, object> InkToolbarFlyoutItem.Checked");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.InkToolbarFlyoutItem, object> Unchecked
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarFlyoutItem", "event TypedEventHandler<InkToolbarFlyoutItem, object> InkToolbarFlyoutItem.Unchecked");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.InkToolbarFlyoutItem", "event TypedEventHandler<InkToolbarFlyoutItem, object> InkToolbarFlyoutItem.Unchecked");
			}
		}
		#endif
	}
}
