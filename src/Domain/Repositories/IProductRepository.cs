using Domain.Models;
using Domain.Models.SearchCriterias;

namespace Domain.Repositories
{
    public interface IProductRepository : IEntityRepository<Product>
    {
        ICollection<Product> GetByColor(string color);

        // zła praktyka
        // ICollection<Product> Get(string name, string description, string color, decimal? fromPrice, decimal? toPrice);

        // dobra praktyka
        ICollection<Product> Get(ProductSearchCriteria searchCriteria);

    }


}
