using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project_CS
{
    public partial class Maintenance : Form
    {
        CashRegister cashForm = new CashRegister();
        Report reportForm = new Report();
        public List<Product> productList = new List<Product>();
        private const string productFile = "..//../Products.txt";

        public Maintenance()
        {
            InitializeComponent();
            //get the product list appear from here
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
            ProductList.Rows.Add(p.ID, p.Name, p.Price, p.Quantity);
            foreach(var products in productList)
            {
                File.AppendAllText(productFile, "ID: " + products.ID + "/"
                                              + "Name: " + products.Name + "/"
                                              + "Price: " + products.Price + "/"
                                              + "Quantity: " + products.Quantity + "\n");
            }
        }
    }
}
