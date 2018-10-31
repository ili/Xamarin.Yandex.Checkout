using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Yandex.Checkout.Demo.ViewModels;

namespace Xamarin.Yandex.Checkout.Demo.Views
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentView : ContentPageBase<PaymentViewModel>
	{
		public PaymentView()
		{
			InitializeComponent();
		}
	}
}