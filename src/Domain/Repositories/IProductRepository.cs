using Domain.Models;

namespace Domain.Repositories
{
    public interface IProductRepository : IEntityRepository<Product>
    {
        ICollection<Product> GetByColor(string color);
    }


}
