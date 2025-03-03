#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TeachingTip : global::Windows.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Title
		{
			get
			{
				return (string)this.GetValue(TitleProperty);
			}
			set
			{
				this.SetValue(TitleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.FrameworkElement Target
		{
			get
			{
				return (global::Windows.UI.Xaml.FrameworkElement)this.GetValue(TargetProperty);
			}
			set
			{
				this.SetValue(TargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.TeachingTipTailVisibility TailVisibility
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TeachingTipTailVisibility)this.GetValue(TailVisibilityProperty);
			}
			set
			{
				this.SetValue(TailVisibilityProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Subtitle
		{
			get
			{
				return (string)this.GetValue(SubtitleProperty);
			}
			set
			{
				this.SetValue(SubtitleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ShouldConstrainToRootBounds
		{
			get
			{
				return (bool)this.GetValue(ShouldConstrainToRootBoundsProperty);
			}
			set
			{
				this.SetValue(ShouldConstrainToRootBoundsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.TeachingTipPlacementMode PreferredPlacement
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TeachingTipPlacementMode)this.GetValue(PreferredPlacementProperty);
			}
			set
			{
				this.SetValue(PreferredPlacementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Thickness PlacementMargin
		{
			get
			{
				return (global::Windows.UI.Xaml.Thickness)this.GetValue(PlacementMarginProperty);
			}
			set
			{
				this.SetValue(PlacementMarginProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsOpen
		{
			get
			{
				return (bool)this.GetValue(IsOpenProperty);
			}
			set
			{
				this.SetValue(IsOpenProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsLightDismissEnabled
		{
			get
			{
				return (bool)this.GetValue(IsLightDismissEnabledProperty);
			}
			set
			{
				this.SetValue(IsLightDismissEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.IconSource IconSource
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.IconSource)this.GetValue(IconSourceProperty);
			}
			set
			{
				this.SetValue(IconSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.TeachingTipHeroContentPlacementMode HeroContentPlacement
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TeachingTipHeroContentPlacementMode)this.GetValue(HeroContentPlacementProperty);
			}
			set
			{
				this.SetValue(HeroContentPlacementProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.UIElement HeroContent
		{
			get
			{
				return (global::Windows.UI.Xaml.UIElement)this.GetValue(HeroContentProperty);
			}
			set
			{
				this.SetValue(HeroContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Style CloseButtonStyle
		{
			get
			{
				return (global::Windows.UI.Xaml.Style)this.GetValue(CloseButtonStyleProperty);
			}
			set
			{
				this.SetValue(CloseButtonStyleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object CloseButtonContent
		{
			get
			{
				return (object)this.GetValue(CloseButtonContentProperty);
			}
			set
			{
				this.SetValue(CloseButtonContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object CloseButtonCommandParameter
		{
			get
			{
				return (object)this.GetValue(CloseButtonCommandParameterProperty);
			}
			set
			{
				this.SetValue(CloseButtonCommandParameterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Windows.Input.ICommand CloseButtonCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)this.GetValue(CloseButtonCommandProperty);
			}
			set
			{
				this.SetValue(CloseButtonCommandProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Style ActionButtonStyle
		{
			get
			{
				return (global::Windows.UI.Xaml.Style)this.GetValue(ActionButtonStyleProperty);
			}
			set
			{
				this.SetValue(ActionButtonStyleProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object ActionButtonContent
		{
			get
			{
				return (object)this.GetValue(ActionButtonContentProperty);
			}
			set
			{
				this.SetValue(ActionButtonContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object ActionButtonCommandParameter
		{
			get
			{
				return (object)this.GetValue(ActionButtonCommandParameterProperty);
			}
			set
			{
				this.SetValue(ActionButtonCommandParameterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Windows.Input.ICommand ActionButtonCommand
		{
			get
			{
				return (global::System.Windows.Input.ICommand)this.GetValue(ActionButtonCommandProperty);
			}
			set
			{
				this.SetValue(ActionButtonCommandProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings TemplateSettings
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings)this.GetValue(TemplateSettingsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ActionButtonCommandParameterProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ActionButtonCommandParameter), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ActionButtonCommandProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ActionButtonCommand), typeof(global::System.Windows.Input.ICommand), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Windows.Input.ICommand)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ActionButtonContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ActionButtonContent), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ActionButtonStyleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ActionButtonStyle), typeof(global::Windows.UI.Xaml.Style), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Style)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CloseButtonCommandParameterProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CloseButtonCommandParameter), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CloseButtonCommandProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CloseButtonCommand), typeof(global::System.Windows.Input.ICommand), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Windows.Input.ICommand)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CloseButtonContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CloseButtonContent), typeof(object), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CloseButtonStyleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CloseButtonStyle), typeof(global::Windows.UI.Xaml.Style), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Style)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty HeroContentPlacementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(HeroContentPlacement), typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipHeroContentPlacementMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TeachingTipHeroContentPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty HeroContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(HeroContent), typeof(global::Windows.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IconSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IconSource), typeof(global::Microsoft.UI.Xaml.Controls.IconSource), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.IconSource)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsLightDismissEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsLightDismissEnabled), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsOpenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsOpen), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PlacementMarginProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PlacementMargin), typeof(global::Windows.UI.Xaml.Thickness), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Thickness)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PreferredPlacementProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PreferredPlacement), typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipPlacementMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TeachingTipPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ShouldConstrainToRootBoundsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ShouldConstrainToRootBounds), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty SubtitleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Subtitle), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TailVisibilityProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(TailVisibility), typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipTailVisibility), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TeachingTipTailVisibility)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Target), typeof(global::Windows.UI.Xaml.FrameworkElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.FrameworkElement)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TemplateSettingsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(TemplateSettings), typeof(global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.TeachingTipTemplateSettings)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TitleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Title), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.TeachingTip), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public TeachingTip() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "TeachingTip.TeachingTip()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TeachingTip()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Title.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Title.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Subtitle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Subtitle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IsOpen.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IsOpen.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Target.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Target.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TailVisibility.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TailVisibility.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonContent.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonCommand.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonCommand.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonCommandParameter.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonCommandParameter.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonContent.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonStyle.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonStyle.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonCommand.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonCommand.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonCommandParameter.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonCommandParameter.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.PlacementMargin.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.PlacementMargin.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ShouldConstrainToRootBounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ShouldConstrainToRootBounds.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IsLightDismissEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IsLightDismissEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.PreferredPlacement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.PreferredPlacement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.HeroContentPlacement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.HeroContentPlacement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.HeroContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.HeroContent.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IconSource.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IconSource.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TemplateSettings.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonClick.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonClick.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonClick.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonClick.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Closing.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Closing.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Closed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.Closed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IsOpenProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TargetProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TailVisibilityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TitleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.SubtitleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonStyleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonCommandProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ActionButtonCommandParameterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonStyleProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonCommandProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.CloseButtonCommandParameterProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.PlacementMarginProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.ShouldConstrainToRootBoundsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IsLightDismissEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.PreferredPlacementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.HeroContentPlacementProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.HeroContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.IconSourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTip.TemplateSettingsProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TeachingTip, object> ActionButtonClick
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, object> TeachingTip.ActionButtonClick");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, object> TeachingTip.ActionButtonClick");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TeachingTip, object> CloseButtonClick
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, object> TeachingTip.CloseButtonClick");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, object> TeachingTip.CloseButtonClick");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TeachingTip, global::Microsoft.UI.Xaml.Controls.TeachingTipClosedEventArgs> Closed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, TeachingTipClosedEventArgs> TeachingTip.Closed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, TeachingTipClosedEventArgs> TeachingTip.Closed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.TeachingTip, global::Microsoft.UI.Xaml.Controls.TeachingTipClosingEventArgs> Closing
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, TeachingTipClosingEventArgs> TeachingTip.Closing");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTip", "event TypedEventHandler<TeachingTip, TeachingTipClosingEventArgs> TeachingTip.Closing");
			}
		}
		#endif
	}
}
