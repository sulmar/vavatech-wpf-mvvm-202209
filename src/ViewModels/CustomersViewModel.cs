using Domain.Models;
using Domain.Repositories;
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

        public CustomersViewModel(ICustomerRepository customerRepository)
        {
            SkillLevelUpCommand = new DelegateCommand(SkillLevelUp);
            Customers = customerRepository.Get();
        }

        private void SkillLevelUp() => Selected.SkillLevel++;
    }
}
