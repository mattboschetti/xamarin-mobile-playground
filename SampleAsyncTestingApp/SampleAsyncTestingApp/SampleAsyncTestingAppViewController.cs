using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading.Tasks;

namespace SampleAsyncTestingApp
{
	public partial class SampleAsyncTestingAppViewController : UIViewController
	{
		public SampleAsyncTestingAppViewController () : base ("SampleAsyncTestingAppViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		async partial void calculatePrimeAsync (NSObject sender)
		{
			txtNthPrimeFound.Text = "Calculating...";
			var i = int.Parse(txtNthPrimeToFind.Text);
			var x = await FindPrimeNumberAsync(i);
			txtNthPrimeFound.Text = x.ToString();
		}

		partial void calculatePrimeSync (NSObject sender)
		{
			var i = int.Parse(txtNthPrimeToFind.Text);
			var x = FindPrimeNumber(i);
			txtNthPrimeFound.Text = x.ToString();
		}

		public Task<long> FindPrimeNumberAsync(int n)
		{
			return Task.Run (() => { return FindPrimeNumber(n);	});
		}

		// Algorithm to find the nth prime number extracted from 
		// http://stackoverflow.com/questions/13001578/i-need-a-slow-c-sharp-function
		public long FindPrimeNumber(int n)
		{
			int count = 0;
			long a = 2;
			while (count<n) {
				long b = 2;
				int prime = 1;// to check if found a prime
				while (b * b <= a) {
					if (a % b == 0) {
						prime = 0;
						break;
					}
					b++;
				}
				if (prime > 0)
					count++;
				a++;
			}
			return (--a);
		}
	}
}

