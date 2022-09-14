using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfClient.Converters
{
    public class BooleanToBrushConverter : IValueConverter
    {
        public Color TrueValue { get; set; } = Colors.Green;
        public Color FalseValue { get; set; } = Colors.Red;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool boolValue = (bool)value;

            Color color = boolValue ? TrueValue : FalseValue;

            var brush = new SolidColorBrush(color);

            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
