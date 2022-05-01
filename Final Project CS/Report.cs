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


        public Report()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\tinua_h6hcjv0\source\repos\Final-Project-CS\Final Project CS\Transactions\AllTransactions.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)

            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                Transactions_Table.Rows.Add(row);

            }
        }
            
        private void Quantity_Qty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalCost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mostSoldProducts_Click(object sender, EventArgs e)

        {
            
        }
    }
}
