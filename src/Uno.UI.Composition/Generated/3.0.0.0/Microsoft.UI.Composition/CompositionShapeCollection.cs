#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionShapeCollection : global::Microsoft.UI.Composition.CompositionObject,global::System.Collections.Generic.IList<global::Microsoft.UI.Composition.CompositionShape>,global::System.Collections.Generic.IEnumerable<global::Microsoft.UI.Composition.CompositionShape>
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CompositionShapeCollection.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20CompositionShapeCollection.Size");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.RemoveAt(uint)
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.GetAt(uint)
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.Append(Microsoft.UI.Composition.CompositionShape)
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.RemoveAtEnd()
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.Clear()
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.GetMany(uint, Microsoft.UI.Composition.CompositionShape[])
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.ReplaceAll(Microsoft.UI.Composition.CompositionShape[])
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.First()
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.Size.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.GetView()
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.IndexOf(Microsoft.UI.Composition.CompositionShape, out uint)
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.SetAt(uint, Microsoft.UI.Composition.CompositionShape)
		// Forced skipping of method Microsoft.UI.Composition.CompositionShapeCollection.InsertAt(uint, Microsoft.UI.Composition.CompositionShape)
		// Processing: System.Collections.Generic.IList<Microsoft.UI.Composition.CompositionShape>
		// Skipping already implement System.Collections.Generic.IList<Microsoft.UI.Composition.CompositionShape>.this[int]
		// Processing: System.Collections.Generic.ICollection<Microsoft.UI.Composition.CompositionShape>
		// Skipping already implement System.Collections.Generic.ICollection<Microsoft.UI.Composition.CompositionShape>.Count
		// Skipping already implement System.Collections.Generic.ICollection<Microsoft.UI.Composition.CompositionShape>.IsReadOnly
		// Processing: System.Collections.Generic.IEnumerable<Microsoft.UI.Composition.CompositionShape>
		// Processing: System.Collections.IEnumerable
	}
}
