#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TeachingTipClosingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TeachingTipClosingEventArgs.Cancel is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20TeachingTipClosingEventArgs.Cancel");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.TeachingTipClosingEventArgs", "bool TeachingTipClosingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.TeachingTipCloseReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member TeachingTipCloseReason TeachingTipClosingEventArgs.Reason is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TeachingTipCloseReason%20TeachingTipClosingEventArgs.Reason");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipClosingEventArgs.Reason.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipClosingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TeachingTipClosingEventArgs.Cancel.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral TeachingTipClosingEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Deferral%20TeachingTipClosingEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
