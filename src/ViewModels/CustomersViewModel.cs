using Domain.Models;
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
        {
            Customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Smith", Phone = "555-111-222", Avatar = "https://api.lorem.space/image/face?w=150&h=150" },
                new Customer { Id = 2, FirstName = "Ann", LastName = "Smith", Phone = "555-222-333", Avatar = "https://api.lorem.space/image/face?w=150&h=150" },
                new Customer { Id = 3, FirstName = "Bob", LastName = "Smith", Phone = "555-333-444", Avatar = "https://api.lorem.space/image/face?w=150&h=150" },
            };
        }

    }
}
