using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reactive;
using System.Text;
using Xamarin.Forms;
using Xamarin.Yandex.Checkout.Demo.Servicies;

namespace Xamarin.Yandex.Checkout.Demo.ViewModels
{
	public class PaymentViewModel : ViewModelBase
	{
		public PaymentViewModel()
		{
			_urlPathSegment = "Payment demo";

			var paymentService = Locator.Current.GetService<IPaymentProcessor>();

			var canPay = this.WhenAnyValue(_ => _.Amount, _ => !string.IsNullOrEmpty(_) && decimal.TryParse(_, NumberStyles.Currency, CultureInfo.InvariantCulture, out var amount) && amount > 0);
			ProcessPaymentCommand = ReactiveCommand
				.CreateFromObservable(() => Locator.Current.GetService<IPaymentProcessor>().BeginPay(decimal.Parse(Amount, NumberStyles.Currency, CultureInfo.InvariantCulture)), canPay);

			ProcessPaymentCommand.Subscribe(_ => Application.Current.MainPage
				.DisplayAlert(_.Success ? "Hooray!" : "Oops!", _.Message, "OK"));

		}

		[Reactive]
		public string Amount { get; set; } = "1000";

		public ReactiveCommand<Unit, PaymentResult>ProcessPaymentCommand { get; }
	}
}
