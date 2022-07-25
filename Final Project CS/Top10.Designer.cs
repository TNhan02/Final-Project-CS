
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
            ((System.ComponentModel.ISupportInitialize)(this.top10Table)).BeginInit();
            this.SuspendLayout();
            // 
            // top10Table
            // 
            this.top10Table.AllowUserToDeleteRows = false;
            this.top10Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.top10Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.top10Table.Location = new System.Drawing.Point(0, -2);
            this.top10Table.Name = "top10Table";
            this.top10Table.RowHeadersWidth = 51;
            this.top10Table.RowTemplate.Height = 24;
            this.top10Table.Size = new System.Drawing.Size(463, 450);
            this.top10Table.TabIndex = 0;
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
    }
}