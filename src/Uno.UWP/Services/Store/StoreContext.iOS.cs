﻿#if __IOS__
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using Windows.Foundation;
using UIKit;
using Uno.Extensions;
using Uno.Foundation.Logging;

using Foundation;

namespace Windows.Services.Store
{
	public sealed partial class StoreContext
	{
		public IAsyncOperation<StoreProductResult> GetStoreProductForCurrentAppAsync()
		{
			return AsyncOperation.FromTask(async ct =>
			{
				try
				{
					var bundleId = NSBundle.MainBundle.BundleIdentifier;
					var url = $"http://itunes.apple.com/lookup?bundleId={bundleId}";

					var httpClient = new HttpClient();
					var json = await httpClient.GetStringAsync(url);

					var regex = new Regex("trackId[^0-9]*([0-9]*)");
					var match = regex.Match(json);
					if (!match.Success)
					{
						throw new InvalidOperationException("Failed to retrieve trackId from bundleId.");
					}

					var storeId = match.Groups[1].Value;

					return new StoreProductResult
					{
						Product = new StoreProduct
						{
							StoreId = storeId,
							LinkUri = new Uri($"https://itunes.apple.com/app/id{storeId}")
						}
					};
				}
				catch (Exception exception)
				{
					return new StoreProductResult
					{
						ExtendedError = exception
					};
				}
			});
		}
	}
}
#endif