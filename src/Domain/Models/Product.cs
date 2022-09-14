namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public const decimal LimitPrice = 500;
        public bool OverLimitPrice => Price > LimitPrice;
    }
}