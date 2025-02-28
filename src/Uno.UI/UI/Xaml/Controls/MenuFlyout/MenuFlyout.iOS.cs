using System;
using System.Collections.Generic;
using System.Linq;
using Uno.Disposables;
using System.Text;
using System.Windows.Input;
using Foundation;
using Uno.Client;
using Uno.Extensions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using UIKit;
using Uno.UI;

namespace Windows.UI.Xaml.Controls
{
	public partial class MenuFlyout
	{
		private static DependencyProperty CancelTextIosOverrideProperty = ToolkitHelper.GetProperty("Uno.UI.Toolkit.MenuFlyoutExtensions", "CancelTextIosOverride");

#pragma warning disable CS0618 // Type or member is obsolete
		private string LocalizedCancelString => NSBundle.FromIdentifier("com.apple.UIKit")
#if NET6_0_OR_GREATER
			.GetLocalizedString("Cancel", null);
#else
			.LocalizedString("Cancel", null);
#endif
#pragma warning restore CS0618 // Type or member is obsolete

		internal protected override void Open()
		{
			if (UseNativePopup)
			{

				if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
				{
					ShowAlert(Target);
				}
				else if (UIDevice.CurrentDevice.CheckSystemVersion(7, 0))
				{
					ShowActionSheet(Target);
				}
			}
			else
			{
				base.Open();
			}
		}

		internal protected override void Close()
		{
			if (UseNativePopup)
			{

				if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
				{
					HideAlert();
				}
				else if (UIDevice.CurrentDevice.CheckSystemVersion(7, 0))
				{
					HideActionSheet();
				}
			}
			else
			{
				base.Close();
			}
		}
	}
}
