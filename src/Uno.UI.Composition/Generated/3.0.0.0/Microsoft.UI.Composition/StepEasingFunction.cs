#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class StepEasingFunction : global::Microsoft.UI.Composition.CompositionEasingFunction
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int StepCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int StepEasingFunction.StepCount is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.StepEasingFunction", "int StepEasingFunction.StepCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsInitialStepSingleFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StepEasingFunction.IsInitialStepSingleFrame is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.StepEasingFunction", "bool StepEasingFunction.IsInitialStepSingleFrame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsFinalStepSingleFrame
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StepEasingFunction.IsFinalStepSingleFrame is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.StepEasingFunction", "bool StepEasingFunction.IsFinalStepSingleFrame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int InitialStep
		{
			get
			{
				throw new global::System.NotImplementedException("The member int StepEasingFunction.InitialStep is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.StepEasingFunction", "int StepEasingFunction.InitialStep");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int FinalStep
		{
			get
			{
				throw new global::System.NotImplementedException("The member int StepEasingFunction.FinalStep is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.StepEasingFunction", "int StepEasingFunction.FinalStep");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.StepCount.set
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.IsFinalStepSingleFrame.set
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.IsInitialStepSingleFrame.set
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.StepCount.get
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.IsInitialStepSingleFrame.get
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.InitialStep.get
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.FinalStep.set
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.FinalStep.get
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.InitialStep.set
		// Forced skipping of method Microsoft.UI.Composition.StepEasingFunction.IsFinalStepSingleFrame.get
	}
}
