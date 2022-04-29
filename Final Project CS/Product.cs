using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Final_Project_CS
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }


        public List<Product> productList = new List<Product>();
        public void AddProduct()
        {
            Product p = new Product();

            p.ID = ID;
            p.Name = Name;
            p.Quantity = Quantity;
            p.Price = Price;

            productList.Add(p);
        }
    }
}
