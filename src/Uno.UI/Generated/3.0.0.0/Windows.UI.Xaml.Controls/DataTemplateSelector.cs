#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class DataTemplateSelector : global::Windows.UI.Xaml.IElementFactory
	{
		// Skipping already declared method Windows.UI.Xaml.Controls.DataTemplateSelector.DataTemplateSelector()
		// Forced skipping of method Windows.UI.Xaml.Controls.DataTemplateSelector.DataTemplateSelector()
		// Skipping already declared method Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplate(object, Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplate(object)
		// Skipping already declared method Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore(object, Windows.UI.Xaml.DependencyObject)
		// Skipping already declared method Windows.UI.Xaml.Controls.DataTemplateSelector.SelectTemplateCore(object)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.UIElement GetElement( global::Windows.UI.Xaml.ElementFactoryGetArgs args)
		{
			throw new global::System.NotImplementedException("The member UIElement DataTemplateSelector.GetElement(ElementFactoryGetArgs args) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UIElement%20DataTemplateSelector.GetElement%28ElementFactoryGetArgs%20args%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RecycleElement( global::Windows.UI.Xaml.ElementFactoryRecycleArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.DataTemplateSelector", "void DataTemplateSelector.RecycleElement(ElementFactoryRecycleArgs args)");
		}
		#endif
		// Processing: Windows.UI.Xaml.IElementFactory
	}
}
