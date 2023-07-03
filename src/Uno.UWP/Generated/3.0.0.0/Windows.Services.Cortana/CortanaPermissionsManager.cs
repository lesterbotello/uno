#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Cortana
{
	// This type is deprecated. Consider not implementing it.
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CortanaPermissionsManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsSupported()
		{
			throw new global::System.NotImplementedException("The member bool CortanaPermissionsManager.IsSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20CortanaPermissionsManager.IsSupported%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> ArePermissionsGrantedAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Cortana.CortanaPermission> permissions)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> CortanaPermissionsManager.ArePermissionsGrantedAsync(IEnumerable<CortanaPermission> permissions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20CortanaPermissionsManager.ArePermissionsGrantedAsync%28IEnumerable%3CCortanaPermission%3E%20permissions%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Cortana.CortanaPermissionsChangeResult> GrantPermissionsAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Cortana.CortanaPermission> permissions)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<CortanaPermissionsChangeResult> CortanaPermissionsManager.GrantPermissionsAsync(IEnumerable<CortanaPermission> permissions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CCortanaPermissionsChangeResult%3E%20CortanaPermissionsManager.GrantPermissionsAsync%28IEnumerable%3CCortanaPermission%3E%20permissions%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Cortana.CortanaPermissionsChangeResult> RevokePermissionsAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Cortana.CortanaPermission> permissions)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<CortanaPermissionsChangeResult> CortanaPermissionsManager.RevokePermissionsAsync(IEnumerable<CortanaPermission> permissions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CCortanaPermissionsChangeResult%3E%20CortanaPermissionsManager.RevokePermissionsAsync%28IEnumerable%3CCortanaPermission%3E%20permissions%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Services.Cortana.CortanaPermissionsManager GetDefault()
		{
			throw new global::System.NotImplementedException("The member CortanaPermissionsManager CortanaPermissionsManager.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CortanaPermissionsManager%20CortanaPermissionsManager.GetDefault%28%29");
		}
		#endif
	}
}
