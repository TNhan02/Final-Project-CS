
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reportPage = new System.Windows.Forms.TabPage();
            this.cashregisterPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShoppingCart = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.addCart_Button = new System.Windows.Forms.Button();
            this.productsPage = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPQuantity = new System.Windows.Forms.TextBox();
            this.addPPrice = new System.Windows.Forms.TextBox();
            this.addPName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.cashregisterPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCart)).BeginInit();
            this.productsPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.mainPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 75);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Staff Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(656, 40);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 17);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(657, 23);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(38, 17);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Maintenance Software";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-package.png");
            this.imageList1.Images.SetKeyName(1, "cash-register.png");
            this.imageList1.Images.SetKeyName(2, "home (1).png");
            this.imageList1.Images.SetKeyName(3, "package.png");
            this.imageList1.Images.SetKeyName(4, "report.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reportPage
            // 
            this.reportPage.ImageIndex = 4;
            this.reportPage.Location = new System.Drawing.Point(4, 39);
            this.reportPage.Name = "reportPage";
            this.reportPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportPage.Size = new System.Drawing.Size(919, 363);
            this.reportPage.TabIndex = 4;
            this.reportPage.Text = "Report";
            this.reportPage.UseVisualStyleBackColor = true;
            // 
            // cashregisterPage
            // 
            this.cashregisterPage.AutoScroll = true;
            this.cashregisterPage.Controls.Add(this.groupBox2);
            this.cashregisterPage.Controls.Add(this.label4);
            this.cashregisterPage.Controls.Add(this.ShoppingCart);
            this.cashregisterPage.Controls.Add(this.button2);
            this.cashregisterPage.Controls.Add(this.addCart_Button);
            this.cashregisterPage.ImageIndex = 1;
            this.cashregisterPage.Location = new System.Drawing.Point(4, 39);
            this.cashregisterPage.Name = "cashregisterPage";
            this.cashregisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.cashregisterPage.Size = new System.Drawing.Size(919, 363);
            this.cashregisterPage.TabIndex = 3;
            this.cashregisterPage.Text = "Cash Register";
            this.cashregisterPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addQuantity);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 103);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(87, 26);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(173, 27);
            this.addName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(87, 66);
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(173, 27);
            this.addQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shopping Cart";
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShoppingCart.ColumnHeadersHeight = 29;
            this.ShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.Price});
            this.ShoppingCart.Location = new System.Drawing.Point(334, 34);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.RowHeadersWidth = 51;
            this.ShoppingCart.RowTemplate.Height = 24;
            this.ShoppingCart.Size = new System.Drawing.Size(578, 270);
            this.ShoppingCart.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Checkout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addCart_Button
            // 
            this.addCart_Button.Location = new System.Drawing.Point(89, 143);
            this.addCart_Button.Name = "addCart_Button";
            this.addCart_Button.Size = new System.Drawing.Size(130, 32);
            this.addCart_Button.TabIndex = 5;
            this.addCart_Button.Text = "Add to Cart";
            this.addCart_Button.UseVisualStyleBackColor = true;
            this.addCart_Button.Click += new System.EventHandler(this.addCart_Button_Click);
            // 
            // productsPage
            // 
            this.productsPage.Controls.Add(this.addButton);
            this.productsPage.Controls.Add(this.editButton);
            this.productsPage.Controls.Add(this.deleteButton);
            this.productsPage.Controls.Add(this.groupBox1);
            this.productsPage.Controls.Add(this.label5);
            this.productsPage.Controls.Add(this.ProductList);
            this.productsPage.ImageIndex = 3;
            this.productsPage.Location = new System.Drawing.Point(4, 39);
            this.productsPage.Name = "productsPage";
            this.productsPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsPage.Size = new System.Drawing.Size(919, 363);
            this.productsPage.TabIndex = 1;
            this.productsPage.Text = "Products";
            this.productsPage.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(207, 190);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 35);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(116, 190);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 35);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(25, 190);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 35);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPQuantity);
            this.groupBox1.Controls.Add(this.addPPrice);
            this.groupBox1.Controls.Add(this.addPName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // addPQuantity
            // 
            this.addPQuantity.Location = new System.Drawing.Point(83, 98);
            this.addPQuantity.Name = "addPQuantity";
            this.addPQuantity.Size = new System.Drawing.Size(175, 27);
            this.addPQuantity.TabIndex = 7;
            // 
            // addPPrice
            // 
            this.addPPrice.Location = new System.Drawing.Point(83, 65);
            this.addPPrice.Name = "addPPrice";
            this.addPPrice.Size = new System.Drawing.Size(175, 27);
            this.addPPrice.TabIndex = 6;
            // 
            // addPName
            // 
            this.addPName.Location = new System.Drawing.Point(83, 30);
            this.addPName.Name = "addPName";
            this.addPName.Size = new System.Drawing.Size(175, 27);
            this.addPName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product List";
            // 
            // ProductList
            // 
            this.ProductList.AllowUserToAddRows = false;
            this.ProductList.AllowUserToDeleteRows = false;
            this.ProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ProductList.ColumnHeadersHeight = 29;
            this.ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.PPrice,
            this.PQuantity});
            this.ProductList.Location = new System.Drawing.Point(333, 41);
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            this.ProductList.RowHeadersWidth = 51;
            this.ProductList.RowTemplate.Height = 24;
            this.ProductList.Size = new System.Drawing.Size(559, 310);
            this.ProductList.TabIndex = 0;
            // 
            // PName
            // 
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "Price";
            this.PPrice.MinimumWidth = 6;
            this.PPrice.Name = "PPrice";
            this.PPrice.ReadOnly = true;
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "Quantity";
            this.PQuantity.MinimumWidth = 6;
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.ReadOnly = true;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.label11);
            this.mainPage.Controls.Add(this.label10);
            this.mainPage.Controls.Add(this.label9);
            this.mainPage.ImageIndex = 2;
            this.mainPage.Location = new System.Drawing.Point(4, 39);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(919, 363);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Apple Iphone 13 Series on sale !";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(556, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "We are providing most modern Apple product with the most suitable price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "WELCOME TO SHOPPING MALL";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.productsPage);
            this.tabControl1.Controls.Add(this.cashregisterPage);
            this.tabControl1.Controls.Add(this.reportPage);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(135, 35);
            this.tabControl1.Location = new System.Drawing.Point(3, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 406);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 493);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cashregisterPage.ResumeLayout(false);
            this.cashregisterPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCart)).EndInit();
            this.productsPage.ResumeLayout(false);
            this.productsPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage reportPage;
        private System.Windows.Forms.TabPage cashregisterPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ShoppingCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addCart_Button;
        private System.Windows.Forms.TextBox addQuantity;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage productsPage;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addPQuantity;
        private System.Windows.Forms.TextBox addPPrice;
        private System.Windows.Forms.TextBox addPName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ProductList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

