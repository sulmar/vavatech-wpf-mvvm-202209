using Domain.Models;
using Domain.Models.SearchCriterias;
using Domain.Repositories;
using Infrastructure;
using Infrastructure.Fakers;
using System.Windows.Input;

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

        public ProductSearchCriteria SearchCriteria { get; set; }

        public ICommand SearchCommand { get; private set; }

        public ProductsViewModel()
            : this(new FakeProductRepository(new ProductFaker()))
        {

        }

        private IProductRepository productRepository => (IProductRepository) entityRepository;

        public ProductsViewModel(IProductRepository entityRepository) : base(entityRepository)
        {
            SearchCriteria = new ProductSearchCriteria();

            SearchCommand = new DelegateCommand(Search);
        }

        private void Search()
        {
            Entities = productRepository.Get(SearchCriteria);
        }
    }
}
