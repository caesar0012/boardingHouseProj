﻿namespace boardingHouseProj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPayment = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbAddOns = new System.Windows.Forms.CheckedListBox();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAdd = new System.Windows.Forms.TextBox();
            this.btnAddOn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.cbCash = new System.Windows.Forms.CheckBox();
            this.cbGcash = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPayment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            this.dgPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPayment.EnableHeadersVisualStyles = false;
            this.dgPayment.Location = new System.Drawing.Point(269, 54);
            this.dgPayment.Name = "dgPayment";
            this.dgPayment.RowHeadersVisible = false;
            this.dgPayment.RowHeadersWidth = 51;
            this.dgPayment.Size = new System.Drawing.Size(629, 367);
            this.dgPayment.TabIndex = 0;
            this.dgPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPayment_CellClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(16, 448);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tenant Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Rent";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(16, 110);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(203, 20);
            this.txtRent.TabIndex = 26;
            this.txtRent.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Amount Payable";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(697, 446);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(203, 20);
            this.txtTotal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add Ons Details";
            // 
            // clbAddOns
            // 
            this.clbAddOns.FormattingEnabled = true;
            this.clbAddOns.Location = new System.Drawing.Point(14, 176);
            this.clbAddOns.Name = "clbAddOns";
            this.clbAddOns.Size = new System.Drawing.Size(203, 64);
            this.clbAddOns.TabIndex = 32;
            this.clbAddOns.SelectedIndexChanged += new System.EventHandler(this.clbAddOns_SelectedIndexChanged);
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(16, 64);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(205, 20);
            this.txtTenantName.TabIndex = 33;
            this.txtTenantName.TextChanged += new System.EventHandler(this.txtTenantName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total Addon";
            // 
            // txtTotalAdd
            // 
            this.txtTotalAdd.Enabled = false;
            this.txtTotalAdd.Location = new System.Drawing.Point(16, 300);
            this.txtTotalAdd.Name = "txtTotalAdd";
            this.txtTotalAdd.Size = new System.Drawing.Size(203, 20);
            this.txtTotalAdd.TabIndex = 34;
            // 
            // btnAddOn
            // 
            this.btnAddOn.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOn.Location = new System.Drawing.Point(97, 448);
            this.btnAddOn.Name = "btnAddOn";
            this.btnAddOn.Size = new System.Drawing.Size(123, 23);
            this.btnAddOn.TabIndex = 43;
            this.btnAddOn.Text = "Add On";
            this.btnAddOn.UseVisualStyleBackColor = false;
            this.btnAddOn.Click += new System.EventHandler(this.btnAddOn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Amount Received";
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(16, 355);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(203, 20);
            this.txtReceived.TabIndex = 44;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Change Due:";
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(17, 413);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(203, 20);
            this.txtChange.TabIndex = 46;
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.IndianRed;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Location = new System.Drawing.Point(449, 450);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(75, 23);
            this.btnReceipt.TabIndex = 48;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // cbCash
            // 
            this.cbCash.AutoSize = true;
            this.cbCash.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCash.Location = new System.Drawing.Point(50, 256);
            this.cbCash.Margin = new System.Windows.Forms.Padding(2);
            this.cbCash.Name = "cbCash";
            this.cbCash.Size = new System.Drawing.Size(51, 18);
            this.cbCash.TabIndex = 49;
            this.cbCash.Text = "Cash";
            this.cbCash.UseVisualStyleBackColor = true;
            // 
            // cbGcash
            // 
            this.cbGcash.AutoSize = true;
            this.cbGcash.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGcash.Location = new System.Drawing.Point(110, 256);
            this.cbGcash.Margin = new System.Windows.Forms.Padding(2);
            this.cbGcash.Name = "cbGcash";
            this.cbGcash.Size = new System.Drawing.Size(59, 18);
            this.cbGcash.TabIndex = 50;
            this.cbGcash.Text = "GCash";
            this.cbGcash.UseVisualStyleBackColor = true;
            this.cbGcash.CheckedChanged += new System.EventHandler(this.cbGcash_CheckedChanged);
            // 
            // Payment_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(930, 498);
            this.Controls.Add(this.cbGcash);
            this.Controls.Add(this.cbCash);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.btnAddOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalAdd);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.clbAddOns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_Frm";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.Payment_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPayment;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbAddOns;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAdd;
        private System.Windows.Forms.Button btnAddOn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.CheckBox cbCash;
        private System.Windows.Forms.CheckBox cbGcash;
    }
}