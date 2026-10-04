using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HW14
{
    public enum ProductCategory
    {
        Еда,
        БытоваяТехника,
        БытоваяХимия,
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, double price, string image, ProductCategory category)
        {
            Name = name;
            Price = price;
            Image = image;
            Category = category;
        }

    }
}
