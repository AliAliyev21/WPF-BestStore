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

namespace WPFStoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();

            


        }




        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            Cola.Foreground = Brushes.Red;
        }

        private void Fanta_Click(object sender, RoutedEventArgs e)
        {
            Fanta.Foreground = Brushes.DarkOrange;
        }

        private void Sprite_Click(object sender, RoutedEventArgs e)
        {
            Sprite.Foreground = Brushes.Green;
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

        }

        private void All_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cola1L_Click(object sender, RoutedEventArgs e)
        {
            Cola1L.Foreground = Brushes.Red;
            Cola05L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
        }

        private void Cola05L_Click(object sender, RoutedEventArgs e)
        {
            Cola05L.Foreground = Brushes.Red;
            Cola1L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
        }

        private void Fanta1L_Click(object sender, RoutedEventArgs e)
        {
            Fanta1L.Foreground = Brushes.DarkOrange;
            Fanta05L.Foreground = Brushes.Gray;
            Cola1L.Foreground= Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
        }

        private void Fanta05L_Click(object sender, RoutedEventArgs e)
        {
            Fanta05L.Foreground= Brushes.DarkOrange;
            Fanta1L.Foreground = Brushes.Gray;
            Cola1L.Foreground = Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Sprite1L.Foreground = Brushes.Gray;
            Sprite05L.Foreground = Brushes.Gray;
        }

        private void Sprite1L_Click(object sender, RoutedEventArgs e)
        {
            Sprite1L.Foreground = Brushes.Green;
            Sprite05L.Foreground = Brushes.Gray;
            Cola1L.Foreground = Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
        }

        private void Sprite05L_Click(object sender, RoutedEventArgs e)
        {
            Sprite05L.Foreground = Brushes.Green;
            Sprite1L.Foreground = Brushes.Gray;
            Cola1L.Foreground = Brushes.Gray;
            Cola05L.Foreground = Brushes.Gray;
            Fanta1L.Foreground = Brushes.Gray;
            Fanta05L.Foreground = Brushes.Gray;
        }
    }
}
