namespace Domain.Models
{

    public class Customer : Base 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }

        //public string FullName 
        //{
        //    get
        //    {
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        // public string FullName => $"{FirstName} {LastName}";

        //public override string ToString()
        //{
        //    return FullName;
        //}

      //  public override string ToString() => FullName;
        
    }
}