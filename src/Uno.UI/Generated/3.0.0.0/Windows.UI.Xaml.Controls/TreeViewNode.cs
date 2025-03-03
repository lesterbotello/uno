#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	[global::Windows.UI.Xaml.Data.BindableAttribute]
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewNode : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsExpanded
		{
			get
			{
				return (bool)this.GetValue(IsExpandedProperty);
			}
			set
			{
				this.SetValue(IsExpandedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool HasUnrealizedChildren
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TreeViewNode.HasUnrealizedChildren is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20TreeViewNode.HasUnrealizedChildren");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TreeViewNode", "bool TreeViewNode.HasUnrealizedChildren");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Content
		{
			get
			{
				return (object)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.TreeViewNode> Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<TreeViewNode> TreeViewNode.Children is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CTreeViewNode%3E%20TreeViewNode.Children");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Depth
		{
			get
			{
				return (int)this.GetValue(DepthProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool HasChildren
		{
			get
			{
				return (bool)this.GetValue(HasChildrenProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.TreeViewNode Parent
		{
			get
			{
				throw new global::System.NotImplementedException("The member TreeViewNode TreeViewNode.Parent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TreeViewNode%20TreeViewNode.Parent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Content), typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewNode), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty DepthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Depth), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewNode), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty HasChildrenProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(HasChildren), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewNode), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsExpandedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsExpanded), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.TreeViewNode), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public TreeViewNode() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TreeViewNode", "TreeViewNode.TreeViewNode()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.TreeViewNode()
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.Content.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.Content.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.Parent.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.IsExpanded.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.IsExpanded.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.HasChildren.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.Depth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.HasUnrealizedChildren.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.HasUnrealizedChildren.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.Children.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.ContentProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.DepthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.IsExpandedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewNode.HasChildrenProperty.get
	}
}
