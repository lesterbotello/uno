﻿namespace Windows.UI.Xaml.Controls;

partial class Border
{
	partial void OnBackgroundChangedPartial(DependencyPropertyChangedEventArgs e) =>
		UpdateHitTest();
}
