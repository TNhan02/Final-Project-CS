
namespace Final_Project_CS
{
    partial class Report
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
            this.Transactions_Table = new System.Windows.Forms.DataGridView();
            this.Buyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SaleAmount = new System.Windows.Forms.TextBox();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mostSoldProducts = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.cashRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Transactions_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRegisterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Transactions_Table
            // 
            this.Transactions_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Transactions_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buyer,
            this.Product,
            this.Quantity_Qty,
            this.Total_Cost});
            this.Transactions_Table.Location = new System.Drawing.Point(216, 51);
            this.Transactions_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Transactions_Table.Name = "Transactions_Table";
            this.Transactions_Table.RowHeadersWidth = 62;
            this.Transactions_Table.RowTemplate.Height = 28;
            this.Transactions_Table.Size = new System.Drawing.Size(865, 327);
            this.Transactions_Table.TabIndex = 0;
            // 
            // Buyer
            // 
            this.Buyer.HeaderText = "Buyer";
            this.Buyer.MinimumWidth = 6;
            this.Buyer.Name = "Buyer";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // Quantity_Qty
            // 
            this.Quantity_Qty.HeaderText = "Quantity";
            this.Quantity_Qty.MinimumWidth = 6;
            this.Quantity_Qty.Name = "Quantity_Qty";
            // 
            // Total_Cost
            // 
            this.Total_Cost.HeaderText = "Total Cost";
            this.Total_Cost.MinimumWidth = 6;
            this.Total_Cost.Name = "Total_Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRAND TOTAL-->";
            // 
            // SaleAmount
            // 
            this.SaleAmount.Location = new System.Drawing.Point(711, 399);
            this.SaleAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaleAmount.Name = "SaleAmount";
            this.SaleAmount.Size = new System.Drawing.Size(89, 22);
            this.SaleAmount.TabIndex = 2;
            this.SaleAmount.TextChanged += new System.EventHandler(this.Quantity_Qty_TextChanged);
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(909, 399);
            this.TotalCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(89, 22);
            this.TotalCost.TabIndex = 4;
            this.TotalCost.TextChanged += new System.EventHandler(this.TotalCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sale Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(915, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Cost";
            // 
            // mostSoldProducts
            // 
            this.mostSoldProducts.Location = new System.Drawing.Point(30, 104);
            this.mostSoldProducts.Name = "mostSoldProducts";
            this.mostSoldProducts.Size = new System.Drawing.Size(156, 44);
            this.mostSoldProducts.TabIndex = 8;
            this.mostSoldProducts.Text = "Most Sold Products";
            this.mostSoldProducts.UseVisualStyleBackColor = true;
            this.mostSoldProducts.Click += new System.EventHandler(this.mostSoldProducts_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(216, 14);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(156, 32);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cashRegisterBindingSource
            // 
            this.cashRegisterBindingSource.DataSource = typeof(Final_Project_CS.CashRegister);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 466);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.mostSoldProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.SaleAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transactions_Table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.Transactions_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRegisterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Transactions_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SaleAmount;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
        private System.Windows.Forms.Button mostSoldProducts;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.BindingSource cashRegisterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Cost;
    }
}