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

namespace Final_Project_CS
{
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //adding buyer information and payment method (cash or card)
            //and then transfer transaction information to the report folder
            string buyer_info = Interaction.InputBox("Message", "Title", "Default value", -1, -1);
        }
    }
}
