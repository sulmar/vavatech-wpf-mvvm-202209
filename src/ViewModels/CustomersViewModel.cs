using Domain.Models;
using Domain.Repositories;
using Infrastructure;
using Infrastructure.Fakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ICommand SkillLevelUpCommand { get; private set; }

        public CustomersViewModel()
            : this(new FakeCustomerRepository(new CustomerFaker()))
        {
        }

        //public CustomersViewModel()
        //    : this(new DbCustomerRepository(new MyContext("server=local,database=mydb")))
        //{
        //}

        public CustomersViewModel(ICustomerRepository customerRepository)
        {
            SkillLevelUpCommand = new DelegateCommand(SkillLevelUp);
            Customers = customerRepository.Get();
        }

        private void SkillLevelUp() => Selected.SkillLevel++;
    }
}
