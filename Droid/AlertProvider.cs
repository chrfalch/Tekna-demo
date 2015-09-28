using System;
using Xamarin.Forms;
using XFTester.Droid;
using System.Threading.Tasks;
using Android.App;

[assembly: Dependency(typeof(AlertProvider))]
namespace XFTester.Droid
{
	public class AlertProvider: IAlertProvider
	{
		#region IAlertProvider implementation
		public Task ShowAlertAsync (string title, string message)
		{
			var tcs = new TaskCompletionSource<bool> ();

			var alert = new AlertDialog.Builder(Forms.Context).Create();
			alert.SetTitle(title);
			alert.SetMessage(message);
			alert.SetButton("OK", (sender, e) => {
				tcs.TrySetResult(true);
			});

			alert.Show ();

			return tcs.Task;
		}
		#endregion
		
	}
}

