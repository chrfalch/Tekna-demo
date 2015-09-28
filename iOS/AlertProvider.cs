using System;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using XFTester.iOS;

[assembly: Dependency(typeof(AlertProvider))]
namespace XFTester.iOS
{
	public class AlertProvider: IAlertProvider
	{
		#region IAlertProvider implementation

		public Task ShowAlertAsync (string title, string message)
		{
			var tcs = new TaskCompletionSource<bool> ();

			var alert = new UIAlertView (title, message, null, "OK");
			alert.Clicked += (sender, e) => {
				tcs.SetResult (true);
			};

			alert.Show ();

			return tcs.Task;
		}

		#endregion

		public AlertProvider ()
		{
		}
	}
}

