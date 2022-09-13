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
        }
    }
}
