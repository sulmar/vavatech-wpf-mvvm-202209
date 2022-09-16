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
        private bool isConnected;

        public string SelectedView
        {
            get => selectedView;
            set
            {
                selectedView = value;
                OnPropertyChanged();
            }
        }

        private object selectedPage;
        public object SelectedPage
        {
            get => selectedPage;
            set
            {
                selectedPage = value;
                OnPropertyChanged();
            }
        }

        public bool IsConnected
        {
            get => isConnected; set
            {
                isConnected = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowPageCommand { get; private set; }
        
        private readonly INavigationService navigationService;

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            
            ShowPageCommand = new DelegateCommand<Type>(ShowPage);

            IsConnected = false;
        }

        // private void ShowView(string viewName) => SelectedView = $"{viewName}View.xaml";

        private void ShowPage(Type viewType) => navigationService.Navigate(viewType);

    }
}
