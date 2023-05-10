﻿using System;
using System.Drawing;
using AppKit;
using Uno.Extensions;
using Uno.UI;
using Uno.UI.DataBinding;
using Windows.UI.Xaml.Shapes;

namespace Windows.UI.Xaml.Controls;

public partial class Page
{
	public override void Layout()
	{
		base.Layout();
		UpdateBorder();
	}
}
