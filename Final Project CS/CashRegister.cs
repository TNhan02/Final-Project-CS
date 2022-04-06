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
        string[] lines = File.ReadAllLines(productFile);
        DataTable table = new DataTable();

        public CashRegister()
        {
            InitializeComponent();
            //create table's columns
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("Quantity", typeof(double));

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

            if (findID.Length != 0)
            {
                MessageBox.Show($"{ps.ID} is available in shop");
            }
            else
            {
                MessageBox.Show($"{ps.ID} is not available in shop");
            }
        }
    }
}
