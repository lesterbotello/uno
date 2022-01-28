#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Pickers
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class FileSavePicker 
	{
		// Skipping already declared property SuggestedStartLocation
		// Skipping already declared property SuggestedSaveFile
		// Skipping already declared property SuggestedFileName
		// Skipping already declared property SettingsIdentifier
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DefaultFileExtension
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileSavePicker.DefaultFileExtension is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Pickers.FileSavePicker", "string FileSavePicker.DefaultFileExtension");
			}
		}
		#endif
		// Skipping already declared property CommitButtonText
		// Skipping already declared property FileTypeChoices
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet ContinuationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet FileSavePicker.ContinuationData is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string EnterpriseId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string FileSavePicker.EnterpriseId is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Pickers.FileSavePicker", "string FileSavePicker.EnterpriseId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User FileSavePicker.User is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Windows.Storage.Pickers.FileSavePicker.FileSavePicker()
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.FileSavePicker()
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.ContinuationData.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void PickSaveFileAndContinue()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Pickers.FileSavePicker", "void FileSavePicker.PickSaveFileAndContinue()");
		}
		#endif
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.EnterpriseId.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.EnterpriseId.set
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SettingsIdentifier.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SettingsIdentifier.set
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SuggestedStartLocation.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SuggestedStartLocation.set
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.CommitButtonText.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.CommitButtonText.set
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.FileTypeChoices.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.DefaultFileExtension.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.DefaultFileExtension.set
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SuggestedSaveFile.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SuggestedSaveFile.set
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SuggestedFileName.get
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.SuggestedFileName.set
		#if false || false || NET461 || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("NET461", "__NETSTD_REFERENCE__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.StorageFile> PickSaveFileAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorageFile> FileSavePicker.PickSaveFileAsync() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Storage.Pickers.FileSavePicker.User.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Storage.Pickers.FileSavePicker CreateForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member FileSavePicker FileSavePicker.CreateForUser(User user) is not implemented in Uno.");
		}
		#endif
	}
}
