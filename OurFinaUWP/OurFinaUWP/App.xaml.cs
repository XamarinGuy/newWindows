using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace OurFinaUWP
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("uwp=14ba735a-5b04-4488-ab2f-1ef9e56e8de5;" + "android={Your Android App secret here}" + "ios={Your iOS App secret here}", typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
