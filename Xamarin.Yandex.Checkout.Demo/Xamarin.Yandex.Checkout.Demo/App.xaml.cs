using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin.Yandex.Checkout.Demo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var bootsrapper = new AppBootstrapper();
			MainPage = bootsrapper.MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
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
