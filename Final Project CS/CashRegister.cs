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
    public partial class CashRegister : Form
    {
        public const string productFile = "..//../Products.txt";
        DataTable table = new DataTable();
        List<Product> productList = new List<Product>();

        public delegate void ClickButton();
        public event ClickButton Checkout_ButtonWasClicked;

        public CashRegister()
        {
            InitializeComponent();
            //create table's columns
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Quantity", typeof(double));
            table.Columns.Add("Price", typeof(double));

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
            for (int j = 0; j < table.Rows.Count; j++)
            {
                Product p = new Product();
                p.ID = table.Rows[j]["ID"].ToString();
                p.Name = table.Rows[j]["Name"].ToString();
                p.Quantity = Convert.ToDouble(table.Rows[j]["Quantity"].ToString());
                p.Price = Convert.ToDouble(table.Rows[j]["Price"].ToString());
                productList.Add(p);
            }
        }


        public void checkoutButton_Click(object sender, EventArgs e)
        {
            //adding buyer information
            string buyer = Buyer.ShowDialog("Buyer", "Asking Buyer Information");
            Checkout_ButtonWasClicked();

            //create a text file for a transaction
            string transaction = @"C:\Users\Admin\source\repos\Final-Project-CS\Final Project CS\Transactions";
            string date_ = string.Format(DateTime.Now.ToString("yyyyMMdd-HHmmss"));
            string fileName = date_;
            string path = Path.Combine(transaction, fileName);

            File.AppendAllText(path , totalPay.Text + "\n");
            for (int i = 0; i < ShoppingCart.Rows.Count; i++)
            {
                File.AppendAllText(path, buyer + " | " + ShoppingCart.Rows[i].Cells[1].Value + " | " + ShoppingCart.Rows[i].Cells[2].Value + "\n");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Product ps = new Product();
            ps.ID = productSearch.Text;
            DataRow[] findID = table.Select("ID = '" + ps.ID + "'");

            if ((findID.Length != 0) && (ps.Quantity > 0))
            {
                MessageBox.Show($"{ps.ID} {ps.Name} {ps.Quantity} {ps.Price}");
            }
            else if (ps.Quantity == 0)
            {
                MessageBox.Show($"{ps.ID} out of stock");
            }
            else
            {
                MessageBox.Show($"{ps.ID} is not available in shop");
            }
        }

        //update quantity in the product list
        public void UpdateQTy(string filename, Button b)
        {
            Product pro = new Product();

            if (b.Enabled)
            {
                for(int i = 0; i < ShoppingCart.Rows.Count; i++)
                {
                    double initialQTY = Convert.ToDouble(table.Rows[b.TabIndex]["Quantity"].ToString());
                    pro.ID = productList[b.TabIndex].ID;
                    pro.Name = productList[b.TabIndex].Name;
                    pro.Quantity = initialQTY - productList[b.TabIndex].Quantity;
                    pro.Price = productList[b.TabIndex].Price;

                    string[] arr = File.ReadAllLines(productFile);
                    arr[b.TabIndex] = Convert.ToString($"{pro.ID} | {pro.Name} | {pro.Quantity} | {pro.Price}");
                    File.WriteAllLines(productFile, arr);
                }
            }
        }
        //inserting product's info to Shopping Cart
        //add Total Amount to pay the bill
        private void buttonClick(Button b)
        {
            Product pd = new Product();
            pd = productList[b.TabIndex];
            bool Found = false;

            if ((b.Enabled) & (pd.Quantity > 0))
            {
                double total = 0;
                if (ShoppingCart.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in ShoppingCart.Rows)
                    {
                        //check if the product ID already exists
                        if (row.Cells[0].Value == pd.ID)
                        {
                            pd.Quantity = pd.Quantity + 1;
                            pd.Price = productList[b.TabIndex].Price;
                            total = pd.Quantity * pd.Price;
                            //update the quantity of the found row
                            row.Cells[2].Value = Convert.ToDouble(pd.Quantity);
                            row.Cells[3].Value = Convert.ToDouble(pd.Price);
                            row.Cells[4].Value = Convert.ToDouble(total);
                            Found = true;

                            UpdateQTy(productFile, b);
                        }
                    }
                    if (!Found)
                    {
                        pd.Quantity = 1;
                        total = pd.Quantity * pd.Price;
                        ShoppingCart.Rows.Add(pd.ID, pd.Name, pd.Quantity, pd.Price, total);

                        UpdateQTy(productFile, b);
                    }
                }
                else
                {
                    //add the row to shopping cart for the 1st time
                    pd.Quantity = 1;
                    total = pd.Quantity * pd.Price;
                    ShoppingCart.Rows.Add(pd.ID, pd.Name, pd.Quantity, pd.Price, total);

                    UpdateQTy(productFile, b);
                }


                //add Items Count for each transaction
                double totalP1 = 0;
                for (int i = 0; i < ShoppingCart.Rows.Count; i++)
                {
                    try
                    {
                        totalP1 += double.Parse(ShoppingCart.Rows[i].Cells[2].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    itemsCount.Text = totalP1.ToString();
                }
                //add Total Amount for each transaction
                double totalP2 = 0;
                for (int i = 0; i < ShoppingCart.Rows.Count; i++)
                {
                    try
                    {
                        totalP2 += double.Parse(ShoppingCart.Rows[i].Cells[4].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    totalPay.Text = totalP2.ToString();
                }
            }
            else
            {
                MessageBox.Show($"{b.Name} out of stock");
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

        //renew Shopping Cart
        private void clearButton_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in ShoppingCart.Rows)
                {
                    try
                    {
                        ShoppingCart.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (ShoppingCart.Rows.Count > 0);
            itemsCount.Clear();
            totalPay.Clear();
        }
    }
}
