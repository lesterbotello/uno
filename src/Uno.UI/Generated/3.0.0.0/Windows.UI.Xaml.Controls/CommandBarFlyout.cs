#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	[global::Windows.UI.Xaml.Markup.ContentPropertyAttribute(Name = "PrimaryCommands")]
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CommandBarFlyout : global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Windows.UI.Xaml.Controls.ICommandBarElement> PrimaryCommands
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<ICommandBarElement> CommandBarFlyout.PrimaryCommands is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IObservableVector%3CICommandBarElement%3E%20CommandBarFlyout.PrimaryCommands");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.IObservableVector<global::Windows.UI.Xaml.Controls.ICommandBarElement> SecondaryCommands
		{
			get
			{
				throw new global::System.NotImplementedException("The member IObservableVector<ICommandBarElement> CommandBarFlyout.SecondaryCommands is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IObservableVector%3CICommandBarElement%3E%20CommandBarFlyout.SecondaryCommands");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CommandBarFlyout() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.CommandBarFlyout", "CommandBarFlyout.CommandBarFlyout()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.CommandBarFlyout.CommandBarFlyout()
		// Forced skipping of method Windows.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands.get
		// Forced skipping of method Windows.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands.get
	}
}
