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
        //define paths
        string rootPath = @"C:\Users\Admin\source\repos\Final-Project-CS\Final Project CS\Transactions";
        string productPath = @"C:\Users\Admin\source\repos\Final-Project-CS\Final Project CS\Products.txt";
        string original_productPath = @"C:\Users\Admin\source\repos\Final-Project-CS\Final Project CS\Original Products.txt"; 
        public DataTable table = new DataTable();
        Top10 Top10Table = new Top10();

        public Report()
        {
            InitializeComponent();

            //add table's columns
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
            dv.RowFilter = string.Format("Date >= #{0:MM/dd/yyyy}# AND Date <= #{1:MM/dd/yyyy}#", StartDate, EndDate);
            Transactions_Table.DataSource = dv;

            CalculateTotalCost();
        }

        private void mostSoldProducts_Click(object sender, EventArgs e)
        {
            string[] original_storage = File.ReadAllLines(original_productPath);
            string[] current_storage = File.ReadAllLines(productPath);

            List<string[]> original_quantity = new List<string[]>();
            List<string[]> current_quantity = new List<string[]>();
            List<ProductSold> QuantitySoldList = new List<ProductSold>();

            //transfer 2 textfiles to 2 lists 
            foreach (var original_products in original_storage)
            {
                string[] temp1 = original_products.Split('|');
                original_quantity.Add(temp1);
            }
            foreach (var current_products in current_storage)
            {
                string[] temp2 = current_products.Split('|');
                current_quantity.Add(temp2);
            }

            //calculate quantity sold per product
            int quantity_sold = 0;
            for (int i = 0; i < original_quantity.Count; i++)
            {
                ProductSold ps = new ProductSold();
                for (int j = 0; j < current_quantity.Count; j++)
                {
                    quantity_sold = Convert.ToInt32(original_quantity[i][2]) - Convert.ToInt32(current_quantity[i][2]);

                    if (quantity_sold != 0)
                    {
                        ps.Name = current_quantity[i][1];
                        ps.Quantity_Sold = quantity_sold;

                        QuantitySoldList.Add(ps);
                        break;
                    }
                    else
                    {
                        quantity_sold = Convert.ToInt32(original_quantity[i+1][2]) - Convert.ToInt32(current_quantity[i+1][2]);

                        ps.Name = current_quantity[i+1][1];
                        ps.Quantity_Sold = quantity_sold;

                        QuantitySoldList.Add(ps);
                        break;
                    }
                }

                //sort QuantityList in descending order
                string[] row = new string[2];
                for (int l = 0; l < Top10Table.top10Table.Rows.Count; l++)
                {
                    row[0] = QuantitySoldList[l].Name;
                    row[1] = Convert.ToString(QuantitySoldList[l].Quantity_Sold);
                }
                Top10Table.top10Table.Rows.Add(row);

                //this.Top10Table.top10Table.Sort(this.Top10Table.top10Table.Columns["Quantity Sold"], ListSortDirection.Descending);
            }
            Top10Table.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            while (Transactions_Table.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in Transactions_Table.Rows)
                {
                    Transactions_Table.Rows.Remove(row);
                }
            }

            CalculateTotalCost();
        }
    }
}
