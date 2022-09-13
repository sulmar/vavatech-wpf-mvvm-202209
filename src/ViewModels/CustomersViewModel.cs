using Domain.Models;
using Domain.Repositories;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        public ICollection<Customer> Customers { get; set; }

        public CustomersViewModel()
            : this(new FakeCustomerRepository())
        {

        }

        public CustomersViewModel(ICustomerRepository customerRepository)
        {
            Customers = customerRepository.Get();
        }

    }
}
