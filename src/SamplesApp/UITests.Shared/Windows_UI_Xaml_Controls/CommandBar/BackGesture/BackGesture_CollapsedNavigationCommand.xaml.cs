﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Uno.UI.Samples.Content.UITests.CommandBar.BackGesture
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class BackGesture_CollapsedNavigationCommand : Page
	{
		public BackGesture_CollapsedNavigationCommand()
		{
			this.InitializeComponent();
		}

		private void GoBack_Click(object sender, RoutedEventArgs e)
		{
			(Windows.UI.Xaml.Window.Current.Content as Windows.UI.Xaml.Controls.Frame).GoBack();
		}
	}
}
