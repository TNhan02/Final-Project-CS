using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Final_Project_CS
{
    public partial class CashRegister : Form
    {
        public List<Product> productList { get; set; }
        public CashRegister()
        {
            InitializeComponent();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //adding buyer information
            //and then transfer transaction information to the report folder
            string buyer = Buyer.ShowDialog("Buyer", "Asking Buyer Information");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ID = productSearch.Text;
            if (productList.Contains(p))
            {
                MessageBox.Show($"{p.ID} is available in our shop");
            }
            else
            {
                MessageBox.Show($"{p.ID} is not available in our shop");
            }
        }
    }
}
