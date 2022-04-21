
namespace Final_Project_CS
{
    partial class CashRegister
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
            this.ShoppingCart = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemsCount = new System.Windows.Forms.TextBox();
            this.totalPay = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.productSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_AW5 = new System.Windows.Forms.Button();
            this.ID_AW4 = new System.Windows.Forms.Button();
            this.ID_APP = new System.Windows.Forms.Button();
            this.ID_M1 = new System.Windows.Forms.Button();
            this.ID_MP1 = new System.Windows.Forms.Button();
            this.ID_IPro = new System.Windows.Forms.Button();
            this.ID_IA2 = new System.Windows.Forms.Button();
            this.ID_IA1 = new System.Windows.Forms.Button();
            this.ID_IM1 = new System.Windows.Forms.Button();
            this.ID_AP3 = new System.Windows.Forms.Button();
            this.ID_AP2 = new System.Windows.Forms.Button();
            this.ID_AP1 = new System.Windows.Forms.Button();
            this.ID_13PM = new System.Windows.Forms.Button();
            this.ID_13P = new System.Windows.Forms.Button();
            this.ID_13 = new System.Windows.Forms.Button();
            this.ID_12PM = new System.Windows.Forms.Button();
            this.ID_12P = new System.Windows.Forms.Button();
            this.ID_12 = new System.Windows.Forms.Button();
            this.ID_11PM = new System.Windows.Forms.Button();
            this.ID_11P = new System.Windows.Forms.Button();
            this.ID_11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ShoppingCart.AllowUserToAddRows = false;
            this.ShoppingCart.AllowUserToDeleteRows = false;
            this.ShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Quantity,
            this.Price,
            this.Total});
            this.ShoppingCart.Location = new System.Drawing.Point(360, 51);
            this.ShoppingCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.ReadOnly = true;
            this.ShoppingCart.RowHeadersWidth = 51;
            this.ShoppingCart.RowTemplate.Height = 24;
            this.ShoppingCart.Size = new System.Drawing.Size(671, 439);
            this.ShoppingCart.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shopping Cart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Items Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(365, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "TOTAL TO PAY:";
            // 
            // itemsCount
            // 
            this.itemsCount.Location = new System.Drawing.Point(540, 508);
            this.itemsCount.Name = "itemsCount";
            this.itemsCount.Size = new System.Drawing.Size(111, 23);
            this.itemsCount.TabIndex = 8;
            // 
            // totalPay
            // 
            this.totalPay.Location = new System.Drawing.Point(540, 553);
            this.totalPay.Name = "totalPay";
            this.totalPay.Size = new System.Drawing.Size(111, 23);
            this.totalPay.TabIndex = 10;
            this.totalPay.TextChanged += new System.EventHandler(this.totalPay_TextChanged);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(679, 522);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(130, 48);
            this.checkoutButton.TabIndex = 11;
            this.checkoutButton.Text = "Pay Here";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(107, 503);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 33);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Product ID";
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(107, 464);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(191, 23);
            this.productSearch.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ID_AW5);
            this.panel1.Controls.Add(this.ID_AW4);
            this.panel1.Controls.Add(this.ID_APP);
            this.panel1.Controls.Add(this.ID_M1);
            this.panel1.Controls.Add(this.ID_MP1);
            this.panel1.Controls.Add(this.ID_IPro);
            this.panel1.Controls.Add(this.ID_IA2);
            this.panel1.Controls.Add(this.ID_IA1);
            this.panel1.Controls.Add(this.ID_IM1);
            this.panel1.Controls.Add(this.ID_AP3);
            this.panel1.Controls.Add(this.ID_AP2);
            this.panel1.Controls.Add(this.ID_AP1);
            this.panel1.Controls.Add(this.ID_13PM);
            this.panel1.Controls.Add(this.ID_13P);
            this.panel1.Controls.Add(this.ID_13);
            this.panel1.Controls.Add(this.ID_12PM);
            this.panel1.Controls.Add(this.ID_12P);
            this.panel1.Controls.Add(this.ID_12);
            this.panel1.Controls.Add(this.ID_11PM);
            this.panel1.Controls.Add(this.ID_11P);
            this.panel1.Controls.Add(this.ID_11);
            this.panel1.Location = new System.Drawing.Point(20, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 399);
            this.panel1.TabIndex = 15;
            // 
            // ID_AW5
            // 
            this.ID_AW5.Location = new System.Drawing.Point(219, 343);
            this.ID_AW5.Name = "ID_AW5";
            this.ID_AW5.Size = new System.Drawing.Size(85, 33);
            this.ID_AW5.TabIndex = 20;
            this.ID_AW5.Text = "AW5";
            this.ID_AW5.UseVisualStyleBackColor = true;
            this.ID_AW5.Click += new System.EventHandler(this.ID_AW5_Click);
            // 
            // ID_AW4
            // 
            this.ID_AW4.Location = new System.Drawing.Point(118, 343);
            this.ID_AW4.Name = "ID_AW4";
            this.ID_AW4.Size = new System.Drawing.Size(85, 33);
            this.ID_AW4.TabIndex = 19;
            this.ID_AW4.Text = "AW4";
            this.ID_AW4.UseVisualStyleBackColor = true;
            this.ID_AW4.Click += new System.EventHandler(this.ID_AW4_Click);
            // 
            // ID_APP
            // 
            this.ID_APP.Location = new System.Drawing.Point(14, 236);
            this.ID_APP.Name = "ID_APP";
            this.ID_APP.Size = new System.Drawing.Size(85, 33);
            this.ID_APP.TabIndex = 12;
            this.ID_APP.Text = "APP";
            this.ID_APP.UseVisualStyleBackColor = true;
            this.ID_APP.Click += new System.EventHandler(this.ID_APP_Click);
            // 
            // ID_M1
            // 
            this.ID_M1.Location = new System.Drawing.Point(219, 291);
            this.ID_M1.Name = "ID_M1";
            this.ID_M1.Size = new System.Drawing.Size(85, 33);
            this.ID_M1.TabIndex = 17;
            this.ID_M1.Text = "M1";
            this.ID_M1.UseVisualStyleBackColor = true;
            this.ID_M1.Click += new System.EventHandler(this.ID_M1_Click);
            // 
            // ID_MP1
            // 
            this.ID_MP1.Location = new System.Drawing.Point(14, 343);
            this.ID_MP1.Name = "ID_MP1";
            this.ID_MP1.Size = new System.Drawing.Size(85, 33);
            this.ID_MP1.TabIndex = 18;
            this.ID_MP1.Text = "MP1";
            this.ID_MP1.UseVisualStyleBackColor = true;
            this.ID_MP1.Click += new System.EventHandler(this.ID_MP1_Click);
            // 
            // ID_IPro
            // 
            this.ID_IPro.Location = new System.Drawing.Point(119, 291);
            this.ID_IPro.Name = "ID_IPro";
            this.ID_IPro.Size = new System.Drawing.Size(85, 33);
            this.ID_IPro.TabIndex = 16;
            this.ID_IPro.Text = "IPro";
            this.ID_IPro.UseVisualStyleBackColor = true;
            this.ID_IPro.Click += new System.EventHandler(this.ID_IPro_Click);
            // 
            // ID_IA2
            // 
            this.ID_IA2.Location = new System.Drawing.Point(219, 236);
            this.ID_IA2.Name = "ID_IA2";
            this.ID_IA2.Size = new System.Drawing.Size(85, 33);
            this.ID_IA2.TabIndex = 14;
            this.ID_IA2.Text = "IA2";
            this.ID_IA2.UseVisualStyleBackColor = true;
            this.ID_IA2.Click += new System.EventHandler(this.ID_IA2_Click);
            // 
            // ID_IA1
            // 
            this.ID_IA1.Location = new System.Drawing.Point(118, 236);
            this.ID_IA1.Name = "ID_IA1";
            this.ID_IA1.Size = new System.Drawing.Size(85, 33);
            this.ID_IA1.TabIndex = 13;
            this.ID_IA1.Text = "IA1";
            this.ID_IA1.UseVisualStyleBackColor = true;
            this.ID_IA1.Click += new System.EventHandler(this.ID_IA1_Click);
            // 
            // ID_IM1
            // 
            this.ID_IM1.Location = new System.Drawing.Point(14, 291);
            this.ID_IM1.Name = "ID_IM1";
            this.ID_IM1.Size = new System.Drawing.Size(85, 33);
            this.ID_IM1.TabIndex = 15;
            this.ID_IM1.Text = "IM1";
            this.ID_IM1.UseVisualStyleBackColor = true;
            this.ID_IM1.Click += new System.EventHandler(this.ID_IM1_Click);
            // 
            // ID_AP3
            // 
            this.ID_AP3.Location = new System.Drawing.Point(219, 184);
            this.ID_AP3.Name = "ID_AP3";
            this.ID_AP3.Size = new System.Drawing.Size(85, 33);
            this.ID_AP3.TabIndex = 11;
            this.ID_AP3.Text = "AP3";
            this.ID_AP3.UseVisualStyleBackColor = true;
            this.ID_AP3.Click += new System.EventHandler(this.ID_AP3_Click);
            // 
            // ID_AP2
            // 
            this.ID_AP2.Location = new System.Drawing.Point(118, 184);
            this.ID_AP2.Name = "ID_AP2";
            this.ID_AP2.Size = new System.Drawing.Size(85, 33);
            this.ID_AP2.TabIndex = 10;
            this.ID_AP2.Text = "AP2";
            this.ID_AP2.UseVisualStyleBackColor = true;
            this.ID_AP2.Click += new System.EventHandler(this.ID_AP2_Click);
            // 
            // ID_AP1
            // 
            this.ID_AP1.Location = new System.Drawing.Point(14, 184);
            this.ID_AP1.Name = "ID_AP1";
            this.ID_AP1.Size = new System.Drawing.Size(85, 33);
            this.ID_AP1.TabIndex = 9;
            this.ID_AP1.Text = "AP1";
            this.ID_AP1.UseVisualStyleBackColor = true;
            this.ID_AP1.Click += new System.EventHandler(this.ID_AP1_Click);
            // 
            // ID_13PM
            // 
            this.ID_13PM.Location = new System.Drawing.Point(219, 132);
            this.ID_13PM.Name = "ID_13PM";
            this.ID_13PM.Size = new System.Drawing.Size(85, 33);
            this.ID_13PM.TabIndex = 8;
            this.ID_13PM.Text = "13PM";
            this.ID_13PM.UseVisualStyleBackColor = true;
            this.ID_13PM.Click += new System.EventHandler(this.ID_13PM_Click);
            // 
            // ID_13P
            // 
            this.ID_13P.Location = new System.Drawing.Point(119, 132);
            this.ID_13P.Name = "ID_13P";
            this.ID_13P.Size = new System.Drawing.Size(85, 33);
            this.ID_13P.TabIndex = 7;
            this.ID_13P.Text = "13P";
            this.ID_13P.UseVisualStyleBackColor = true;
            this.ID_13P.Click += new System.EventHandler(this.ID_13P_Click);
            // 
            // ID_13
            // 
            this.ID_13.Location = new System.Drawing.Point(14, 132);
            this.ID_13.Name = "ID_13";
            this.ID_13.Size = new System.Drawing.Size(85, 33);
            this.ID_13.TabIndex = 6;
            this.ID_13.Text = "13";
            this.ID_13.UseVisualStyleBackColor = true;
            this.ID_13.Click += new System.EventHandler(this.ID_13_Click);
            // 
            // ID_12PM
            // 
            this.ID_12PM.Location = new System.Drawing.Point(219, 78);
            this.ID_12PM.Name = "ID_12PM";
            this.ID_12PM.Size = new System.Drawing.Size(85, 33);
            this.ID_12PM.TabIndex = 5;
            this.ID_12PM.Text = "12PM";
            this.ID_12PM.UseVisualStyleBackColor = true;
            this.ID_12PM.Click += new System.EventHandler(this.ID_12PM_Click);
            // 
            // ID_12P
            // 
            this.ID_12P.Location = new System.Drawing.Point(119, 78);
            this.ID_12P.Name = "ID_12P";
            this.ID_12P.Size = new System.Drawing.Size(85, 33);
            this.ID_12P.TabIndex = 4;
            this.ID_12P.Text = "12P";
            this.ID_12P.UseVisualStyleBackColor = true;
            this.ID_12P.Click += new System.EventHandler(this.ID_12P_Click);
            // 
            // ID_12
            // 
            this.ID_12.Location = new System.Drawing.Point(14, 78);
            this.ID_12.Name = "ID_12";
            this.ID_12.Size = new System.Drawing.Size(85, 33);
            this.ID_12.TabIndex = 3;
            this.ID_12.Text = "12";
            this.ID_12.UseVisualStyleBackColor = true;
            this.ID_12.Click += new System.EventHandler(this.ID_12_Click);
            // 
            // ID_11PM
            // 
            this.ID_11PM.Location = new System.Drawing.Point(219, 20);
            this.ID_11PM.Name = "ID_11PM";
            this.ID_11PM.Size = new System.Drawing.Size(85, 33);
            this.ID_11PM.TabIndex = 2;
            this.ID_11PM.Text = "11PM";
            this.ID_11PM.UseVisualStyleBackColor = true;
            this.ID_11PM.Click += new System.EventHandler(this.ID_11PM_Click);
            // 
            // ID_11P
            // 
            this.ID_11P.Location = new System.Drawing.Point(119, 20);
            this.ID_11P.Name = "ID_11P";
            this.ID_11P.Size = new System.Drawing.Size(85, 33);
            this.ID_11P.TabIndex = 1;
            this.ID_11P.Text = "11P";
            this.ID_11P.UseVisualStyleBackColor = true;
            this.ID_11P.Click += new System.EventHandler(this.ID_11P_Click);
            // 
            // ID_11
            // 
            this.ID_11.Location = new System.Drawing.Point(14, 20);
            this.ID_11.Name = "ID_11";
            this.ID_11.Size = new System.Drawing.Size(85, 33);
            this.ID_11.TabIndex = 0;
            this.ID_11.Text = "11";
            this.ID_11.UseVisualStyleBackColor = true;
            this.ID_11.Click += new System.EventHandler(this.ID_11_Click);
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.totalPay);
            this.Controls.Add(this.itemsCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShoppingCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text = "Cash Register";
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ShoppingCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemsCount;
        private System.Windows.Forms.TextBox totalPay;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ID_APP;
        private System.Windows.Forms.Button ID_M1;
        private System.Windows.Forms.Button ID_MP1;
        private System.Windows.Forms.Button ID_IPro;
        private System.Windows.Forms.Button ID_IA2;
        private System.Windows.Forms.Button ID_IA1;
        private System.Windows.Forms.Button ID_IM1;
        private System.Windows.Forms.Button ID_AP3;
        private System.Windows.Forms.Button ID_AP2;
        private System.Windows.Forms.Button ID_AP1;
        private System.Windows.Forms.Button ID_13PM;
        private System.Windows.Forms.Button ID_13P;
        private System.Windows.Forms.Button ID_13;
        private System.Windows.Forms.Button ID_12PM;
        private System.Windows.Forms.Button ID_12P;
        private System.Windows.Forms.Button ID_12;
        private System.Windows.Forms.Button ID_11PM;
        private System.Windows.Forms.Button ID_11P;
        private System.Windows.Forms.Button ID_11;
        private System.Windows.Forms.Button ID_AW5;
        private System.Windows.Forms.Button ID_AW4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}