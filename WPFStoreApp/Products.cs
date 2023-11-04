using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace WPFStoreApp
{
    public class Products
    {
        public string Name {  get; set; }
        public double Price {  get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }

        public Products(Image image,string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
            Image = image;
        }
    }

    public class Cola : Products
    {
        public Cola(Image image, string name, double price, string description)
            : base(image ,name, price, description)
        { }
    }

    public class Fanta : Products
    {
        public Fanta(Image image, string name, double price, string description)
            : base(image, name, price, description)
        { }
    }

    public class Sprite : Products
    {
        public Sprite(Image image, string name, double price, string description)
        : base(image, name, price, description)
        { }
    }
}
