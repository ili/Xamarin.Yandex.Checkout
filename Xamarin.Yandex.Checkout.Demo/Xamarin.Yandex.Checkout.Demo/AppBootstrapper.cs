using System;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace Xamarin.Yandex.Checkout.Demo
{
	public class AppBootstrapper : ReactiveObject, IScreen
	{
		public RoutingState Router
		{
			get;
		}

		public AppBootstrapper()
		{
			RxApp.DefaultExceptionHandler = new DefaultExceptionHandler();

			Router = new RoutingState();

			Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

			Locator.CurrentMutable.RegisterViewsForViewModels(GetType().Assembly);
			
			ToMainPage();
		}

		private void ToMainPage()
		{
			Router
				.NavigateAndReset
				.Execute(new ViewModels.PaymentViewModel())
				.Subscribe();
		}

		public Page MainPage()
		{
			// NB: This returns the opening page that the platform-specific
			// boilerplate code will look for. It will know to find us because
			// we've registered our AppBootstrappScreen.
			return new RoutedViewHost();
		}
	}
}
