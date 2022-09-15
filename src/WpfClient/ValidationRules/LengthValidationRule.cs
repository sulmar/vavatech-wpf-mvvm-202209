using System.Globalization;
using System.Windows.Controls;

namespace WpfClient.ValidationRules
{
    internal class LengthValidationRule : ValidationRule
    {
        public int MinimumLength { get; set; }
        public int MaximumLength { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string stringValue = (string)value;

            if (stringValue.Length >= MinimumLength && stringValue.Length <= MaximumLength)
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, $"Długość tekstu powinna zawierać się pomiędzy {MinimumLength} a {MaximumLength} znaków");
        }
    }

}
