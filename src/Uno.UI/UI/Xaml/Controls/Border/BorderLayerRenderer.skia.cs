﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using SkiaSharp;
using Uno;
using Uno.Disposables;
using Uno.Extensions;
using Uno.UI;
using Uno.UI.Extensions;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
	partial class BorderLayerRenderer
	{
		private static SKPoint[] _outerRadiiStore = new SKPoint[4];
		private static SKPoint[] _innerRadiiStore = new SKPoint[4];

		private LayoutState _currentState;

		private SerialDisposable _layerDisposable = new SerialDisposable();

		/// <summary>
		/// Updates or creates a sublayer to render a border-like shape.
		/// </summary>
		/// <param name="owner">The parent layer to apply the shape</param>
		/// <param name="background">The background brush</param>
		/// <param name="borderThickness">The border thickness</param>
		/// <param name="borderBrush">The border brush</param>
		/// <param name="cornerRadius">The corner radius</param>
		/// <param name="backgroundImage">The background image in case of a ImageBrush background</param>
		public void UpdateLayer(
			FrameworkElement owner,
			Brush background,
			BackgroundSizing backgroundSizing,
			Thickness borderThickness,
			Brush borderBrush,
			CornerRadius cornerRadius,
			object backgroundImage
		)
		{
			// Bounds is captured to avoid calling twice calls below.
			var area = new Rect(0, 0, owner.ActualWidth, owner.ActualHeight);

			var newState = new LayoutState(area, background, backgroundSizing, borderThickness, borderBrush, cornerRadius, backgroundImage);
			var previousLayoutState = _currentState;

			if (!newState.Equals(previousLayoutState))
			{
				if (
					background != null ||
					cornerRadius != CornerRadius.None ||
					(borderThickness != Thickness.Empty && borderBrush != null)
				)
				{

					_layerDisposable.Disposable = null;
					_layerDisposable.Disposable = InnerCreateLayer(owner, newState);
				}
				else
				{
					_layerDisposable.Disposable = null;
				}

				_currentState = newState;
			}
		}

		/// <summary>
		/// Removes the added layers during a call to <see cref="UpdateLayer" />.
		/// </summary>
		internal void Clear()
		{
			_layerDisposable.Disposable = null;
			_currentState = null;
		}

		private static IDisposable InnerCreateLayer(UIElement owner, LayoutState state)
		{
			var area = owner.LayoutRound(state.Area);

			// In case the element has no size, skip everything!
			if (area.Width == 0 && area.Height == 0)
			{
				return Disposable.Empty;
			}

			var visual = owner.Visual;
			var compositor = visual.Compositor;
			var background = state.Background;
			var borderThickness = owner.LayoutRound(state.BorderThickness);
			var borderBrush = state.BorderBrush;
			var cornerRadius = state.CornerRadius;

			var disposables = new CompositeDisposable();
			var shapes = new List<CompositionShape>();

			var adjustedArea = state.BackgroundSizing == BackgroundSizing.InnerBorderEdge
				? area.DeflateBy(borderThickness)
				: area;

			var fullCornerRadius = cornerRadius.GetRadii(area.Size, borderThickness);

			if (!fullCornerRadius.IsEmpty)
			{
				var borderShape = compositor.CreateSpriteShape();
				var backgroundShape = compositor.CreateSpriteShape();

				// Border brush
				Brush.AssignAndObserveBrush(borderBrush, compositor, brush => borderShape.FillBrush = brush)
						.DisposeWith(disposables);

				// Background brush
				if (background is ImageBrush imgBackground)
				{
					adjustedArea = CreateImageLayer(compositor, disposables, borderThickness, adjustedArea, backgroundShape, adjustedArea, imgBackground);
				}
				else
				{
					Brush.AssignAndObserveBrush(background, compositor, brush => backgroundShape.FillBrush = brush)
						.DisposeWith(disposables);
				}

				// This needs to be adjusted if multiple UI threads are used in the future for multi-window
				fullCornerRadius.Outer.GetRadii(_outerRadiiStore);
				fullCornerRadius.Inner.GetRadii(_innerRadiiStore);

				// Background shape
				var backgroundPath = state.BackgroundSizing == BackgroundSizing.InnerBorderEdge ?
					GetRoundedPath(adjustedArea.ToSKRect(), _innerRadiiStore) :
					GetRoundedPath(area.ToSKRect(), _outerRadiiStore);
				backgroundShape.Geometry = compositor.CreatePathGeometry(backgroundPath);
#if DEBUG
				backgroundShape.Comment = "#background";
#endif

				visual.Shapes.Add(backgroundShape);
				shapes.Add(backgroundShape);

				// Border shape (if any)
				if (borderThickness != Thickness.Empty)
				{
					var borderPath = GetBorderPath(_outerRadiiStore, _innerRadiiStore, area, adjustedArea);
					borderShape.Geometry = compositor.CreatePathGeometry(borderPath);

					visual.Shapes.Add(borderShape);
					shapes.Add(borderShape);
#if DEBUG
					backgroundShape.Comment = "#border";
#endif
				}

				owner.ClippingIsSetByCornerRadius = true;
				visual.Clip = compositor.CreateRectangleClip(
					0, 0, (float)area.Width, (float)area.Height,
					fullCornerRadius.Outer.TopLeft, fullCornerRadius.Outer.TopRight, fullCornerRadius.Outer.BottomRight, fullCornerRadius.Outer.BottomLeft);
			}
			else
			{
				var backgroundShape = compositor.CreateSpriteShape();

				// Background brush
				if (background is ImageBrush imgBackground)
				{
					CreateImageLayer(compositor, disposables, borderThickness, adjustedArea, backgroundShape, area, imgBackground);
				}
				else
				{
					Brush.AssignAndObserveBrush(background, compositor, brush => backgroundShape.FillBrush = brush)
						.DisposeWith(disposables);

					// This is required because changing the CornerRadius changes the background drawing
					// implementation and we don't want a rectangular background behind a rounded background.
					Disposable.Create(() => backgroundShape.FillBrush = null)
						.DisposeWith(disposables);
				}

				var geometrySource = new SkiaGeometrySource2D();
				var geometry = geometrySource.Geometry;

				geometry.AddRect(adjustedArea.ToSKRect());

				backgroundShape.Geometry = compositor.CreatePathGeometry(new CompositionPath(geometrySource));
#if DEBUG
				backgroundShape.Comment = "#background";
#endif

				visual.Shapes.Add(backgroundShape);
				shapes.Add(backgroundShape);

				// Border shape (if any)
				if (borderThickness != Thickness.Empty)
				{
					void CreateLayer(Action<CompositionSpriteShape, SKPath> builder, string name)
					{
						var spriteShape = compositor.CreateSpriteShape();
						var geometry = new SkiaGeometrySource2D();

						// Border brush
						Brush.AssignAndObserveBrush(borderBrush, compositor, brush => spriteShape.StrokeBrush = brush)
							.DisposeWith(disposables);

						builder(spriteShape, geometry.Geometry);
						spriteShape.Geometry = compositor.CreatePathGeometry(new CompositionPath(geometry));
#if DEBUG
						spriteShape.Comment = name;
#endif

						visual.Shapes.Add(spriteShape);
						shapes.Add(spriteShape);
					}

					if (borderThickness.Top != 0)
					{
						CreateLayer((l, path) =>
						{
							l.StrokeThickness = (float)borderThickness.Top;
							var StrokeThicknessAdjust = (float)(borderThickness.Top / 2);
							path.MoveTo((float)(area.X + borderThickness.Left), (float)(area.Y + StrokeThicknessAdjust));
							path.LineTo((float)(area.X + area.Width - borderThickness.Right), (float)(area.Y + StrokeThicknessAdjust));
							path.Close();
						}, "#border-top");
					}

					if (borderThickness.Bottom != 0)
					{
						CreateLayer((l, path) =>
						{
							l.StrokeThickness = (float)borderThickness.Bottom;
							var StrokeThicknessAdjust = borderThickness.Bottom / 2;
							path.MoveTo((float)(area.X + (float)borderThickness.Left), (float)(area.Y + area.Height - StrokeThicknessAdjust));
							path.LineTo((float)(area.X + area.Width - (float)borderThickness.Right), (float)(area.Y + area.Height - StrokeThicknessAdjust));
							path.Close();
						}, "#border-bottom");
					}

					if (borderThickness.Left != 0)
					{
						CreateLayer((l, path) =>
						{
							l.StrokeThickness = (float)borderThickness.Left;
							var StrokeThicknessAdjust = borderThickness.Left / 2;
							path.MoveTo((float)(area.X + StrokeThicknessAdjust), (float)area.Y);
							path.LineTo((float)(area.X + StrokeThicknessAdjust), (float)(area.Y + area.Height));
							path.Close();
						}, "#border-left");
					}

					if (borderThickness.Right != 0)
					{
						CreateLayer((l, path) =>
						{
							l.StrokeThickness = (float)borderThickness.Right;
							var StrokeThicknessAdjust = borderThickness.Right / 2;
							path.MoveTo((float)(area.X + area.Width - StrokeThicknessAdjust), (float)area.Y);
							path.LineTo((float)(area.X + area.Width - StrokeThicknessAdjust), (float)(area.Y + area.Height));
							path.Close();
						}, "#border-right");
					}
				}
			}

			disposables.Add(() =>
			{
				owner.ClippingIsSetByCornerRadius = false;

				foreach (var shape in shapes)
				{
					visual.Shapes.Remove(shape);
					shape.Dispose();
				}
			}
			);

			compositor.InvalidateRender();

			return disposables;
		}

		private static Rect CreateImageLayer(Compositor compositor, CompositeDisposable disposables, Thickness borderThickness, Rect adjustedArea, CompositionSpriteShape backgroundShape, Rect backgroundArea, ImageBrush imgBackground)
		{
			imgBackground.Subscribe(imageData =>
			{

				if (imageData.Error is null)
				{
					var surfaceBrush = compositor.CreateSurfaceBrush(imageData.CompositionSurface);

					var sourceImageSize = new Size(imageData.CompositionSurface.Image.Width, imageData.CompositionSurface.Image.Height);

					// We reduce the adjustedArea again so that the image is inside the border (like in Windows)
					var imageArea = adjustedArea.DeflateBy(borderThickness);

					backgroundArea = imgBackground.GetArrangedImageRect(sourceImageSize, imageArea);

					// surfaceBrush.Offset = new Vector2((float)imageFrame.Left, (float)imageFrame.Top);
					var matrix = Matrix3x2.CreateScale((float)(backgroundArea.Width / sourceImageSize.Width), (float)(backgroundArea.Height / sourceImageSize.Height));
					matrix *= Matrix3x2.CreateTranslation((float)backgroundArea.Left, (float)backgroundArea.Top);

					if (imgBackground.Transform != null)
					{
						matrix *= imgBackground.Transform.MatrixCore;
					}

					surfaceBrush.TransformMatrix = matrix;

					backgroundShape.FillBrush = surfaceBrush;
				}
				else
				{
					backgroundShape.FillBrush = null;
				}
			}).DisposeWith(disposables);
			return backgroundArea;
		}

		private static CompositionPath GetRoundedPath(SKRect area, SKPoint[] radii, SkiaGeometrySource2D geometrySource = null)
		{
			geometrySource ??= new SkiaGeometrySource2D();
			var geometry = geometrySource.Geometry;

			var roundRect = CreateRoundRect(area, radii);
			geometry.AddRoundRect(roundRect);
			geometry.Close();

			return new CompositionPath(geometrySource);
		}

		private static SKRoundRect CreateRoundRect(SKRect area, SKPoint[] radii)
		{
			var roundRect = new SKRoundRect();
			roundRect.SetRectRadii(area, radii);
			return roundRect;
		}

		private static CompositionPath GetBorderPath(SKPoint[] outerRadii, SKPoint[] innerRadii, Rect area, Rect insetArea)
		{
			var geometrySource = new SkiaGeometrySource2D();
			GetRoundedPath(area.ToSKRect(), outerRadii, geometrySource);
			GetRoundedPath(insetArea.ToSKRect(), innerRadii, geometrySource);
			geometrySource.Geometry.FillType = SKPathFillType.EvenOdd;

			return new CompositionPath(geometrySource);
		}

		private class LayoutState : IEquatable<LayoutState>
		{
			public readonly Rect Area;
			public readonly Brush Background;
			public readonly BackgroundSizing BackgroundSizing;
			public readonly Brush BorderBrush;
			public readonly Thickness BorderThickness;
			public readonly CornerRadius CornerRadius;
			public readonly object BackgroundImage;

			public LayoutState(Rect area, Brush background, BackgroundSizing backgroundSizing,
				Thickness borderThickness, Brush borderBrush, CornerRadius cornerRadius, object backgroundImage)
			{
				Area = area;
				Background = background;
				BackgroundSizing = backgroundSizing;
				BorderBrush = borderBrush;
				CornerRadius = cornerRadius;
				BorderThickness = borderThickness;
				BackgroundImage = backgroundImage;
			}

			public bool Equals(LayoutState other)
			{
				return other != null
					&& other.Area == Area
					&& other.Background == Background
					&& other.BackgroundSizing == BackgroundSizing
					&& other.BorderBrush == BorderBrush
					&& other.BorderThickness == BorderThickness
					&& other.CornerRadius == CornerRadius
					&& other.BackgroundImage == BackgroundImage;
			}
		}
	}
}
