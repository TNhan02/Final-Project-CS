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
    public partial class Top10 : Form
    {
        public DataTable Table = new DataTable();
        public Top10()
        {
            InitializeComponent();

            Table.Columns.Add("Product", typeof(string));
            Table.Columns.Add("Quantity Sold", typeof(int));
            top10Table.DataSource = Table;
        }
    }
}
