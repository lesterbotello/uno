﻿#nullable enable

using Windows.UI.Xaml.Media;
using Windows.Foundation;
using Uno.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Controls;

internal record struct BorderLayerState(
	Size ElementSize,
	Brush? Background,
	BackgroundSizing BackgroundSizing,
	Brush? BorderBrush,
	Thickness BorderThickness,
	CornerRadius CornerRadius)
{
	internal BorderLayerState(Size elementSize, IBorderInfoProvider borderInfoProvider) : this(
		elementSize,
		borderInfoProvider.Background,
		borderInfoProvider.BackgroundSizing,
		borderInfoProvider.BorderBrush,
		borderInfoProvider.BorderThickness,
		borderInfoProvider.CornerRadius)
	{
	}
}
