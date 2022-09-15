using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfClient.Converters
{
    internal class PercentageToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double doubleValue = (double)value;

            Color color = CreateColor(doubleValue);

            return new SolidColorBrush(color);
        }

        private Color CreateColor(double percentage) => percentage switch
        {
            < 0.3 => Colors.DarkRed,
            >= 0.3 and < 0.5 => Colors.DarkOrange,
            >= 0.5 and < 0.7 => Colors.Orange,
            >= 0.7 and < 1 => Colors.Green,
            1 => Colors.DarkGreen
        };

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
