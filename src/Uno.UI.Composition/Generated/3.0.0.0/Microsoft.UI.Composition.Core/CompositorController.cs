#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompositorController : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.Compositor Compositor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Compositor CompositorController.Compositor is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Core.CompositorController.CommitNeeded.remove
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Core.CompositorController", "void CompositorController.Dispose()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Commit()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Core.CompositorController", "void CompositorController.Commit()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction EnsurePreviousCommitCompletedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction CompositorController.EnsurePreviousCommitCompletedAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Core.CompositorController.CommitNeeded.add
		// Forced skipping of method Microsoft.UI.Composition.Core.CompositorController.Compositor.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__")]
		public CompositorController() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Core.CompositorController", "CompositorController.CompositorController()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Core.CompositorController.CompositorController()
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Composition.Core.CompositorController, object> CommitNeeded
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Core.CompositorController", "event TypedEventHandler<CompositorController, object> CompositorController.CommitNeeded");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.Core.CompositorController", "event TypedEventHandler<CompositorController, object> CompositorController.CommitNeeded");
			}
		}
		#endif
		// Processing: System.IDisposable
	}
}
