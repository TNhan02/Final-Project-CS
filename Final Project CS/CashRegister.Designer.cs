
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShoppingCart = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.addcartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addQuantity);
            this.groupBox1.Controls.Add(this.addName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to Cart";
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(95, 65);
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(134, 22);
            this.addQuantity.TabIndex = 3;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(95, 34);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(134, 22);
            this.addName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ShoppingCart.AllowUserToAddRows = false;
            this.ShoppingCart.AllowUserToDeleteRows = false;
            this.ShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.Price});
            this.ShoppingCart.Location = new System.Drawing.Point(306, 41);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.ReadOnly = true;
            this.ShoppingCart.RowHeadersWidth = 51;
            this.ShoppingCart.RowTemplate.Height = 24;
            this.ShoppingCart.Size = new System.Drawing.Size(482, 351);
            this.ShoppingCart.TabIndex = 1;
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
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(456, 398);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(209, 31);
            this.checkoutButton.TabIndex = 2;
            this.checkoutButton.Text = "Proceed to Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // addcartButton
            // 
            this.addcartButton.Location = new System.Drawing.Point(105, 159);
            this.addcartButton.Name = "addcartButton";
            this.addcartButton.Size = new System.Drawing.Size(92, 32);
            this.addcartButton.TabIndex = 3;
            this.addcartButton.Text = "Add to Cart";
            this.addcartButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shopping Cart";
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addcartButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.groupBox1);
            this.Text = "CashRegister";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ShoppingCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.TextBox addQuantity;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addcartButton;
        private System.Windows.Forms.Label label3;
    }
}