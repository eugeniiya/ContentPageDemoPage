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
			Text = "Ìëàäøàÿ ñåñòðà",
			FontSize = 40,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center
		};

		Label label1 = new Label
		{
			Text = "Ìàëü÷èøêè (Ìàëü÷èøêè) ",
                 
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label2 = new Label
		{
			Text = "Íå ñõîäÿò îò ìåíÿ ñ óìà ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label3 = new Label
		{
			Text = "ß èì êàê ìëàäøàÿ ñåñòðà ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label4 = new Label
		{
			Text = "Çàâàðþ âñåì ÷àé è óëîæó âñåõ ñïàòü ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label5 = new Label
		{
			Text = "Íî ïî÷åìó æå òû ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label6 = new Label
		{
			Text = "Âûáèðàåøü èõ? ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label7 = new Label
		{
			Text = "Êóêîë áåç äóøè, ÷òî íå õîòÿò ëþáâè ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label8 = new Label
		{
			Text = "Íî êîãäà âíóòðè ñåðäå÷êî çàáîëèò ",
			FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
		};

		Label label9 = new Label
		{
			Text = "Òû ñíîâà ïîçâîíèøü, ñíîâà ìíå çâîíèøü ",
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
