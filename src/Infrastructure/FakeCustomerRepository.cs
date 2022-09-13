using Bogus;
using Domain.Models;
using Domain.Repositories;
using Infrastructure.Fakers;

namespace Infrastructure
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        private readonly ICollection<Customer> customers;

        public FakeCustomerRepository()
            : this(new CustomerFaker())
        {
        }
        
        public FakeCustomerRepository(Faker<Customer> faker)
        {
            customers = faker.Generate(100);
        }

        public ICollection<Customer> Get()
        {
            return customers;
        }
    }
}