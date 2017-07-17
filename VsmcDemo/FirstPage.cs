using System;
using Xamarin.Forms;

namespace VsmcDemo
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            BackgroundColor = Color.Red;
            Title = "VsmcDemo";
            Button btn = new Button {
                Text = "Crash Me!"
            };
            btn.Clicked += (sender, e) => {
                string crash = null;
                Console.WriteLine(crash.Length);
            };
            Content = new StackLayout {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    btn
                }
            };
    	}
    }
}
