namespace boardingHouseProj
{
    partial class room_tenant_add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgAssignTenant = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartLease = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEndLease = new System.Windows.Forms.DateTimePicker();
            this.cmbRoomNum = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssignTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Room";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1124, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgAssignTenant
            // 
            this.dgAssignTenant.AllowUserToAddRows = false;
            this.dgAssignTenant.AllowUserToDeleteRows = false;
            this.dgAssignTenant.AllowUserToOrderColumns = true;
            this.dgAssignTenant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAssignTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgAssignTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAssignTenant.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgAssignTenant.EnableHeadersVisualStyles = false;
            this.dgAssignTenant.Location = new System.Drawing.Point(380, 112);
            this.dgAssignTenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgAssignTenant.Name = "dgAssignTenant";
            this.dgAssignTenant.ReadOnly = true;
            this.dgAssignTenant.RowHeadersVisible = false;
            this.dgAssignTenant.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.MistyRose;
            this.dgAssignTenant.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgAssignTenant.Size = new System.Drawing.Size(819, 352);
            this.dgAssignTenant.TabIndex = 3;
            this.dgAssignTenant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAssignTenant_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenant ID*";
            // 
            // dtStartLease
            // 
            this.dtStartLease.Location = new System.Drawing.Point(36, 401);
            this.dtStartLease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtStartLease.Name = "dtStartLease";
            this.dtStartLease.Size = new System.Drawing.Size(265, 22);
            this.dtStartLease.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Lease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bed ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Lease";
            // 
            // dtEndLease
            // 
            this.dtEndLease.Location = new System.Drawing.Point(36, 479);
            this.dtEndLease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEndLease.Name = "dtEndLease";
            this.dtEndLease.Size = new System.Drawing.Size(265, 22);
            this.dtEndLease.TabIndex = 11;
            this.dtEndLease.ValueChanged += new System.EventHandler(this.dtEndLease_ValueChanged);
            // 
            // cmbRoomNum
            // 
            this.cmbRoomNum.FormattingEnabled = true;
            this.cmbRoomNum.Location = new System.Drawing.Point(33, 127);
            this.cmbRoomNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoomNum.Name = "cmbRoomNum";
            this.cmbRoomNum.Size = new System.Drawing.Size(265, 24);
            this.cmbRoomNum.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(108, 517);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(33, 192);
            this.txtBed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(265, 22);
            this.txtBed.TabIndex = 17;
            this.txtBed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBed_KeyDown);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Default",
            "Available Room",
            "Tenant without Room",
            "Female",
            "Male"});
            this.cmbFilter.Location = new System.Drawing.Point(380, 80);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(183, 24);
            this.cmbFilter.TabIndex = 18;
            this.cmbFilter.Text = "Default";
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Deposit Amount";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(36, 347);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(265, 22);
            this.txtDeposit.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monthly Payment";
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(36, 265);
            this.txtMonthlyPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(265, 22);
            this.txtMonthlyPayment.TabIndex = 21;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSample.Location = new System.Drawing.Point(664, 83);
            this.lblSample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(68, 23);
            this.lblSample.TabIndex = 24;
            this.lblSample.Text = "Tenant";
            // 
            // txtTenantId
            // 
            this.txtTenantId.Enabled = false;
            this.txtTenantId.Location = new System.Drawing.Point(36, 52);
            this.txtTenantId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(265, 22);
            this.txtTenantId.TabIndex = 25;
            this.txtTenantId.TextChanged += new System.EventHandler(this.txtTenantId_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(884, 83);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(76, 23);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // room_tenant_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1240, 560);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtTenantId);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbRoomNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtEndLease);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtStartLease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAssignTenant);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "room_tenant_add";
            this.Text = "room_option";
            this.Load += new System.EventHandler(this.room_tenant_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAssignTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgAssignTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartLease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtEndLease;
        private System.Windows.Forms.ComboBox cmbRoomNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.Label lblGender;
    }
}