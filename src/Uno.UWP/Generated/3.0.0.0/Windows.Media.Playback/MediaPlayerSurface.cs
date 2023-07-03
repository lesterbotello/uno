#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaPlayerSurface : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Playback.MediaPlayer MediaPlayer
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlayer MediaPlayerSurface.MediaPlayer is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlayer%20MediaPlayerSurface.MediaPlayer");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayerSurface.CompositionSurface.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayerSurface.Compositor.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayerSurface.MediaPlayer.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayerSurface", "void MediaPlayerSurface.Dispose()");
		}
		#endif
		// Processing: System.IDisposable
	}
}
