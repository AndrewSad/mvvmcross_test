using System;
using System.Globalization;
using Foundation;
using MvvmCross.Platform.Converters;

namespace MSTest.iOS
{
	public class HtmlToStringValueConverter : MvxValueConverter<string, NSAttributedString>
	{
		protected override NSAttributedString Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			var attr = new NSAttributedStringDocumentAttributes();
			var nsError = new NSError();
			attr.DocumentType = NSDocumentType.HTML;

			//var label = parameter as UILabel;

			//nfloat red = 0.0f;
			//nfloat green = 0.0f;
			//nfloat blue = 0.0f;
			//nfloat alpha = 0.0f;
			//label.TextColor.GetRGBA(out red, out green, out blue, out alpha);

			//var stringWithFont = value + string.Format(
			//	"<style>body{{font-family: '{0}'; font-size:{1}px; color:rgb({2}, {3}, {4})}}</style>"
			//   , label.Font.Name
			//   , label.Font.PointSize
			//   , red * 255
			//   , green * 255
			//   , blue * 255);

			var htmlData = NSData.FromString(value, NSStringEncoding.UTF8);
			var attrStr = new NSAttributedString(htmlData, attr, ref nsError);
			return attrStr;
		}
	}
}
