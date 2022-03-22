using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_CS
{
    public class Product
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        List<Product> productList = new List<Product>();
        public void AddProduct()
        {
            Product p = new Product();

            p.Name = Name;
            p.Quantity = Quantity;
            p.Price = Price;

            productList.Add(p);
        }
    }
}
