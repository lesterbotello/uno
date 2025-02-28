﻿#nullable enable

using System;
using Gtk;
using Uno.Foundation.Logging;
using Uno.UI.Runtime.Skia.GTK.Extensions.Helpers;
using Windows.UI.Xaml;
using WinUIApplication = Windows.UI.Xaml.Application;
using WUX = Windows.UI.Xaml;
using GtkApplication = Gtk.Application;
using WinUIWindow = Windows.UI.Xaml.Window;
using Uno.UI.Runtime.Skia.GTK.Extensions;
using Uno.UI.Runtime.Skia.UI.Xaml.Controls;
using Uno.UI.Runtime.Skia.GTK.UI.Controls;
using Uno.UI.Runtime.Skia.GTK.UI;

namespace Uno.UI.Runtime.Skia
{
	public partial class GtkHost : ISkiaApplicationHost
	{
		private const int UnoThemePriority = 800;

		private readonly Func<WUX.Application> _appBuilder;

		[ThreadStatic] private static bool _isDispatcherThread;
		[ThreadStatic] private static GtkHost? _current;

		static GtkHost() => GtkExtensionsRegistrar.Register();

		/// <summary>
		/// Creates a host for a Uno Skia GTK application.
		/// </summary>
		/// <param name="appBuilder">App builder.</param>
		/// <remarks>
		/// Environment.CommandLine is used to fill LaunchEventArgs.Arguments.
		/// </remarks>
		public GtkHost(Func<WinUIApplication> appBuilder)
		{
			_current = this;
			_appBuilder = appBuilder;
		}

		internal static GtkHost? Current => _current;

		internal UnoGtkWindow? MainWindow { get; private set; }

		/// <summary>
		/// Gets or sets the current Skia Render surface type.
		/// </summary>
		/// <remarks>If <c>null</c>, the host will try to determine the most compatible mode.</remarks>
		public RenderSurfaceType? RenderSurfaceType { get; set; }

		public Gtk.Window? Window => MainWindow;

		public void Run()
		{
			PreloadHarfBuzz();

			if (!InitializeGtk())
			{
				return;
			}

			SetupTheme();

			InitializeDispatcher();

			StartApp();

			SetupMainWindow();

			GtkApplication.Run();
		}


		public void TakeScreenshot(string filePath)
		{
			MainWindow?.Host.Renderer?.TakeScreenshot(filePath);
		}

		private void InitializeDispatcher()
		{
			_isDispatcherThread = true;

			Windows.UI.Core.CoreDispatcher.DispatchOverride = GtkDispatch.DispatchNativeSingle;
			Windows.UI.Core.CoreDispatcher.HasThreadAccessOverride = () => _isDispatcherThread;
		}

		private void SetupMainWindow()
		{
			MainWindow = new UnoGtkWindow(WinUIWindow.Current);
			MainWindow.Shown += MainWindow_Shown;
			MainWindow.UpdateWindowPropertiesFromPackage();
			MainWindow.UpdateWindowPropertiesFromApplicationView();
		}

		internal event EventHandler? MainWindowShown;

		private void MainWindow_Shown(object? sender, EventArgs e) => MainWindowShown?.Invoke(this, e);

		private void StartApp()
		{
			void CreateApp(ApplicationInitializationCallbackParams _)
			{
				var app = _appBuilder();
				app.Host = this;
			}

			WinUIApplication.StartWithArguments(CreateApp);
		}

		private bool InitializeGtk()
		{
			try
			{
				Gtk.Application.Init();
				return true;
			}
			catch (TypeInitializationException e)
			{
				Console.Error.WriteLine("Unable to initialize Gtk, visit https://aka.platform.uno/gtk-install for more information.", e);
				return false;
			}
		}

		private void SetupTheme()
		{
			var cssProvider = new CssProvider();
			cssProvider.LoadFromEmbeddedResource("Theming.UnoGtk.css");
			StyleContext.AddProviderForScreen(Gdk.Screen.Default, cssProvider, UnoThemePriority);
		}
	}
}
