#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioNodeEmitterNaturalDecayModelProperties 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double CutoffDistance
		{
			get
			{
				throw new global::System.NotImplementedException("The member double AudioNodeEmitterNaturalDecayModelProperties.CutoffDistance is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20AudioNodeEmitterNaturalDecayModelProperties.CutoffDistance");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double UnityGainDistance
		{
			get
			{
				throw new global::System.NotImplementedException("The member double AudioNodeEmitterNaturalDecayModelProperties.UnityGainDistance is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20AudioNodeEmitterNaturalDecayModelProperties.UnityGainDistance");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.AudioNodeEmitterNaturalDecayModelProperties.UnityGainDistance.get
		// Forced skipping of method Windows.Media.Audio.AudioNodeEmitterNaturalDecayModelProperties.CutoffDistance.get
	}
}
