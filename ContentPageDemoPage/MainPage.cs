using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ContentPageDemoPage { 

  public class MainPage : ContentPage
{
	public MainPage()
	{
		Label header = new Label
		{
			Text = "Младшая сестра",
			FontSize = 40,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center
		};

		Label label1 = new Label
		{
			Text = "Мальчишки ",
                 
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label2 = new Label
		{
			Text = "Не сходятот меня с ума ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label3 = new Label
		{
			Text = "Я им как младшая сестра ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label4 = new Label
		{
			Text = "Заварю всем чай и уложу всех спать ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label5 = new Label
		{
			Text = "Ну почему же ты ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label6 = new Label
		{
			Text = "Выбираешь их? ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label7 = new Label
		{
			Text = "Кукол без души, что не хотя любви ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label8 = new Label
		{
			Text = "Но когда внутри сердечко заболит ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label9 = new Label
		{
			Text = "Ты снова позвонишь, снова мне звонишь ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};



			Title = "ContentPage Demo";
		Padding = new Thickness(10, 0);
		Content = new StackLayout
		{
			Children =
			{
				header,
				label1,
				label2,
				label3,
				label4,
				label5,
				label6,
				label7,
				label8,
				label9
				
			}
		};
	}
}
}
