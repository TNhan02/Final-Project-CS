using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_CS
{
    public partial class Maintenance : Form
    {
        CashRegister cashForm = new CashRegister();
        Report reportForm = new Report();
        public Maintenance()
        {
            InitializeComponent();
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            cashForm.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportForm.Show();
        }
    }
}
