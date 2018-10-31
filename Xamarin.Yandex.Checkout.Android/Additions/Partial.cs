using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace RU.Yandex.Money.Android.Sdk.Utils
{
	partial class CheckoutConfirmationActivity
	{
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.yandex.money.android.sdk.utils']/class[@name='CheckoutConfirmationActivity']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "")]
		public unsafe void SetTitle (global::Java.Lang.ICharSequence p0)
		{
			const string __id = "setTitle.(Ljava/lang/CharSequence;)V";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}