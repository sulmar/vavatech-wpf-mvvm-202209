namespace Domain.Models.SearchCriterias
{

    public class ProductSearchCriteria : SearchCriteria
    {
        public string Description { get; set; }
        public string Color { get; set; }
        public decimal? FromPrice { get; set; }
        public decimal? ToPrice { get; set; }
    }
}