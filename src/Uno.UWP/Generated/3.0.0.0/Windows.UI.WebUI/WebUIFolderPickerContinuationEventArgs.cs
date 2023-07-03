#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebUIFolderPickerContinuationEventArgs : global::Windows.ApplicationModel.Activation.IFolderPickerContinuationEventArgs,global::Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIFolderPickerContinuationEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20WebUIFolderPickerContinuationEventArgs.Kind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIFolderPickerContinuationEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20WebUIFolderPickerContinuationEventArgs.PreviousExecutionState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIFolderPickerContinuationEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20WebUIFolderPickerContinuationEventArgs.SplashScreen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User WebUIFolderPickerContinuationEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20WebUIFolderPickerContinuationEventArgs.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet ContinuationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet WebUIFolderPickerContinuationEventArgs.ContinuationData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20WebUIFolderPickerContinuationEventArgs.ContinuationData");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.StorageFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder WebUIFolderPickerContinuationEventArgs.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20WebUIFolderPickerContinuationEventArgs.Folder");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIFolderPickerContinuationEventArgs.ActivatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivatedOperation%20WebUIFolderPickerContinuationEventArgs.ActivatedOperation");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.Folder.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.ContinuationData.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.ActivatedOperation.get
		// Forced skipping of method Windows.UI.WebUI.WebUIFolderPickerContinuationEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IFolderPickerContinuationEventArgs
		// Processing: Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
