using Bogus;
using Domain.Models;

namespace Infrastructure.Fakers
{
    public class ProductFaker : Faker<Product>
    {
        public ProductFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Commerce.ProductName());
            RuleFor(p => p.Description, f => f.Commerce.ProductDescription());
            RuleFor(p => p.Photo, f => "https://api.lorem.space/image/book?w=150&h=220&hash=8B7BCDC2");
            // RuleFor(p => p.Price, f => Math.Round(f.Random.Decimal(1, 1000),2));

            RuleFor(p => p.Color, f => f.Commerce.Color());
            RuleFor(p => p.Price, f => decimal.Parse( f.Commerce.Price()));
        }
    }
}
