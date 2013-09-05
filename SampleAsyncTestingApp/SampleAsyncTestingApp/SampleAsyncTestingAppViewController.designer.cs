// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SampleAsyncTestingApp
{
	[Register ("SampleAsyncTestingAppViewController")]
	partial class SampleAsyncTestingAppViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField txtNthPrimeFound { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtNthPrimeToFind { get; set; }

		[Action ("calculatePrimeAsync:")]
		partial void calculatePrimeAsync (MonoTouch.Foundation.NSObject sender);

		[Action ("calculatePrimeSync:")]
		partial void calculatePrimeSync (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtNthPrimeToFind != null) {
				txtNthPrimeToFind.Dispose ();
				txtNthPrimeToFind = null;
			}

			if (txtNthPrimeFound != null) {
				txtNthPrimeFound.Dispose ();
				txtNthPrimeFound = null;
			}
		}
	}
}
