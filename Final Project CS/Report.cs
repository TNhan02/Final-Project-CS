using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace Final_Project_CS
{
    public partial class Report : Form
    {
        string rootPath = @"C:\Users\Admin\source\repos\Final-Project-CS\Final Project CS\Transactions";
        string productPath = @"C:\Users\Admin\source\repos\Final-Project-CS\Final Project CS\Products.txt";
        public DataTable table = new DataTable();

        public Report()
        {
            InitializeComponent();

            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Buyer", typeof(string));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Item Amount", typeof(double));
            table.Columns.Add("Grand Total", typeof(double));
        }

        private void CalculateTotalCost()
        {
            if (table.Rows.Count == 0)
            {
                TotalCost.Text = "0";
                return;
            }
            else
            {
                double Total = 0;
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    Total += double.Parse(table.Rows[i]["Grand Total"].ToString());
                }
                TotalCost.Text = Total.ToString();
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string[] product = File.ReadAllLines(productPath);
            List<string[]> productPrice = new List<string[]>();
            foreach (string currentProduct in product)
            {
                string[] temp = currentProduct.Split('|');
                productPrice.Add(temp);
            }
            string[] paths = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);

            int price = 0;
            foreach (var filePath in paths)
            {
                string[] lines = File.ReadAllLines(filePath);
                string[] attributes = new string[5];
                string date = Path.GetFileName(filePath);
                date = date.Insert(2, "/");
                date = date.Insert(5, "/");
                date = date.Remove(10);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split('|');

                    foreach (var currentProduct in productPrice)
                    {
                        if (currentProduct[1] == values[1])
                        {
                            price = Convert.ToInt32(currentProduct[3]);
                            break;
                        }
                    }

                    for (int j = 0; j < values.Length; j++)
                    {
                        attributes[j + 1] = values[j].Trim();
                    }

                    attributes[0] = date;
                    attributes[4] = Convert.ToString(price * Convert.ToInt32(values[2]));


                    table.Rows.Add(attributes);

                    DataView dv = new DataView(table);
                    Transactions_Table.DataSource = dv;

                    CalculateTotalCost();
                }
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            DateTime StartDate = dateTimePicker1.Value;
            DateTime EndDate = dateTimePicker2.Value;
            dv.RowFilter = string.Format("Date >= #{0:MM/dd/yyyy}# AND Date <=#{1:MM/dd/yyyy}#", StartDate, EndDate);
            Transactions_Table.DataSource = dv;

            CalculateTotalCost();
        }

        private void mostSoldProducts_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.Sort = "Item Amount DESC";

            while (dv.Count > 10)
            {
                dv.Delete(dv.Count - 1);
            }
            Transactions_Table.DataSource = dv;

            CalculateTotalCost();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            while (Transactions_Table.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Transactions_Table.Rows)
                {
                    Transactions_Table.Rows.Remove(row);
                }
            }

            CalculateTotalCost();
        }
    }
}
