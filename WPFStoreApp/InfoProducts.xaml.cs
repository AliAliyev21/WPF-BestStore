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
using System.Windows.Shapes;

namespace WPFStoreApp
{
    /// <summary>
    /// Interaction logic for InfoProducts.xaml
    /// </summary>
    public partial class InfoProducts : Window
    {
        public Product InfoProduct { get; set; }
        public InfoProducts()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
