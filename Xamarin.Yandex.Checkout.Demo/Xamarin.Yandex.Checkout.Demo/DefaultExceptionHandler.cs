using System;
using Xamarin.Forms;

namespace Xamarin.Yandex.Checkout.Demo
{
	public class DefaultExceptionHandler : IObserver<Exception>
	{
		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
			OnNext(error);
		}

		public void OnNext(Exception value)
		{
			Device.BeginInvokeOnMainThread(() =>
				Application.Current.MainPage
				.DisplayAlert("Oops!", value.Message, "OK"));
		}
	}
}