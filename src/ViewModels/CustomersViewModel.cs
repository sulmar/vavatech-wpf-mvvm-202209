using Domain.Models;
using Domain.Repositories;
using Infrastructure;
using System.Windows.Input;

namespace ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        public ICollection<Customer> Customers
        {
            get => customers;
            set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        private Customer selected;
        private ICollection<Customer> customers;
        private bool isBusy;

        public Customer Selected
        {
            get => selected;
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get => isBusy; set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public ICommand SkillLevelUpCommand { get; private set; }
        public ICommand LoadCommand { get; private set; }

        private readonly ICustomerRepository customerRepository;

        public CustomersViewModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

            SkillLevelUpCommand = new DelegateCommand(SkillLevelUp);
            LoadCommand = new DelegateCommand(async () => await LoadAsync());
        }

        private async Task LoadAsync()
        {
            IsBusy = true;

            Customers = await customerRepository.GetAsync();

            IsBusy = false;
        }

        private void SkillLevelUp() => Selected.SkillLevel++;
    }
}
