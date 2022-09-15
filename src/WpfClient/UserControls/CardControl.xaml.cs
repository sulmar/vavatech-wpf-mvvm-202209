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

namespace WpfClient.UserControls
{
    /// <summary>
    /// Interaction logic for CardControl.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public string Title { get; set; }

        public Brush TitleForeground { get; set; }

        public ImageSource Icon { get; set; }

        // Zwykła właściwość - nie można do niej zastosować {Binding}
        // public int Quantity { get; set; }
        
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        // Właściwość zależna - można do niej zastosować {Binding}

        // Using a DependencyProperty as the backing store for Quantity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(CardControl), new PropertyMetadata(0));


        public CardControl()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
