using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private string selectedView;

        public string SelectedView
        {
            get => selectedView; 
            set
            {
                selectedView = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowProductsCommand { get; private set; }
        public ICommand ShowCustomersCommand { get; private set; }

        public ShellViewModel()
        {
            ShowProductsCommand = new DelegateCommand(ShowProducts);
            ShowCustomersCommand = new DelegateCommand(ShowCustomers);

            ShowCustomers();
        }

        private void ShowProducts()
        {
            SelectedView = "ProductsView.xaml";
        }

        private void ShowCustomers()
        {
            SelectedView = "CustomersView.xaml";
        }
    }
}
