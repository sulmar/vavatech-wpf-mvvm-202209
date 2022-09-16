using Bogus;
using Domain.Models;
using Domain.Repositories;
using Infrastructure.Fakers;

namespace Infrastructure
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        private readonly ICollection<Customer> customers;

        public FakeCustomerRepository(Faker<Customer> faker)
        {
            customers = faker.Generate(100);
        }

        public ICollection<Customer> Get()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));

            return customers;
        }

        public Task<ICollection<Customer>> GetAsync()
        {
            return Task.Run(() => Get());
        }
    }


}