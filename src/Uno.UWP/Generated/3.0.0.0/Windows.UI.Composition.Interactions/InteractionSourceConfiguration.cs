#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Interactions
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InteractionSourceConfiguration : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.Interactions.InteractionSourceRedirectionMode ScaleSourceMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionSourceRedirectionMode InteractionSourceConfiguration.ScaleSourceMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InteractionSourceRedirectionMode%20InteractionSourceConfiguration.ScaleSourceMode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionSourceConfiguration", "InteractionSourceRedirectionMode InteractionSourceConfiguration.ScaleSourceMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.Interactions.InteractionSourceRedirectionMode PositionYSourceMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionYSourceMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InteractionSourceRedirectionMode%20InteractionSourceConfiguration.PositionYSourceMode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionSourceConfiguration", "InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionYSourceMode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.Interactions.InteractionSourceRedirectionMode PositionXSourceMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionXSourceMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InteractionSourceRedirectionMode%20InteractionSourceConfiguration.PositionXSourceMode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.Interactions.InteractionSourceConfiguration", "InteractionSourceRedirectionMode InteractionSourceConfiguration.PositionXSourceMode");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionXSourceMode.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionXSourceMode.set
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionYSourceMode.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.PositionYSourceMode.set
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.ScaleSourceMode.get
		// Forced skipping of method Windows.UI.Composition.Interactions.InteractionSourceConfiguration.ScaleSourceMode.set
	}
}
