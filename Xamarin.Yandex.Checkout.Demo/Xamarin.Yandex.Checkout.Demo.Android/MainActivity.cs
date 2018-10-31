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

			Checkout.Attach(SupportFragmentManager);

			Checkout.ConfigureTestMode(new Configuration(
				true,  // enableTestMode - включает тестовый режим,
				false, // completeWithError - токенизация проходит с ошибкой,
				false, // paymentAuthPassed - пользователь авторизован в кошельке на Яндексе
				    5, // linkedCardsCount - количество тестовых банковских карт
				true,  // googlePayAvailable - можно заплатить с Google Pay
				true   // googlePayTestEnvironment - включить тестовый режим Google Pay (деньги не списываются)
				));

			Checkout.Tokenize(ApplicationContext,
				new Amount(new Java.Math.BigDecimal(1000), Java.Util.Currency.GetInstance("RUB")),
				new ShopParameters("Urahara shop", "All stuff you need and some more", "test_NTM5MDU47tPjgzXC7lWLEa11A4gzljyBDRkQkjvu7T4",
				new PaymentMethodType[] { PaymentMethodType.BankCard, PaymentMethodType.GooglePay }));

		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			Checkout.Detach();
		}
	}
}