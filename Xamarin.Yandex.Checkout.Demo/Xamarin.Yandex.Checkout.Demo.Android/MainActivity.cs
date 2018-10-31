using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin.Yandex.Checkout.Demo.Droid
{
	using RU.Yandex.Money.Android.Sdk;
	using Splat;
	using Xamarin.Yandex.Checkout.Demo.Servicies;

	[Activity(Label = "Xamarin.Yandex.Checkout.Demo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);
			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
			LoadApplication(new App());

			Locator.CurrentMutable.RegisterConstant<IPaymentProcessor>(new PaymentProcessor(ApplicationContext));

			Checkout.Attach(SupportFragmentManager);
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Checkout.Detach();
		}
	}
}