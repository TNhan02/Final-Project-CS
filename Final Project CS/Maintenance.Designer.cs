﻿
namespace Final_Project_CS
{
    partial class Maintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPPrice = new System.Windows.Forms.TextBox();
            this.addPQuantity = new System.Windows.Forms.TextBox();
            this.addPName = new System.Windows.Forms.TextBox();
            this.addPID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cashButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.searchPID = new System.Windows.Forms.TextBox();
            this.Product_List = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPPrice);
            this.groupBox1.Controls.Add(this.addPQuantity);
            this.groupBox1.Controls.Add(this.addPName);
            this.groupBox1.Controls.Add(this.addPID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 147);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // addPPrice
            // 
            this.addPPrice.Location = new System.Drawing.Point(75, 120);
            this.addPPrice.Name = "addPPrice";
            this.addPPrice.Size = new System.Drawing.Size(149, 22);
            this.addPPrice.TabIndex = 7;
            // 
            // addPQuantity
            // 
            this.addPQuantity.Location = new System.Drawing.Point(75, 89);
            this.addPQuantity.Name = "addPQuantity";
            this.addPQuantity.Size = new System.Drawing.Size(149, 22);
            this.addPQuantity.TabIndex = 6;
            // 
            // addPName
            // 
            this.addPName.Location = new System.Drawing.Point(75, 58);
            this.addPName.Name = "addPName";
            this.addPName.Size = new System.Drawing.Size(149, 22);
            this.addPName.TabIndex = 5;
            // 
            // addPID
            // 
            this.addPID.Location = new System.Drawing.Point(75, 28);
            this.addPID.Name = "addPID";
            this.addPID.Size = new System.Drawing.Size(149, 22);
            this.addPID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(114, 308);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Maintenance Software";
            // 
            // cashButton
            // 
            this.cashButton.Location = new System.Drawing.Point(530, 23);
            this.cashButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(170, 45);
            this.cashButton.TabIndex = 1;
            this.cashButton.Text = "Cash Register";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(764, 23);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(170, 45);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.reportButton);
            this.panel1.Controls.Add(this.cashButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 87);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Product ID";
            // 
            // searchPID
            // 
            this.searchPID.Location = new System.Drawing.Point(382, 116);
            this.searchPID.Name = "searchPID";
            this.searchPID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchPID.Size = new System.Drawing.Size(133, 22);
            this.searchPID.TabIndex = 5;
            this.searchPID.TextChanged += new System.EventHandler(this.searchPID_TextChanged);
            // 
            // Product_List
            // 
            this.Product_List.AllowUserToAddRows = false;
            this.Product_List.AllowUserToDeleteRows = false;
            this.Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_List.Location = new System.Drawing.Point(303, 147);
            this.Product_List.Name = "Product_List";
            this.Product_List.ReadOnly = true;
            this.Product_List.RowHeadersWidth = 51;
            this.Product_List.RowTemplate.Height = 24;
            this.Product_List.Size = new System.Drawing.Size(632, 370);
            this.Product_List.TabIndex = 7;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(822, 106);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(113, 35);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 540);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.Product_List);
            this.Controls.Add(this.searchPID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchPID;
        private System.Windows.Forms.DataGridView Product_List;
        private System.Windows.Forms.TextBox addPPrice;
        private System.Windows.Forms.TextBox addPQuantity;
        private System.Windows.Forms.TextBox addPName;
        private System.Windows.Forms.TextBox addPID;
        private System.Windows.Forms.Button updateButton;
    }
}