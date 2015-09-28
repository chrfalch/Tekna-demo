using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFTester;
using XFTester.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(CenteredEntry), typeof(CenteredEntryRenderer))]
namespace XFTester.iOS
{
	public class CenteredEntryRenderer: EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);
		
			(Control as UITextField).TextAlignment = UITextAlignment.Center;
		}
	}
}

