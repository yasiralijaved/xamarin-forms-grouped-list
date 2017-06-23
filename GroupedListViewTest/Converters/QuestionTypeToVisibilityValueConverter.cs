using System;
using System.Globalization;
using Xamarin.Forms;

namespace GroupedListViewTest.Converters
{
    public class QuestionTypeToVisibilityValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((string)value).ToLower().Equals("type sun");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
