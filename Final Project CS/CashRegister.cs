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
using System.IO;

namespace Final_Project_CS
{
    public partial class CashRegister : Form
    {
        private const string productFile = "..//../Products.txt";
        DataTable table = new DataTable();
        List<Product> productList = new List<Product>();

        public CashRegister()
        {
            InitializeComponent();
            //create table's columns
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Quantity", typeof(double));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("Tax", typeof(double));

            //get the product list appeared from here
            string[] lines = File.ReadAllLines(productFile);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                table.Rows.Add(row);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //adding buyer information
            //and then transfer transaction information to the report folder
            string buyer = Buyer.ShowDialog("Buyer", "Asking Buyer Information");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Product ps = new Product();
            ps.ID = productSearch.Text;
            DataRow[] findID = table.Select("ID = '" + ps.ID + "'");

            if ((findID.Length != 0) && (ps.Quantity >= 0))
            {
                MessageBox.Show($"{ps.ID} is available in shop");
            }
            else
            {
                MessageBox.Show($"{ps.ID} is not available in shop");
            }
        }



        //add products to shopping cart via clicking buttons
        private void ID_11_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[0].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_11P_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[1].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_11PM_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[2].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_12_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[3].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_12P_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[4].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_12PM_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[5].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_13_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[6].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_13P_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[7].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_13PM_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[8].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_AP1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[9].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_AP2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[10].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_AP3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[11].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_APP_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[12].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_IA1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[13].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_IA2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[14].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_IM1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[15].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_IPro_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[16].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_M1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[17].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_MP1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[18].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_AW4_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[19].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }

        private void ID_AW5_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(productFile);
            string[] value;

            value = lines[20].ToString().Split('|');
            string[] row = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                row[i] = value[i].Trim();
            }

            ShoppingCart.Rows.Add(row);
        }
    }
}
