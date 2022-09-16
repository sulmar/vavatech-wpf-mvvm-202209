using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModels;
using vm = ViewModels;

namespace WpfClient.Views
{
    /// <summary>
    /// Interaction logic for CounterView.xaml
    /// </summary>
    public partial class CounterView : Page
    {
        public CounterView(CounterViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;

            /* 
              <Page.DataContext>
                 <vm:CounterViewModel />
              </Page.DataContext>
            */

            // this.DataContext = new vm.CounterViewModel();
        }

       

        /* 
         
        private int currentCount = 0; // model (stan)

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            currentCount++; // logika

            // CurrentCountTextBlock.Text = "Current count: " + currentCount;

             CurrentCountTextBlock.Text = currentCount;
             CurrentCountLabel.Content = currentCount;

            // Konkatenacja - dobra praktyka (interpolacja)
            CurrentCountTextBlock.Text = $"Current count: {currentCount}"; // // prezentacja
        }

        */
    }
}
