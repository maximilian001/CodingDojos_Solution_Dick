using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace CodingDojo3.converter
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string temp = (string)value;
            if (temp.Equals("Enabled"))
            {
                return new SolidColorBrush(Colors.Green);
            }
            else
            {
                return new SolidColorBrush(Colors.Red);

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
