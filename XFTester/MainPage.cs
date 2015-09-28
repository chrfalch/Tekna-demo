using System;
using Xamarin.Forms;

namespace XFTester
{
	public class MainPage: ContentPage
	{
		public MainPage ()
		{
			Title = "Main Page";
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Welcome to Xamarin Forms!"
					},
					new Button{
						Text = "View Details",
						Command = new Command(async () => await Navigation.PushAsync(new DetailsPage()))
					},
				}
			};
		}
	}
}

