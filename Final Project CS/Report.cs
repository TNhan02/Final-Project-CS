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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void importButton_Click(object sender, EventArgs e)
        {
            {
                // get lines from the text file
                string[] lines = File.ReadAllLines(@"C:\Users\tinua_h6hcjv0\source\repos\Final-Project-CS\Final Project CS\Transactions");
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


                MessageBox.Show("OK");

            }

        }
        private void Report_Load(object sender, EventArgs e)
        {
    
        }

        private void Transactions_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                                    
        }
    }
}
