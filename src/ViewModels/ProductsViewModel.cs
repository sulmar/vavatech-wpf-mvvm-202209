using Domain.Models;
using Domain.Repositories;
using Infrastructure;
using Infrastructure.Fakers;

namespace ViewModels
{
    public class ProductsViewModel : EntitiesViewModel<Product>
    {

        public ProductsViewModel()
            : this(new FakeProductRepository(new ProductFaker()))
        {

        }

        public ProductsViewModel(IProductRepository entityRepository) : base(entityRepository)
        {
        }
    }
}
