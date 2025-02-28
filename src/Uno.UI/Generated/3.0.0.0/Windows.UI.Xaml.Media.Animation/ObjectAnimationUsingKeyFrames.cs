#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ObjectAnimationUsingKeyFrames : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool EnableDependentAnimation
		{
			get
			{
				return (bool)this.GetValue(EnableDependentAnimationProperty);
			}
			set
			{
				this.SetValue(EnableDependentAnimationProperty, value);
			}
		}
		#endif
		// Skipping already declared property KeyFrames
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty EnableDependentAnimationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(EnableDependentAnimation), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.ObjectAnimationUsingKeyFrames()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.ObjectAnimationUsingKeyFrames()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.KeyFrames.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.EnableDependentAnimation.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.EnableDependentAnimation.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.ObjectAnimationUsingKeyFrames.EnableDependentAnimationProperty.get
	}
}
