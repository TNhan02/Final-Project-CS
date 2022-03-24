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
        public List<Product> productList = new List<Product>();
        DataSet ds = null;

        public Maintenance()
        {
            InitializeComponent();
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
            ProductList.Rows.Add(p.ID, p.Name, p.Price, p.Quantity);
        }

        private void addPID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
