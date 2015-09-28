using System;
using Xamarin.Forms;

namespace XFTester
{
	public class DetailsPage: ContentPage
	{
		public DetailsPage ()
		{
			Title = "Details";
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Padding = 25,
				Spacing = 25,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Enter your name:"
					},
					new CenteredEntry{
						Placeholder = "First name/last name",
					},
					new EllipseControl{FillColor = Color.Red, HeightRequest = 60},
					new Button{
						Text = "Click me!",
						Command = new Command(async () => {
							await DependencyService.Get<IAlertProvider>().ShowAlertAsync("Tekna", "Hello World!");
							await DependencyService.Get<IAlertProvider>().ShowAlertAsync("Tekna", "Thanks.");
						}),
					}
				}
			};
		}
	}
}

