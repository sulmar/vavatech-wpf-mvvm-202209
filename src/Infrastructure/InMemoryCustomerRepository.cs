using Domain.Models;
using Domain.Repositories;

namespace Infrastructure
{
    public class InMemoryCustomerRepository : ICustomerRepository
    {
        private readonly ICollection<Customer> customers;

        public InMemoryCustomerRepository()
        {
            customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Smith", Phone = "555-111-222", Avatar = "https://api.lorem.space/image/face?w=150&h=150" },
                new Customer { Id = 2, FirstName = "Ann", LastName = "Smith", Phone = "555-222-333", Avatar = "https://api.lorem.space/image/face?w=150&h=150" },
                new Customer { Id = 3, FirstName = "Bob", LastName = "Smith", Phone = "555-333-444", Avatar = "https://api.lorem.space/image/face?w=150&h=150" },
            };
        }

        public ICollection<Customer> Get()
        {
            return customers;
        }
    }
}