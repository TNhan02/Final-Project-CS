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
        public Report()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);

            foreach (var filePath in paths)
            {
                string[] lines = File.ReadAllLines(filePath);
                string[] values = lines.ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < lines.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                Transactions_Table.Rows.Add(row);
            }
        }

        private void SaleAmount_TextChanged(object sender, EventArgs e)
        {
            double Sale = 0;
            for (int i = 0; i < Transactions_Table.Rows.Count; i++)
            {
                try
                {
                    Sale += double.Parse(Transactions_Table.Rows[i].Cells[2].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                SaleAmount.Text = SaleAmount.ToString();
            }
        }

        private void TotalCost_TextChanged(object sender, EventArgs e)
        {
            double Total = 0;
            for (int i = 0; i < Transactions_Table.Rows.Count; i++)
            {
                try
                {
                    Total += double.Parse(Transactions_Table.Rows[i].Cells[3].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                TotalCost.Text = TotalCost.ToString();
            }
        }
    }
}
