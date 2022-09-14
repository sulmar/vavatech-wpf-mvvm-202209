using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfClient.Converters
{
    public class BooleanToStringConverter : IValueConverter
    {
        public string TrueValue { get; set; } = bool.TrueString;
        public string FalseValue { get; set; } = bool.FalseString;
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool boolValue = (bool)value;

            string result = boolValue ? TrueValue : FalseValue;

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
