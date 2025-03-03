#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DebugSettings 
	{
		// Skipping already declared property IsOverdrawHeatMapEnabled
		// Skipping already declared property IsBindingTracingEnabled
		// Skipping already declared property EnableFrameRateCounter
		// Skipping already declared property EnableRedrawRegions
		// Skipping already declared property IsTextPerformanceVisualizationEnabled
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool FailFastOnErrors
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DebugSettings.FailFastOnErrors is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20DebugSettings.FailFastOnErrors");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.DebugSettings", "bool DebugSettings.FailFastOnErrors");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.EnableFrameRateCounter.get
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.EnableFrameRateCounter.set
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.IsBindingTracingEnabled.get
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.IsBindingTracingEnabled.set
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.IsOverdrawHeatMapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.IsOverdrawHeatMapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.BindingFailed.add
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.BindingFailed.remove
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.EnableRedrawRegions.get
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.EnableRedrawRegions.set
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.IsTextPerformanceVisualizationEnabled.get
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.IsTextPerformanceVisualizationEnabled.set
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.FailFastOnErrors.get
		// Forced skipping of method Windows.UI.Xaml.DebugSettings.FailFastOnErrors.set
		// Skipping already declared event Windows.UI.Xaml.DebugSettings.BindingFailed
	}
}
