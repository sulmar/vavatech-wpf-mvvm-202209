using Bogus;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Fakers
{
    // PM> Install-Package Bogus
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Avatar, f => f.Person.Avatar);
            RuleFor(p => p.Phone, f => f.Phone.PhoneNumber());
            RuleFor(p => p.Height, f => f.Random.Byte(100));

            RuleFor(p => p.IsVat, f => f.Random.Bool(0.8f));
            Ignore(p => p.TaxNumber);

            Ignore(p => p.IsSelected);
            Ignore(p => p.SkillLevel);
        }
    }
}
