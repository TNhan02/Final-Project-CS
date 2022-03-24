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
    public partial class Loginpage : Form
    {
        Maintenance main = new Maintenance();
        public Loginpage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((username.Text == "") && (password.Text == ""))
            {
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong username of password input");
            }
        }
    }
}
