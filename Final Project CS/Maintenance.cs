﻿using System;
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
            //get the product list appearead from here
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

                ProductList.Rows.Add(row);
            }
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
            //add product's information
            int count = 0;
            Product p = new Product();
            p.ID = addPID.Text;
            p.Name = addPName.Text;
            p.Price = Convert.ToDouble(addPPrice.Text);
            p.Quantity = Convert.ToDouble(addPQuantity.Text);

            //add to productList
            productList.Add(p);
            ProductList.Rows.Add(p.ID, p.Name, p.Price, p.Quantity);
            count++;
            //save products' information to Products.txt
            for(int i = 0; i < count; i++)
            {
                File.AppendAllText(productFile, p.ID + " | "
                                              + p.Name + " | "
                                              + p.Price + " | "
                                              + p.Quantity + "\n");
            }
        }
        private void searchPID_TextChanged(object sender, EventArgs e)
        {
            (ProductList.DataSource as DataTable).DefaultView.RowFilter
                = string.Format("PID like '%" + searchPID.Text + "%'");
        }
    }
}
