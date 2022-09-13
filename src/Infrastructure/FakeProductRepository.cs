using Bogus;
using Domain.Models;
using Domain.Repositories;

namespace Infrastructure
{
    public class FakeProductRepository : FakeEntityRepository<Product>, IProductRepository
    {
        public FakeProductRepository(Faker<Product> faker) : base(faker)
        {
        }

        public ICollection<Product> GetByColor(string color)
        {
            // Linq
            return entities.Where(x => x.Color == color).ToList();
        }
    }


}