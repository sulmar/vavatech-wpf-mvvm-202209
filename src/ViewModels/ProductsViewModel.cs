using Domain.Models;
using Domain.Repositories;
using Infrastructure;
using Infrastructure.Fakers;

namespace ViewModels
{
    public class ProductsViewModel : EntitiesViewModel<Product>
    {
        private Product selected;

        public Product Selected
        {
            get => selected; set
            {
                selected = value;
                OnPropertyChanged();
            }
        }

        public ProductsViewModel()
            : this(new FakeProductRepository(new ProductFaker()))
        {

        }

        public ProductsViewModel(IProductRepository entityRepository) : base(entityRepository)
        {
        }
    }
}
