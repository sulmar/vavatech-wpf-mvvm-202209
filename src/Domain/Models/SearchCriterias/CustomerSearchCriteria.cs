namespace Domain.Models.SearchCriterias
{
    public class CustomerSearchCriteria : SearchCriteria
    {
        public decimal? FromSalary { get; set; }
        public decimal? ToSalary { get; set; }

    }
}