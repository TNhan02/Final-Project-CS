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
    public partial class CashRegister : Form
    {
        private const string productFile = "..//../Products.txt";
        DataTable table = new DataTable();
        List<Product> productList = new List<Product>();
        static int count = 0;

        public CashRegister()
        {
            InitializeComponent();
            //add table's columns
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

            //add Datatable to List
            //for (int j = 0; j < table.Rows.Count; j++)
            //{
            //    Product p = new Product();
            //    p.ID = table.Rows[j]["ID"].ToString();
            //    p.Name = table.Rows[j]["Name"].ToString();
            //    p.Quantity = Convert.ToDouble(table.Rows[j]["Quantity"].ToString());
            //    p.Price = Convert.ToDouble(table.Rows[j]["Price"].ToString());
            //    p.Tax = Convert.ToDouble(table.Rows[j]["Tax"].ToString());
            //    productList.Add(p);
            //}
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


        private void buttonClick(Button b)
        {
            Product pd = new Product();
            pd = productList[b.TabIndex];

            if (b.Enabled)
            {
                count++;
                pd.Quantity = count;
                pd.Price *= count;
                pd.Tax = pd.Price * 0.01;
                ShoppingCart.Rows.Add(pd.ID, pd.Name, pd.Quantity, pd.Price, pd.Tax);
            }
        }
        //add products to shopping cart via clicking buttons
        private void ID_11_Click(object sender, EventArgs e)
        {
            buttonClick(ID_11);
        }

        private void ID_11P_Click(object sender, EventArgs e)
        {
            buttonClick(ID_11P);
        }

        private void ID_11PM_Click(object sender, EventArgs e)
        {
            buttonClick(ID_11PM);
        }

        private void ID_12_Click(object sender, EventArgs e)
        {
            buttonClick(ID_12);
        }

        private void ID_12P_Click(object sender, EventArgs e)
        {
            buttonClick(ID_12P);
        }

        private void ID_12PM_Click(object sender, EventArgs e)
        {
            buttonClick(ID_12PM);
        }

        private void ID_13_Click(object sender, EventArgs e)
        {
            buttonClick(ID_13);
        }

        private void ID_13P_Click(object sender, EventArgs e)
        {
            buttonClick(ID_13P);
        }

        private void ID_13PM_Click(object sender, EventArgs e)
        {
            buttonClick(ID_13PM);
        }

        private void ID_AP1_Click(object sender, EventArgs e)
        {
            buttonClick(ID_AP1);
        }

        private void ID_AP2_Click(object sender, EventArgs e)
        {
            buttonClick(ID_AP2);
        }

        private void ID_AP3_Click(object sender, EventArgs e)
        {
            buttonClick(ID_AP3);
        }

        private void ID_APP_Click(object sender, EventArgs e)
        {
            buttonClick(ID_APP);
        }

        private void ID_IA1_Click(object sender, EventArgs e)
        {
            buttonClick(ID_IA1);
        }

        private void ID_IA2_Click(object sender, EventArgs e)
        {
            buttonClick(ID_IA2);
        }

        private void ID_IM1_Click(object sender, EventArgs e)
        {
            buttonClick(ID_IM1);
        }

        private void ID_IPro_Click(object sender, EventArgs e)
        {
            buttonClick(ID_IPro);
        }

        private void ID_M1_Click(object sender, EventArgs e)
        {
            buttonClick(ID_M1);
        }

        private void ID_MP1_Click(object sender, EventArgs e)
        {
            buttonClick(ID_MP1);
        }

        private void ID_AW4_Click(object sender, EventArgs e)
        {
            buttonClick(ID_AW4);
        }

        private void ID_AW5_Click(object sender, EventArgs e)
        {
            buttonClick(ID_AW5);
        }
    }
}
