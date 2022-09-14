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

    }
}