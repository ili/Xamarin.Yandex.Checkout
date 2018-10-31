using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Yandex.Money.Api.Net;
using Java.Lang;

namespace Com.Yandex.Money.Api.Model
{
	partial class AccountStatus
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class AccountType
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class AllowedMoneySource
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class CardBrand
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class Error
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class PayeeIdentifierType
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class Operation
	{
		partial class AvailableOperation
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}

		partial class Direction
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}

		partial class Type
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}

	partial class SimpleStatus
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}

	partial class OperationStatus
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}
}

namespace Com.Yandex.Money.Api.Model.Showcase
{
	partial class AmountType
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}
}

namespace Com.Yandex.Money.Api.Net
{
	partial class BaseApiRequest
	{
		//public abstract Java.Lang.Object Parse(IHttpClientResponse response);
	}
}

namespace Com.Yandex.Money.Api.Time
{
	partial class DateTime
	{
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object other) => CompareTo((DateTime)other);
	}

	partial class YearMonth
	{
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object other) => CompareTo((YearMonth)other);
	}
}

namespace Com.Yandex.Money.Api.Methods.Payment
{
	partial class BaseProcessPayment
	{
		partial class Status
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}

	partial class BaseRequestPayment
	{
		partial class Status
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}

	partial class ProcessPayment
	{
		partial class TestResult
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}

		partial class Builder
		{
			public override BaseProcessPayment CreateInstance() => Create();
		}
	}

	partial class RequestPayment
	{
		partial class TestResult
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}

		partial class Builder
		{
			public override BaseRequestPayment CreateInstance() => Create();
		}
	}

	partial class RequestExternalPayment
	{
		partial class Builder
		{
			public override BaseRequestPayment CreateInstance() => Create();
		}
	}

	partial class ProcessExternalPayment
	{
		partial class Builder
		{
			public override BaseProcessPayment CreateInstance() => Create();
		}
	}
}

namespace Com.Yandex.Money.Api.Methods.Wallet
{
	partial class OperationHistory
	{
		partial class FilterType
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}
}

namespace Com.Yandex.Money.Api.Model.Showcase.Components
{
	partial class Component
	{
		partial class Type
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}

	partial class ParameterAutoFill
	{
		Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
	}
}

namespace Com.Yandex.Money.Api.Model.Showcase
{
	partial class ShowcaseReference
	{
		partial class Format
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}

	partial class Showcase
	{
		//partial class Request
		//{
		//	//public override Java.Lang.Object Parse(IHttpClientResponse response) => Parse(response);
		//}
	}
}

namespace Com.Yandex.Money.Api.Model.Showcase.Components.Containers
{
	partial class Group
	{
		partial class Layout
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}
}

namespace Com.Yandex.Money.Api.Model.Showcase.Components.Uicontrols
{
	partial class Text
	{
		partial class Keyboard
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}
	}

	partial class Select
	{
		partial class Style
		{
			Java.Lang.Object[] Util.Enums.IWithCode.GetValues() => GetValues().Cast<Java.Lang.Object>().ToArray();
		}

		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}

	partial class Checkbox
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}

	partial class TextArea
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}

	partial class Submit
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}

	partial class Number
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}

	partial class Date
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}
}

namespace Com.Yandex.Money.Api.Model.Showcase.Components.Containers
{
	partial class Group
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}

	partial class Paragraph
	{
		partial class Builder
		{
			public override Component CreateInstance() => Create();
		}
	}
}