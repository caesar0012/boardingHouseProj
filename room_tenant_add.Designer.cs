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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgAssignTenant = new System.Windows.Forms.DataGridView();
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssignTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tenant Reservation";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(843, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.NullValue = null;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAssignTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgAssignTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.NullValue = null;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAssignTenant.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgAssignTenant.EnableHeadersVisualStyles = false;
            this.dgAssignTenant.Location = new System.Drawing.Point(285, 91);
            this.dgAssignTenant.Name = "dgAssignTenant";
            this.dgAssignTenant.ReadOnly = true;
            this.dgAssignTenant.RowHeadersVisible = false;
            this.dgAssignTenant.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.MistyRose;
            this.dgAssignTenant.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgAssignTenant.Size = new System.Drawing.Size(614, 286);
            this.dgAssignTenant.TabIndex = 3;
            this.dgAssignTenant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAssignTenant_CellClick);
            // 
            // dtStartLease
            // 
            this.dtStartLease.Location = new System.Drawing.Point(50, 346);
            this.dtStartLease.Name = "dtStartLease";
            this.dtStartLease.Size = new System.Drawing.Size(200, 20);
            this.dtStartLease.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Lease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bed ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Lease";
            // 
            // dtEndLease
            // 
            this.dtEndLease.Location = new System.Drawing.Point(49, 393);
            this.dtEndLease.Name = "dtEndLease";
            this.dtEndLease.Size = new System.Drawing.Size(200, 20);
            this.dtEndLease.TabIndex = 11;
            this.dtEndLease.ValueChanged += new System.EventHandler(this.dtEndLease_ValueChanged);
            // 
            // cmbRoomNum
            // 
            this.cmbRoomNum.FormattingEnabled = true;
            this.cmbRoomNum.Location = new System.Drawing.Point(47, 142);
            this.cmbRoomNum.Name = "cmbRoomNum";
            this.cmbRoomNum.Size = new System.Drawing.Size(200, 21);
            this.cmbRoomNum.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(49, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(47, 196);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(200, 20);
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
            this.cmbFilter.Location = new System.Drawing.Point(285, 65);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(138, 21);
            this.cmbFilter.TabIndex = 18;
            this.cmbFilter.Text = "Default";
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Deposit Amount";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(50, 302);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(200, 20);
            this.txtDeposit.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monthly Payment";
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(47, 249);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(200, 20);
            this.txtMonthlyPayment.TabIndex = 21;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.IndianRed;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Location = new System.Drawing.Point(174, 424);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(47, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 28;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(47, 98);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(200, 20);
            this.txtGender.TabIndex = 29;
            // 
            // room_tenant_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(930, 455);
            this.Controls.Add(this.btnPayment);
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
            this.Controls.Add(this.dgAssignTenant);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
    }
}