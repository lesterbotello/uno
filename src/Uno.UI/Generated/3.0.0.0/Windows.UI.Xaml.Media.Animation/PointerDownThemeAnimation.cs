#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PointerDownThemeAnimation : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string TargetName
		{
			get
			{
				return (string)this.GetValue(TargetNameProperty);
			}
			set
			{
				this.SetValue(TargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(TargetName), typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PointerDownThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation", "PointerDownThemeAnimation.PointerDownThemeAnimation()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation.PointerDownThemeAnimation()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation.TargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation.TargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.PointerDownThemeAnimation.TargetNameProperty.get
	}
}
