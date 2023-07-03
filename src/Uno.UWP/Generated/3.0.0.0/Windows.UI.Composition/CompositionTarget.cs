#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionTarget : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.Visual Root
		{
			get
			{
				throw new global::System.NotImplementedException("The member Visual CompositionTarget.Root is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Visual%20CompositionTarget.Root");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionTarget", "Visual CompositionTarget.Root");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionTarget.Root.get
		// Forced skipping of method Windows.UI.Composition.CompositionTarget.Root.set
	}
}
