#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class AnimationController : global::Microsoft.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.AnimationControllerProgressBehavior ProgressBehavior
		{
			get
			{
				throw new global::System.NotImplementedException("The member AnimationControllerProgressBehavior AnimationController.ProgressBehavior is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AnimationController", "AnimationControllerProgressBehavior AnimationController.ProgressBehavior");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Progress
		{
			get
			{
				throw new global::System.NotImplementedException("The member float AnimationController.Progress is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AnimationController", "float AnimationController.Progress");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float PlaybackRate
		{
			get
			{
				throw new global::System.NotImplementedException("The member float AnimationController.PlaybackRate is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AnimationController", "float AnimationController.PlaybackRate");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static float MaxPlaybackRate
		{
			get
			{
				throw new global::System.NotImplementedException("The member float AnimationController.MaxPlaybackRate is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static float MinPlaybackRate
		{
			get
			{
				throw new global::System.NotImplementedException("The member float AnimationController.MinPlaybackRate is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.PlaybackRate.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Pause()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AnimationController", "void AnimationController.Pause()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Resume()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.AnimationController", "void AnimationController.Resume()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.ProgressBehavior.set
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.Progress.get
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.PlaybackRate.set
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.Progress.set
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.ProgressBehavior.get
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.MaxPlaybackRate.get
		// Forced skipping of method Microsoft.UI.Composition.AnimationController.MinPlaybackRate.get
	}
}
