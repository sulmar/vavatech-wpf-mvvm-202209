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

        public string FirstName
        {
            get => firstName;
            set
            {
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

    }

    public enum SalaryKind
    {
        Low,
        Medium,
        High,
    }
}