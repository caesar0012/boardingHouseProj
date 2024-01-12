namespace boardingHouseProj
{
    partial class TransactionFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionFrm));
            this.dgTransaction = new System.Windows.Forms.DataGridView();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnView = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTransaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            this.dgTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnName,
            this.clmnPayment,
            this.clmnDate,
            this.clmnView});
            this.dgTransaction.EnableHeadersVisualStyles = false;
            this.dgTransaction.Location = new System.Drawing.Point(12, 29);
            this.dgTransaction.Name = "dgTransaction";
            this.dgTransaction.RowHeadersVisible = false;
            this.dgTransaction.RowHeadersWidth = 51;
            this.dgTransaction.RowTemplate.Height = 24;
            this.dgTransaction.Size = new System.Drawing.Size(686, 641);
            this.dgTransaction.TabIndex = 27;
            this.dgTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransaction_CellClick);
            // 
            // clmnID
            // 
            this.clmnID.HeaderText = "ID";
            this.clmnID.MinimumWidth = 6;
            this.clmnID.Name = "clmnID";
            this.clmnID.Width = 70;
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.HeaderText = "Name";
            this.clmnName.MinimumWidth = 6;
            this.clmnName.Name = "clmnName";
            // 
            // clmnPayment
            // 
            this.clmnPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPayment.HeaderText = "Payment";
            this.clmnPayment.MinimumWidth = 6;
            this.clmnPayment.Name = "clmnPayment";
            // 
            // clmnDate
            // 
            this.clmnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDate.HeaderText = "Date";
            this.clmnDate.MinimumWidth = 6;
            this.clmnDate.Name = "clmnDate";
            // 
            // clmnView
            // 
            this.clmnView.HeaderText = " ";
            this.clmnView.Image = ((System.Drawing.Image)(resources.GetObject("clmnView.Image")));
            this.clmnView.MinimumWidth = 6;
            this.clmnView.Name = "clmnView";
            this.clmnView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnView.Width = 70;
            // 
            // TransactionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(710, 682);
            this.Controls.Add(this.dgTransaction);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TransactionFrm";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TrasanctionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDate;
        private System.Windows.Forms.DataGridViewImageColumn clmnView;
    }
}