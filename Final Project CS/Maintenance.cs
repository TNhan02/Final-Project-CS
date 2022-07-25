using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Final_Project_CS
{
    public partial class Maintenance : Form
    {
        CashRegister cashForm = new CashRegister();
        Report reportForm = new Report();
        public const string productFile = "..//../Products.txt";
        public DataTable table = new DataTable();
        public List<Product> productList = new List<Product>();
        public Maintenance()
        {
            InitializeComponent();
            //create table's columns and datatable for Product_List
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Quantity", typeof(double));
            table.Columns.Add("Price", typeof(double));
            Product_List.DataSource = table;


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

            cashForm.Checkout_ButtonWasClicked += new CashRegister.ClickButton(Update);
        }
        public void Update()
        {
            do
            {
                foreach (DataGridViewRow row in Product_List.Rows)
                {
                    try
                    {
                        Product_List.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (Product_List.Rows.Count > 0);

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
        

        private void cashButton_Click(object sender, EventArgs e)
        {
            if (cashForm.IsDisposed == true)
            {
                cashForm = new CashRegister();
            }
            cashForm.Show();
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            if (reportForm.IsDisposed == true)
            {
                reportForm = new Report();
            }
            reportForm.Show();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            //add product's information
            int count = 0;
            Product p = new Product();
            p.ID = addPID.Text;
            p.Name = addPName.Text;
            p.Quantity = Convert.ToDouble(addPQuantity.Text);
            p.Price = Convert.ToDouble(addPPrice.Text);

            //add to productList
            p.AddProduct();
            table.Rows.Add(p.ID, p.Name, p.Quantity, p.Price);
            count++;
            //save product's information to Products.txt
            for (int i = 0; i < count; i++)
            {
                File.AppendAllText(productFile, p.ID + " | "
                                              + p.Name + " | "
                                              + p.Quantity + " | "
                                              + p.Price + "\n");
            }
        }

        private void searchPID_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("ID + NAME LIKE '%{0}%'", searchPID.Text);
            Product_List.DataSource = dv;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
