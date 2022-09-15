using System.Globalization;
using System.Linq;
using System.Windows.Controls;

namespace WpfClient.ValidationRules
{
    internal class ColorValidationRule : ValidationRule
    {
        private string[] validColors = new string[] { "red", "green", "blue" };

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string stringValue = (string)value;

            if (validColors.Contains(stringValue))
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, $"Kolor {stringValue} jest spoza słownika.");


        }
    }
}
