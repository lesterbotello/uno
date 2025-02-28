#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Control : global::Windows.UI.Xaml.FrameworkElement
	{
		// Skipping already declared property Padding
		// Skipping already declared property IsTabStop
		// Skipping already declared property IsEnabled
		// Skipping already declared property HorizontalContentAlignment
		// Skipping already declared property Foreground
		// Skipping already declared property FontWeight
		// Skipping already declared property FontStyle
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Text.FontStretch FontStretch
		{
			get
			{
				return (global::Windows.UI.Text.FontStretch)this.GetValue(FontStretchProperty);
			}
			set
			{
				this.SetValue(FontStretchProperty, value);
			}
		}
		#endif
		// Skipping already declared property FontSize
		// Skipping already declared property FontFamily
		// Skipping already declared property TabIndex
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CharacterSpacing
		{
			get
			{
				return (int)this.GetValue(CharacterSpacingProperty);
			}
			set
			{
				this.SetValue(CharacterSpacingProperty, value);
			}
		}
		#endif
		// Skipping already declared property BorderThickness
		// Skipping already declared property BorderBrush
		// Skipping already declared property TabNavigation
		// Skipping already declared property Background
		// Skipping already declared property VerticalContentAlignment
		// Skipping already declared property Template
		// Skipping already declared property FocusState
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsTextScaleFactorEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTextScaleFactorEnabledProperty);
			}
			set
			{
				this.SetValue(IsTextScaleFactorEnabledProperty, value);
			}
		}
		#endif
		// Skipping already declared property UseSystemFocusVisuals
		// Skipping already declared property XYFocusUp
		// Skipping already declared property XYFocusRight
		// Skipping already declared property XYFocusLeft
		// Skipping already declared property XYFocusDown
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.RequiresPointer RequiresPointer
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.RequiresPointer)this.GetValue(RequiresPointerProperty);
			}
			set
			{
				this.SetValue(RequiresPointerProperty, value);
			}
		}
		#endif
		// Skipping already declared property IsFocusEngagementEnabled
		// Skipping already declared property IsFocusEngaged
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.ElementSoundMode ElementSoundMode
		{
			get
			{
				return (global::Windows.UI.Xaml.ElementSoundMode)this.GetValue(ElementSoundModeProperty);
			}
			set
			{
				this.SetValue(ElementSoundModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri DefaultStyleResourceUri
		{
			get
			{
				return (global::System.Uri)this.GetValue(DefaultStyleResourceUriProperty);
			}
			set
			{
				this.SetValue(DefaultStyleResourceUriProperty, value);
			}
		}
		#endif
		// Skipping already declared property CornerRadius
		// Skipping already declared property BackgroundSizing
		// Skipping already declared property DefaultStyleKey
		// Skipping already declared property BorderThicknessProperty
		// Skipping already declared property FocusStateProperty
		// Skipping already declared property FontFamilyProperty
		// Skipping already declared property FontSizeProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty FontStretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(FontStretch), typeof(global::Windows.UI.Text.FontStretch), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Text.FontStretch)));
		#endif
		// Skipping already declared property FontStyleProperty
		// Skipping already declared property FontWeightProperty
		// Skipping already declared property ForegroundProperty
		// Skipping already declared property HorizontalContentAlignmentProperty
		// Skipping already declared property IsEnabledProperty
		// Skipping already declared property IsTabStopProperty
		// Skipping already declared property PaddingProperty
		// Skipping already declared property TabIndexProperty
		// Skipping already declared property TabNavigationProperty
		// Skipping already declared property TemplateProperty
		// Skipping already declared property BackgroundProperty
		// Skipping already declared property BorderBrushProperty
		// Skipping already declared property VerticalContentAlignmentProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CharacterSpacingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CharacterSpacing), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DefaultStyleKeyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(DefaultStyleKey), typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsTextScaleFactorEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsTextScaleFactorEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property IsTemplateFocusTargetProperty
		// Skipping already declared property UseSystemFocusVisualsProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ElementSoundModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ElementSoundMode), typeof(global::Windows.UI.Xaml.ElementSoundMode), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.ElementSoundMode)));
		#endif
		// Skipping already declared property IsFocusEngagedProperty
		// Skipping already declared property IsFocusEngagementEnabledProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty RequiresPointerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(RequiresPointer), typeof(global::Windows.UI.Xaml.Controls.RequiresPointer), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.RequiresPointer)));
		#endif
		// Skipping already declared property XYFocusDownProperty
		// Skipping already declared property XYFocusLeftProperty
		// Skipping already declared property XYFocusRightProperty
		// Skipping already declared property XYFocusUpProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DefaultStyleResourceUriProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(DefaultStyleResourceUri), typeof(global::System.Uri), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsTemplateKeyTipTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"IsTemplateKeyTipTarget", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Control), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property CornerRadiusProperty
		// Skipping already declared property BackgroundSizingProperty
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.Control()
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Control()
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontSize.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontSize.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontFamily.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontFamily.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontWeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontWeight.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontStyle.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontStyle.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontStretch.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontStretch.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.CharacterSpacing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.CharacterSpacing.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Foreground.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Foreground.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTabStop.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTabStop.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TabIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TabIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TabNavigation.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TabNavigation.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Template.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Template.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Padding.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Padding.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.HorizontalContentAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.HorizontalContentAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.VerticalContentAlignment.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.VerticalContentAlignment.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Background.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.Background.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BorderThickness.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BorderThickness.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BorderBrush.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BorderBrush.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FocusState.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsEnabledChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsEnabledChanged.remove
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.ApplyTemplate()
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.Focus(Windows.UI.Xaml.FocusState)
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTextScaleFactorEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTextScaleFactorEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.UseSystemFocusVisuals.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.UseSystemFocusVisuals.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsFocusEngagementEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsFocusEngagementEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsFocusEngaged.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsFocusEngaged.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.RequiresPointer.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.RequiresPointer.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusLeft.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusLeft.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusRight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusRight.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusUp.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusUp.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusDown.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusDown.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.ElementSoundMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.ElementSoundMode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FocusEngaged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FocusEngaged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FocusDisengaged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FocusDisengaged.remove
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.RemoveFocusEngagement()
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.DefaultStyleResourceUri.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.DefaultStyleResourceUri.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BackgroundSizing.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BackgroundSizing.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.CornerRadius.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.CornerRadius.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.DefaultStyleKey.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.DefaultStyleKey.set
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.GetTemplateChild(string)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerEntered(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerPressed(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerMoved(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerReleased(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerExited(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerCaptureLost(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerCanceled(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnPointerWheelChanged(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnTapped(Windows.UI.Xaml.Input.TappedRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnDoubleTapped(Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnHolding(Windows.UI.Xaml.Input.HoldingRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnRightTapped(Windows.UI.Xaml.Input.RightTappedRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnManipulationStarting(Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnManipulationInertiaStarting(Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnManipulationStarted(Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnManipulationDelta(Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnManipulationCompleted(Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnKeyUp(Windows.UI.Xaml.Input.KeyRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnKeyDown(Windows.UI.Xaml.Input.KeyRoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnGotFocus(Windows.UI.Xaml.RoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnLostFocus(Windows.UI.Xaml.RoutedEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnDragEnter(Windows.UI.Xaml.DragEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnDragLeave(Windows.UI.Xaml.DragEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnDragOver(Windows.UI.Xaml.DragEventArgs)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.OnDrop(Windows.UI.Xaml.DragEventArgs)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnPreviewKeyDown( global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Control", "void Control.OnPreviewKeyDown(KeyRoutedEventArgs e)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnPreviewKeyUp( global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Control", "void Control.OnPreviewKeyUp(KeyRoutedEventArgs e)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnCharacterReceived( global::Windows.UI.Xaml.Input.CharacterReceivedRoutedEventArgs e)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Control", "void Control.OnCharacterReceived(CharacterReceivedRoutedEventArgs e)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BackgroundSizingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.CornerRadiusProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.DefaultStyleResourceUriProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTemplateKeyTipTargetProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetIsTemplateKeyTipTarget( global::Windows.UI.Xaml.DependencyObject element)
		{
			return (bool)element.GetValue(IsTemplateKeyTipTargetProperty);
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetIsTemplateKeyTipTarget( global::Windows.UI.Xaml.DependencyObject element,  bool value)
		{
			element.SetValue(IsTemplateKeyTipTargetProperty, value);
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsFocusEngagementEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsFocusEngagedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.RequiresPointerProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusLeftProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusRightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusUpProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.XYFocusDownProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.ElementSoundModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.UseSystemFocusVisualsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTemplateFocusTargetProperty.get
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.GetIsTemplateFocusTarget(Windows.UI.Xaml.FrameworkElement)
		// Skipping already declared method Windows.UI.Xaml.Controls.Control.SetIsTemplateFocusTarget(Windows.UI.Xaml.FrameworkElement, bool)
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTextScaleFactorEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontSizeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontFamilyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontWeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontStyleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FontStretchProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.CharacterSpacingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.ForegroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsTabStopProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.IsEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TabIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TabNavigationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.TemplateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.PaddingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.HorizontalContentAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.VerticalContentAlignmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BackgroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BorderThicknessProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.BorderBrushProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.DefaultStyleKeyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Control.FocusStateProperty.get
		// Skipping already declared event Windows.UI.Xaml.Controls.Control.IsEnabledChanged
		// Skipping already declared event Windows.UI.Xaml.Controls.Control.FocusDisengaged
		// Skipping already declared event Windows.UI.Xaml.Controls.Control.FocusEngaged
	}
}
