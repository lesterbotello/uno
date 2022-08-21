﻿using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Uno.Foundation.Extensibility;
using Uno.Foundation.Logging;
using Uno.UI.Xaml.Media.Imaging.Svg;
using Windows.Graphics.Display;
using Windows.Graphics.Imaging;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Imaging;

partial class SvgImageSource
{
	private ISvgProvider _svgProvider;

	partial void InitPartial()
	{
		if (!ApiExtensibility.CreateInstance(this, out _svgProvider))
		{
			if (this.Log().IsEnabled(LogLevel.Error))
			{
				this.Log().LogError("To use SVG on this platform, make sure to install the Uno.UI.Svg package.");
			}
		}
	}

	internal UIElement GetCanvas() => _svgProvider.GetCanvas();

	private protected override bool TryOpenSourceAsync(CancellationToken ct, int? targetWidth, int? targetHeight, out Task<ImageData> asyncImage)
	{
		asyncImage = TryOpenSourceAsync(ct);
		return true;
	}

	private async Task<ImageData> TryOpenSourceAsync(CancellationToken ct)
	{
		try
		{
			if (UriSource != null)
			{
				if (UriSource.Scheme == "http" || UriSource.Scheme == "https")
				{
					var client = new HttpClient();
					var response = await client.GetAsync(UriSource, HttpCompletionOption.ResponseContentRead, ct);
					using var imageStream = await response.Content.ReadAsStreamAsync();
					return await ReadFromStreamAsync(imageStream);
				}
				else if (UriSource.Scheme == "ms-appx")
				{
					var path = UriSource.PathAndQuery;
					path = GetApplicationPath(path);
					using var fileStream = File.OpenRead(path);
					return await ReadFromStreamAsync(fileStream);
				}
				else if (UriSource.Scheme == "ms-appdata")
				{
					using var fileStream = File.OpenRead(FilePath);
					return await ReadFromStreamAsync(fileStream);
				}
			}
			else if (_stream != null)
			{
				return await ReadFromStreamAsync(_stream.AsStream());
			}
		}
		catch (Exception e)
		{
			return new ImageData() { Error = e };
		}

		return default;
	}

	private async Task<ImageData> ReadFromStreamAsync(Stream stream)
	{
		var memoryStream = new MemoryStream();
		await stream.CopyToAsync(memoryStream);
		var data = memoryStream.ToArray();
		return ImageData.FromBytes(data);
	}

	private static string GetApplicationPath(string rawPath)
	{
		var originalLocalPath =
			Path.Combine(Windows.Application­Model.Package.Current.Installed­Location.Path,
				 rawPath.TrimStart('/').Replace('/', global::System.IO.Path.DirectorySeparatorChar)
			);

		return originalLocalPath;
	}
}