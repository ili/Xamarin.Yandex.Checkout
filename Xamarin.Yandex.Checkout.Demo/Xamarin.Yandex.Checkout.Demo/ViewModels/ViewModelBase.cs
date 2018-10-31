using ReactiveUI;
using Splat;

namespace Xamarin.Yandex.Checkout.Demo.ViewModels
{
	public class ViewModelBase : ReactiveObject, IRoutableViewModel, ISupportsActivation
	{
		protected string _urlPathSegment = string.Empty;
		public string UrlPathSegment => _urlPathSegment ?? (_urlPathSegment = GetType().FullName);

		public IScreen HostScreen
		{
			get;
			protected set;
		}

		public ViewModelActivator Activator { get; } = new ViewModelActivator();

		public ViewModelBase(IScreen hostScreen = null)
		{
			HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
		}
	}
}
