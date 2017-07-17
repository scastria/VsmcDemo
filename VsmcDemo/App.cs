using System;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Push;
using Xamarin.Forms;

namespace VsmcDemo
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new FirstPage();

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            MobileCenter.Start("ios=cc85ffa0-9495-453d-b6de-789f5e3eb9ab;" +
				   "uwp={Your UWP App secret here};" +
				   "android=28c200dc-f40a-4baf-b9d2-ab4c85dcd1d7",
				   typeof(Analytics), typeof(Crashes), typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
