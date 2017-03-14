using System;

using Xamarin.Forms;

namespace MCTest.Core
{
	public class FirstPage : ContentPage
	{
		public FirstPage()
		{
			Title = "SO_Questions Sample";

			Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			var GreetingsLabel = new Label { Text = "Hello StackOverflow!" };

			var QuestionsList = new ListView { ItemTemplate = new DataTemplate(typeof(TextCell)) };

			Content = new StackLayout
			{
				Children = {
					GreetingsLabel,
					QuestionsList
				}
			};

			QuestionsList.SetBinding(ItemsView<Cell>.ItemsSourceProperty, new Binding("Questions"));
			QuestionsList.SetBinding(ListView.SelectedItemProperty, new Binding("SelectedQuestion"));
		}
	}
}

