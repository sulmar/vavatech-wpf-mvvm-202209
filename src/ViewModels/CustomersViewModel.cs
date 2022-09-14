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

        private Customer selected;
        public Customer Selected 
        { 
            get => selected;
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }

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
