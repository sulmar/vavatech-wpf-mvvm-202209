using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fundamentals._07_Tasks
{
    /// <summary>
    /// Interaction logic for TaskView.xaml
    /// </summary>
    public partial class TaskView : Window
    {
        public TaskView()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           // var result = Calculate();

            //CalculateAsync()
            //    .ContinueWith(t => ResultTextBlock.Text = t.Result.ToString());

            var result = await CalculateAsync(100); // await - oczekiwać

            result = await CalculateAsync(result); // await - oczekiwać

            result = await CalculateAsync(result); // await - oczekiwać

            ResultTextBlock.Text = result.ToString();
        }


        private Task<decimal> CalculateAsync(decimal amount)
        {
            return Task.Run(() => Calculate(amount));
        }

        private decimal Calculate(decimal amount)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));

            return amount * 2;
        }

        

    }
}
