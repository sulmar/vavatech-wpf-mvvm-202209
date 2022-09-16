using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MyContext
    {
        public IEnumerable<Customer> Customers { get; set; }

        private readonly string connectionString;

        public MyContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }

    public class DbCustomerRepository : ICustomerRepository
    {
        private readonly MyContext context;

        public DbCustomerRepository(MyContext context)
        {
            this.context = context;
        }

        public ICollection<Customer> Get()
        {
            return context.Customers.ToList();
        }
    }
}
