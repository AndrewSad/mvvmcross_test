using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace MCTest.Core
{
	public class LongToDateStringValueConverter : MvxValueConverter<long, string>
	{
		protected override string Convert(long value, Type targetType, object parameter, CultureInfo culture)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return epoch.AddSeconds(value).ToString("g");

		}
	}
}
