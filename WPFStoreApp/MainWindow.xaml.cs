using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public ObservableCollection<Product> Products { get; set; }
        public string SelectedBrand { get; set; }
        public string SelectedType {  get; set; }
        public string SelectedAll {  get; set; }

        private Product selectedProduct;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Image="Images/cola1L.jpg",
                    Name="CocaCola 1L",
                    Price=2.50,
                },
                new Product
                {
                    Image="Images/fanta1L.jpg",
                    Name="Fanta 1L",
                    Price=2.50,
                },
                 new Product
                {
                    Image="Images/cola0.5l.jpg",
                    Name="CocaCola 0.5L",
                    Price=1.50,
                },
                new Product
                {
                    Image="Images/sprite0.5L.jpg",
                    Name="Sprite 0.5L",
                    Price=1.50,
                },

                new Product
                {
                    Image="Images/fanta0.3L.jpg",
                    Name="Fanta 0.3L",
                    Price=1,
                },
                new Product
                {
                    Image="Images/sprite1L.jpg",
                    Name="Sprite 1L",
                    Price=2.50,
                },
                new Product
                {
                    Image="Images/fanta0.5L.jpg",
                    Name="Fanta 0.5L",
                    Price=1.50,
                },
                new Product
                {
                    Image="Images/cola0.3L.jpg",
                    Name="CocaCola 0.3L",
                    Price=1,
                },

                new Product
                {
                    Image="Images/sprite0.3L.jpg",
                    Name="Sprite 0.3L",
                    Price=1,
                },

                 new Product
                {
                    Image="Images/cola1LZero.jpg",
                    Name="CocaCola 1L",
                    Price=2.70,
                },
            };

            MyItemsControl.ItemsSource = Products;
            SelectedBrand = "Brand";
            SelectedType = "Type";
            SelectedAll = "All";
        }

        private void BrandButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                SelectedBrand = button.Content.ToString();
                FilterProductsBrands();
                ResetBrandButtonColors();
                button.Foreground = Brushes.Red;
            }
        }

        private void FilterProductsBrands()
        {
            if (SelectedBrand == "Brand")
            {
                MyItemsControl.ItemsSource = Products;
            }
            else
            {
                MyItemsControl.ItemsSource = Products.Where(p => p.Name.Contains(SelectedBrand));
            }
        }

        private void Type_Click(object sender, RoutedEventArgs e)
        {
            var button= sender as Button;
            if (button != null)
            {
                SelectedType = button.Content.ToString();
                FilterProductsType();
                ResetTypeButtonColors();
                button.Foreground = Brushes.Red;
            }
        }

        private void FilterProductsType()
        {
            if (SelectedType == "Type")
            {
                MyItemsControl.ItemsSource = Products;
            }
            else
            {
                MyItemsControl.ItemsSource = Products.Where(p => p.Name.Contains(SelectedType));
            }
        }


        private void ResetBrandButtonColors()
        {
            Cola.Foreground = Brushes.Gray;
            Fanta.Foreground = Brushes.Gray;
            Sprite.Foreground = Brushes.Gray;
            Cola1L.Foreground = Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Cola03L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
            Fanta03L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
            Sprite03L.Foreground = Brushes.Gray;
            All.Foreground = Brushes.Gray;
        }

        private void ResetTypeButtonColors()
        {
            Cola1L.Foreground = Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Cola03L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
            Fanta03L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
            Sprite03L.Foreground = Brushes.Gray;
            Cola.Foreground = Brushes.Gray;
            Fanta.Foreground = Brushes.Gray;
            Sprite.Foreground = Brushes.Gray;
            All.Foreground= Brushes.Gray;
        }


        private void All_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                SelectedAll = button.Content.ToString();
                FilterProductsAll();
                ResetAllButtonColors();
                button.Foreground = Brushes.OrangeRed;
            }
        }

        private void FilterProductsAll()
        {
            if (SelectedAll == "All")
            {
                MyItemsControl.ItemsSource = Products;
            }
            else
            {
                MyItemsControl.ItemsSource = Products.Where(p => p.Name.Contains(SelectedAll));
            }
        }

        private void ResetAllButtonColors()
        {
            Cola1L.Foreground = Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Cola03L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
            Fanta03L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
            Sprite03L.Foreground = Brushes.Gray;
            Cola.Foreground = Brushes.Gray;
            Fanta.Foreground = Brushes.Gray;
            Sprite.Foreground = Brushes.Gray;
        }


        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Search...")
            {
                textBox.Text = string.Empty;
            }
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search...";
            }
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = SearchBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var matchingProducts = Products.Where(p => p.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
                MyItemsControl.ItemsSource = matchingProducts;
            }
            else
            {
                MyItemsControl.ItemsSource = Products;
            }
        }

        private void EditButton1_Click(object sender, RoutedEventArgs e)
        {
            var window = new InfoProducts();
            window.InfoProduct = selectedProduct;
            window.ShowDialog();

        }
    }
}
