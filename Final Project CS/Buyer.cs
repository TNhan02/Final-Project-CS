﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Final_Project_CS
{
    public class Buyer
    {
        public static string ShowDialog(string text,string caption)
        {
            Form AskBuyer = new Form()
            {
                Width = 300,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox Buyer = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { AskBuyer.Close(); };
            AskBuyer.Controls.Add(Buyer);
            AskBuyer.Controls.Add(confirmation);
            AskBuyer.Controls.Add(textLabel);
            AskBuyer.AcceptButton = confirmation;

            return AskBuyer.ShowDialog() == DialogResult.OK ? Buyer.Text : "";
        }
    }
}
