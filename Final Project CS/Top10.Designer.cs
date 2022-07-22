
namespace Final_Project_CS
{
    partial class Top10
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
            this.top10Table = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.top10Table)).BeginInit();
            this.SuspendLayout();
            // 
            // top10Table
            // 
            this.top10Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.top10Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.top10Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity_Sold});
            this.top10Table.Location = new System.Drawing.Point(0, -2);
            this.top10Table.Name = "top10Table";
            this.top10Table.RowHeadersWidth = 51;
            this.top10Table.RowTemplate.Height = 24;
            this.top10Table.Size = new System.Drawing.Size(463, 450);
            this.top10Table.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // Quantity_Sold
            // 
            this.Quantity_Sold.HeaderText = "Quantity Sold";
            this.Quantity_Sold.MinimumWidth = 6;
            this.Quantity_Sold.Name = "Quantity_Sold";
            // 
            // Top10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.top10Table);
            this.Name = "Top10";
            this.Text = "Top10";
            ((System.ComponentModel.ISupportInitialize)(this.top10Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView top10Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Sold;
    }
}