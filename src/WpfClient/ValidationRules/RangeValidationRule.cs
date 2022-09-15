using System.Globalization;
using System.Windows.Controls;

namespace WpfClient.ValidationRules
{
    public class RangeValidationRule : ValidationRule
    {
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var correctType = decimal.TryParse((string)value, out var decimalValue);

            if (correctType && decimalValue >= Minimum && decimalValue <= Maximum)
            {
                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, $"Field should be between {Minimum} and {Maximum}");
        }
    }

}
