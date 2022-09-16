using Domain.Models;
using Domain.Repositories;

namespace ViewModels
{
    public class MapCustomersViewModel : BaseViewModel
    {
        public ICollection<Customer> Customers { get; set; }

        private readonly ICustomerRepository customerRepository;

        public MapCustomersViewModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

            Customers = customerRepository.Get();
        }
    }
}
