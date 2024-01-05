namespace boardingHouseProj
{
    partial class Payment_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPayment = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbAddOns = new System.Windows.Forms.CheckedListBox();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayable = new System.Windows.Forms.TextBox();
            this.btnAddOn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPayment
            // 
            this.dgPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPayment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgPayment.EnableHeadersVisualStyles = false;
            this.dgPayment.Location = new System.Drawing.Point(359, 66);
            this.dgPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgPayment.Name = "dgPayment";
            this.dgPayment.RowHeadersVisible = false;
            this.dgPayment.RowHeadersWidth = 51;
            this.dgPayment.Size = new System.Drawing.Size(839, 452);
            this.dgPayment.TabIndex = 0;
            this.dgPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPayment_CellClick);
            this.dgPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPayment_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1137, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(16, 572);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tenant Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Rent";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(16, 156);
            this.txtRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(269, 22);
            this.txtRent.TabIndex = 26;
            this.txtRent.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 554);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(929, 549);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(269, 22);
            this.txtTotal.TabIndex = 28;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "GCash"});
            this.cmbPaymentType.Location = new System.Drawing.Point(13, 47);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(163, 24);
            this.cmbPaymentType.TabIndex = 30;
            this.cmbPaymentType.Text = "Payment Type";
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add Ons Details";
            // 
            // clbAddOns
            // 
            this.clbAddOns.FormattingEnabled = true;
            this.clbAddOns.Location = new System.Drawing.Point(13, 238);
            this.clbAddOns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbAddOns.Name = "clbAddOns";
            this.clbAddOns.Size = new System.Drawing.Size(269, 106);
            this.clbAddOns.TabIndex = 32;
            this.clbAddOns.SelectedIndexChanged += new System.EventHandler(this.clbAddOns_SelectedIndexChanged);
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(16, 100);
            this.txtTenantName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(272, 22);
            this.txtTenantName.TabIndex = 33;
            this.txtTenantName.TextChanged += new System.EventHandler(this.txtTenantName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Amount Payable";
            // 
            // txtPayable
            // 
            this.txtPayable.Location = new System.Drawing.Point(16, 390);
            this.txtPayable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayable.Name = "txtPayable";
            this.txtPayable.Size = new System.Drawing.Size(269, 22);
            this.txtPayable.TabIndex = 34;
            // 
            // btnAddOn
            // 
            this.btnAddOn.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOn.Location = new System.Drawing.Point(124, 572);
            this.btnAddOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddOn.Name = "btnAddOn";
            this.btnAddOn.Size = new System.Drawing.Size(164, 28);
            this.btnAddOn.TabIndex = 43;
            this.btnAddOn.Text = "Add On";
            this.btnAddOn.UseVisualStyleBackColor = false;
            this.btnAddOn.Click += new System.EventHandler(this.btnAddOn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 428);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "Amount Received";
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(16, 458);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(269, 22);
            this.txtReceived.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 499);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "Change Due:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 529);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Payment_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1240, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.btnAddOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayable);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.clbAddOns);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Payment_Frm";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.Payment_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPayment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbAddOns;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayable;
        private System.Windows.Forms.Button btnAddOn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}