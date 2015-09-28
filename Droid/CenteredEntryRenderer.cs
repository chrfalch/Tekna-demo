using System;
using Xamarin.Forms;
using XFTester;
using XFTester.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(CenteredEntry), typeof(CenteredEntryRenderer))]
namespace XFTester.Droid
{
	public class CenteredEntryRenderer: EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				Control.Gravity = GravityFlags.AxisSpecified;
			}
		}
	}
}

