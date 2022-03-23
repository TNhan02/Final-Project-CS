
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
            this.addPQuantity = new System.Windows.Forms.TextBox();
            this.addPPrice = new System.Windows.Forms.TextBox();
            this.addPName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cashButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPQuantity);
            this.groupBox1.Controls.Add(this.addPPrice);
            this.groupBox1.Controls.Add(this.addPName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // addPQuantity
            // 
            this.addPQuantity.Location = new System.Drawing.Point(88, 113);
            this.addPQuantity.Name = "addPQuantity";
            this.addPQuantity.Size = new System.Drawing.Size(131, 22);
            this.addPQuantity.TabIndex = 5;
            // 
            // addPPrice
            // 
            this.addPPrice.Location = new System.Drawing.Point(88, 78);
            this.addPPrice.Name = "addPPrice";
            this.addPPrice.Size = new System.Drawing.Size(131, 22);
            this.addPPrice.TabIndex = 4;
            // 
            // addPName
            // 
            this.addPName.Location = new System.Drawing.Point(88, 42);
            this.addPName.Name = "addPName";
            this.addPName.Size = new System.Drawing.Size(131, 22);
            this.addPName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // ProductList
            // 
            this.ProductList.AllowUserToAddRows = false;
            this.ProductList.AllowUserToDeleteRows = false;
            this.ProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.Location = new System.Drawing.Point(327, 144);
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            this.ProductList.RowHeadersWidth = 51;
            this.ProductList.RowTemplate.Height = 24;
            this.ProductList.Size = new System.Drawing.Size(615, 337);
            this.ProductList.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(116, 318);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 28);
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
            this.cashButton.Location = new System.Drawing.Point(501, 29);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(140, 45);
            this.cashButton.TabIndex = 1;
            this.cashButton.Text = "Cash Register";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(679, 29);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(140, 45);
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
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 102);
            this.panel1.TabIndex = 0;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 510);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductList;
        private System.Windows.Forms.TextBox addPQuantity;
        private System.Windows.Forms.TextBox addPPrice;
        private System.Windows.Forms.TextBox addPName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel panel1;
    }
}