using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Yandex.Checkout.Demo.Servicies;

namespace Xamarin.Yandex.Checkout.Demo.Droid
{
	using RU.Yandex.Money.Android.Sdk;
	using System.Reactive.Subjects;

	class PaymentProcessor : IPaymentProcessor
	{
		private readonly Context _applicationContext;

		public PaymentProcessor(Context applicationContext)
		{
			_applicationContext = applicationContext;
		}

		public IObservable<PaymentResult> BeginPay(decimal amount)
		{
			Checkout.ConfigureTestMode(new Configuration(
				true,  // enableTestMode - включает тестовый режим,
				false, // completeWithError - токенизация проходит с ошибкой,
				false, // paymentAuthPassed - пользователь авторизован в кошельке на Яндексе
				    5, // linkedCardsCount - количество тестовых банковских карт
				true,  // googlePayAvailable - можно заплатить с Google Pay
				true   // googlePayTestEnvironment - включить тестовый режим Google Pay (деньги не списываются)
				));

			var res = new Subject<PaymentResult>();

			Checkout.SetResultCallback(new ResultCallback(res));

			Checkout.Tokenize(_applicationContext,
				new Amount(new Java.Math.BigDecimal((double)amount), Java.Util.Currency.GetInstance("RUB")),
				new ShopParameters("Urahara shop",
				"All stuff you need and some more",
				"test_NTM5MDU47tPjgzXC7lWLEa11A4gzljyBDRkQkjvu7T4",
				new PaymentMethodType[] { PaymentMethodType.BankCard, PaymentMethodType.GooglePay },
				true,
				"539058"));

			return res;

		}

		private class ResultCallback : Java.Lang.Object, Checkout.IResultCallback
		{
			private readonly Subject<PaymentResult> _res;

			public ResultCallback(Subject<PaymentResult> res)
			{
				_res = res;
			}

			public void OnResult(string p0, PaymentMethodType p1)
			{
				_res.OnNext(new PaymentResult(true, $"{p0}: {p1}"));
				_res.OnCompleted();
			}
		}
	}
}