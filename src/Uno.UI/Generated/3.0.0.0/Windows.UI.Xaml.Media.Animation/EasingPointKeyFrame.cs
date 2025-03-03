#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EasingPointKeyFrame : global::Windows.UI.Xaml.Media.Animation.PointKeyFrame
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Animation.EasingFunctionBase)this.GetValue(EasingFunctionProperty);
			}
			set
			{
				this.SetValue(EasingFunctionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty EasingFunctionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(EasingFunction), typeof(global::Windows.UI.Xaml.Media.Animation.EasingFunctionBase), 
			typeof(global::Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Animation.EasingFunctionBase)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public EasingPointKeyFrame() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame", "EasingPointKeyFrame.EasingPointKeyFrame()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingPointKeyFrame()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingFunction.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingFunction.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame.EasingFunctionProperty.get
	}
}
