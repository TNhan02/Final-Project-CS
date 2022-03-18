using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_CS
{
    public static class Buyer
    {
        public static string ShowDialog(string text,string caption)
        {
            Form AskBuyer = new Form()
            {
                Width = 400,
                Height = 300,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { AskBuyer.Close(); };
            AskBuyer.Controls.Add(textBox);
            AskBuyer.Controls.Add(confirmation);
            AskBuyer.Controls.Add(textLabel);
            AskBuyer.AcceptButton = confirmation;

            return AskBuyer.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
