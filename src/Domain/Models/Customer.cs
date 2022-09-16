using System.Collections;
using System.ComponentModel;
using System.Security.Principal;

namespace Domain.Models
{

    
    public class Customer : BaseEntity 
    {
        private string firstName;
        private string lastName;
        private string phone;
        private byte height;
        private byte skillLevel;
        private bool isVat;

        private const int MinimumLength = 3;
        private const int MaximumLength = 20;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Pole nie może być puste.");

                //if (value.Length >= MinimumLength & value.Length <= MaximumLength)
                //    throw new ArgumentException($"Długość imienia powinna zawierać się pomiędzy {MinimumLength} a {MaximumLength} znaków");

                firstName = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Pole nie może być puste.");

                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Avatar { get; set; }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged();
            }
        }

        public byte Height
        {
            get => height; set
            {
                
                height = value;

                ValidateHeight();

                OnPropertyChanged();
            }
        }

        public bool IsSelected { get; set; }

        public bool IsVat
        {
            get => isVat; set
            {
                isVat = value;
                OnPropertyChanged();
            }
        }
        public string TaxNumber { get; set; }


        public byte SkillLevel
        {
            get => skillLevel; set
            {
                skillLevel = value;
                OnPropertyChanged();
            }
        }

        //public string FullName
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        public string FullName => $"{FirstName} {LastName}";

        //public override string ToString()
        //{
        //    return FullName;
        //}

        //  public override string ToString() => FullName;

        public decimal Salary { get; set; }

        //public SalaryKind SalaryKind
        //{
        //    get
        //    {
        //        if (Salary < 5000)
        //            return SalaryKind.Low;
        //        else if (Salary < 7000)
        //            return SalaryKind.Medium;
        //        else
        //            return SalaryKind.High;
        //    }
        //}

        // pattern-matching
        // https://docs.microsoft.com/pl-pl/dotnet/csharp/fundamentals/functional/pattern-matching
        public SalaryKind SalaryKind => Salary switch
        {
            < 5000 => SalaryKind.Low,
            > 7000 => SalaryKind.Medium,
            _ => SalaryKind.High
        };

        private void ValidateHeight()
        {
            if (Height < 100 || Height > 250)
            {
                AddError(nameof(Height), $"Wzrost musi być pomiędzy 100 a 250 cm");
            }
        }


    }

    public enum SalaryKind
    {
        Low,
        Medium,
        High,
    }
}