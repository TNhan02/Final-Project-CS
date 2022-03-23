using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_CS
{
    public partial class Maintenance : Form
    {
        CashRegister cashForm = new CashRegister();
        Report reportForm = new Report();
        public List<Product> productList { get; set; }

        public Maintenance()
        {
            productList = GetProducts();
            InitializeComponent();
        }
        private List<Product> GetProducts()
        {
            //var list = new List<Product>();
            productList.Add(new Product() { ID = "IP11", Name = "Iphone 11", Price = 600, Quantity = 100 });
            productList.Add(new Product() { ID = "IP11P", Name = "Iphone 11 Pro", Price = 650, Quantity = 100 });
            productList.Add(new Product() { ID = "IP11PM", Name = "Iphone 11 Pro Max", Price = 750, Quantity = 100 });
            productList.Add(new Product() { ID ="IP12", Name = "Iphone 12", Price = 1000, Quantity = 100 });
            productList.Add(new Product() { ID = "IP12P", Name = "Iphone 12 Pro", Price = 1100, Quantity = 100 });
            productList.Add(new Product() { ID = "IP12PM", Name = "Iphone 12 Pro Max", Price = 1250, Quantity = 100 });
            productList.Add(new Product() { ID = "IP13", Name = "Iphone 13", Price = 800, Quantity = 100 });
            productList.Add(new Product() { ID = "IP13P", Name  = "Iphone 13 Pro", Price = 950, Quantity = 100 });
            productList.Add(new Product() { ID = "IP13PM", Name = "Iphone 13 Pro Max", Price = 1285, Quantity = 100 });
            productList.Add(new Product() { ID = "W5", Name = "Apple Watch series 5", Price = 400, Quantity = 100 });
            productList.Add(new Product() { ID = "W6", Name = "Apple Watch series 6", Price = 490, Quantity = 100 });
            productList.Add(new Product() { ID = "W7", Name = "Apple Watch series 7", Price = 600, Quantity = 100 });
            productList.Add(new Product() { ID = "IM1", Name = "Ipad M1 2020", Price = 765, Quantity = 100 });
            productList.Add(new Product() { ID = "M1", Name = "Macbook M1 2022", Price = 1000, Quantity = 100 });
            productList.Add(new Product() { ID = "MPM1", Name = "Macbook Pro M1 2022", Price = 1150, Quantity = 100 });
            return productList;
        }
        private void Maintenance_Load(object sender, EventArgs e)
        {
            var products = this.productList;

            ProductList.DataSource = products;
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            cashForm.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ID = addPID.Text;
            p.Name = addPName.Text;
            p.Price = Convert.ToDouble(addPPrice.Text);
            p.Quantity = Convert.ToDouble(addPQuantity.Text);

            productList.Add(p);
        }
    }
}
