using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Yandex.Checkout.Demo.Servicies
{
	public interface IPaymentProcessor
	{
		IObservable<PaymentResult> BeginPay(decimal amount);
	}

	public class PaymentResult
	{
		public PaymentResult(bool success, string message)
		{
			Success = success;
			Message = message;
		}
		public string Message { get; }
		public bool Success { get; }
	}
}
