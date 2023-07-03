#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkManager : global::Windows.UI.Input.Inking.IInkRecognizerContainer,global::Windows.UI.Input.Inking.IInkStrokeContainer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Input.Inking.InkManipulationMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member InkManipulationMode InkManager.Mode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InkManipulationMode%20InkManager.Mode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "InkManipulationMode InkManager.Mode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect BoundingRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect InkManager.BoundingRect is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.BoundingRect");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InkManager() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "InkManager.InkManager()");
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Inking.InkManager.InkManager()
		// Forced skipping of method Windows.UI.Input.Inking.InkManager.Mode.get
		// Forced skipping of method Windows.UI.Input.Inking.InkManager.Mode.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ProcessPointerDown( global::Windows.UI.Input.PointerPoint pointerPoint)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "void InkManager.ProcessPointerDown(PointerPoint pointerPoint)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object ProcessPointerUpdate( global::Windows.UI.Input.PointerPoint pointerPoint)
		{
			throw new global::System.NotImplementedException("The member object InkManager.ProcessPointerUpdate(PointerPoint pointerPoint) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=object%20InkManager.ProcessPointerUpdate%28PointerPoint%20pointerPoint%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect ProcessPointerUp( global::Windows.UI.Input.PointerPoint pointerPoint)
		{
			throw new global::System.NotImplementedException("The member Rect InkManager.ProcessPointerUp(PointerPoint pointerPoint) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.ProcessPointerUp%28PointerPoint%20pointerPoint%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetDefaultDrawingAttributes( global::Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "void InkManager.SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult>> RecognizeAsync( global::Windows.UI.Input.Inking.InkRecognitionTarget recognitionTarget)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<InkRecognitionResult>> InkManager.RecognizeAsync(InkRecognitionTarget recognitionTarget) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CInkRecognitionResult%3E%3E%20InkManager.RecognizeAsync%28InkRecognitionTarget%20recognitionTarget%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Input.Inking.InkManager.BoundingRect.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void AddStroke( global::Windows.UI.Input.Inking.InkStroke stroke)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "void InkManager.AddStroke(InkStroke stroke)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect DeleteSelected()
		{
			throw new global::System.NotImplementedException("The member Rect InkManager.DeleteSelected() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.DeleteSelected%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect MoveSelected( global::Windows.Foundation.Point translation)
		{
			throw new global::System.NotImplementedException("The member Rect InkManager.MoveSelected(Point translation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.MoveSelected%28Point%20translation%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect SelectWithPolyLine( global::System.Collections.Generic.IEnumerable<global::Windows.Foundation.Point> polyline)
		{
			throw new global::System.NotImplementedException("The member Rect InkManager.SelectWithPolyLine(IEnumerable<Point> polyline) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.SelectWithPolyLine%28IEnumerable%3CPoint%3E%20polyline%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect SelectWithLine( global::Windows.Foundation.Point from,  global::Windows.Foundation.Point to)
		{
			throw new global::System.NotImplementedException("The member Rect InkManager.SelectWithLine(Point from, Point to) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.SelectWithLine%28Point%20from%2C%20Point%20to%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void CopySelectedToClipboard()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "void InkManager.CopySelectedToClipboard()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect PasteFromClipboard( global::Windows.Foundation.Point position)
		{
			throw new global::System.NotImplementedException("The member Rect InkManager.PasteFromClipboard(Point position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkManager.PasteFromClipboard%28Point%20position%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanPasteFromClipboard()
		{
			throw new global::System.NotImplementedException("The member bool InkManager.CanPasteFromClipboard() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20InkManager.CanPasteFromClipboard%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncActionWithProgress<ulong> LoadAsync( global::Windows.Storage.Streams.IInputStream inputStream)
		{
			throw new global::System.NotImplementedException("The member IAsyncActionWithProgress<ulong> InkManager.LoadAsync(IInputStream inputStream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncActionWithProgress%3Culong%3E%20InkManager.LoadAsync%28IInputStream%20inputStream%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperationWithProgress<uint, uint> SaveAsync( global::Windows.Storage.Streams.IOutputStream outputStream)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<uint, uint> InkManager.SaveAsync(IOutputStream outputStream) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Cuint%2C%20uint%3E%20InkManager.SaveAsync%28IOutputStream%20outputStream%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void UpdateRecognitionResults( global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult> recognitionResults)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "void InkManager.UpdateRecognitionResults(IReadOnlyList<InkRecognitionResult> recognitionResults)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkStroke> GetStrokes()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<InkStroke> InkManager.GetStrokes() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CInkStroke%3E%20InkManager.GetStrokes%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult> GetRecognitionResults()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<InkRecognitionResult> InkManager.GetRecognitionResults() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CInkRecognitionResult%3E%20InkManager.GetRecognitionResults%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetDefaultRecognizer( global::Windows.UI.Input.Inking.InkRecognizer recognizer)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkManager", "void InkManager.SetDefaultRecognizer(InkRecognizer recognizer)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult>> RecognizeAsync( global::Windows.UI.Input.Inking.InkStrokeContainer strokeCollection,  global::Windows.UI.Input.Inking.InkRecognitionTarget recognitionTarget)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<InkRecognitionResult>> InkManager.RecognizeAsync(InkStrokeContainer strokeCollection, InkRecognitionTarget recognitionTarget) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CInkRecognitionResult%3E%3E%20InkManager.RecognizeAsync%28InkStrokeContainer%20strokeCollection%2C%20InkRecognitionTarget%20recognitionTarget%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognizer> GetRecognizers()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<InkRecognizer> InkManager.GetRecognizers() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CInkRecognizer%3E%20InkManager.GetRecognizers%28%29");
		}
		#endif
		// Processing: Windows.UI.Input.Inking.IInkRecognizerContainer
		// Processing: Windows.UI.Input.Inking.IInkStrokeContainer
	}
}
