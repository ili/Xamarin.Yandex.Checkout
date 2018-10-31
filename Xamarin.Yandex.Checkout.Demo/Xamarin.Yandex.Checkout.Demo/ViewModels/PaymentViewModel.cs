using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using System;
using System.Collections.Generic;
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
			var paymentService = Locator.Current.GetService<IPaymentProcessor>();

			var canPay = this.WhenAnyValue(_ => _.Amount, _ => _ > 0);
			ProcessPaymentCommand = ReactiveCommand
				.CreateFromObservable(() => Locator.Current.GetService<IPaymentProcessor>().BeginPay(Amount), canPay);

			ProcessPaymentCommand.Subscribe(_ => Application.Current.MainPage
				.DisplayAlert(_.Success ? "Hooray!" : "Oops!", _.Message, "OK"));

		}

		[Reactive]
		public decimal Amount { get; set; } = 1000;

		public ReactiveCommand<Unit, PaymentResult>ProcessPaymentCommand { get; }
	}
}
