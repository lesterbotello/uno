#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__NETSTD_REFERENCE__", "__MACOS__")]
	#endif
	public  partial class EllipseGeometry : global::Windows.UI.Xaml.Media.Geometry
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double RadiusY
		{
			get
			{
				return (double)this.GetValue(RadiusYProperty);
			}
			set
			{
				this.SetValue(RadiusYProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double RadiusX
		{
			get
			{
				return (double)this.GetValue(RadiusXProperty);
			}
			set
			{
				this.SetValue(RadiusXProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Point Center
		{
			get
			{
				return (global::Windows.Foundation.Point)this.GetValue(CenterProperty);
			}
			set
			{
				this.SetValue(CenterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CenterProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Center), typeof(global::Windows.Foundation.Point), 
			typeof(global::Windows.UI.Xaml.Media.EllipseGeometry), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.Foundation.Point)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty RadiusXProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(RadiusX), typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.EllipseGeometry), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty RadiusYProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(RadiusY), typeof(double), 
			typeof(global::Windows.UI.Xaml.Media.EllipseGeometry), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__NETSTD_REFERENCE__", "__MACOS__")]
		public EllipseGeometry() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.EllipseGeometry", "EllipseGeometry.EllipseGeometry()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.EllipseGeometry()
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.Center.get
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.Center.set
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.RadiusX.get
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.RadiusX.set
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.RadiusY.get
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.RadiusY.set
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.CenterProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.RadiusXProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.EllipseGeometry.RadiusYProperty.get
	}
}
