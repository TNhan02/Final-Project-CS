
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
            this.Transactions_Table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mostSoldProducts = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.fillButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Transactions_Table
            // 
            this.Transactions_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Transactions_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions_Table.Location = new System.Drawing.Point(216, 51);
            this.Transactions_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Transactions_Table.Name = "Transactions_Table";
            this.Transactions_Table.RowHeadersWidth = 62;
            this.Transactions_Table.RowTemplate.Height = 28;
            this.Transactions_Table.Size = new System.Drawing.Size(865, 327);
            this.Transactions_Table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRAND TOTAL-->";
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(909, 399);
            this.TotalCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(89, 22);
            this.TotalCost.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(915, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Cost";
            // 
            // mostSoldProducts
            // 
            this.mostSoldProducts.Location = new System.Drawing.Point(27, 104);
            this.mostSoldProducts.Name = "mostSoldProducts";
            this.mostSoldProducts.Size = new System.Drawing.Size(163, 44);
            this.mostSoldProducts.TabIndex = 8;
            this.mostSoldProducts.Text = "Top 10 Sold Products";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(531, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(647, 23);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 12;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(27, 172);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(163, 44);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 466);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.mostSoldProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transactions_Table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.Transactions_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Transactions_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
        private System.Windows.Forms.Button mostSoldProducts;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button clearButton;
    }
}