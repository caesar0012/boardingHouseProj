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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenant_id = new System.Windows.Forms.TextBox();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
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
            // txtTenant_id
            // 
            this.txtTenant_id.Location = new System.Drawing.Point(32, 112);
            this.txtTenant_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenant_id.Name = "txtTenant_id";
            this.txtTenant_id.Size = new System.Drawing.Size(265, 22);
            this.txtTenant_id.TabIndex = 1;
            this.txtTenant_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenant_id_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1124, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAssignTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgAssignTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAssignTenant.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgAssignTenant.EnableHeadersVisualStyles = false;
            this.dgAssignTenant.Location = new System.Drawing.Point(380, 112);
            this.dgAssignTenant.Margin = new System.Windows.Forms.Padding(4);
            this.dgAssignTenant.Name = "dgAssignTenant";
            this.dgAssignTenant.ReadOnly = true;
            this.dgAssignTenant.RowHeadersVisible = false;
            this.dgAssignTenant.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MistyRose;
            this.dgAssignTenant.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgAssignTenant.Size = new System.Drawing.Size(819, 352);
            this.dgAssignTenant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenant ID*";
            // 
            // dtStartLease
            // 
            this.dtStartLease.Location = new System.Drawing.Point(32, 361);
            this.dtStartLease.Margin = new System.Windows.Forms.Padding(4);
            this.dtStartLease.Name = "dtStartLease";
            this.dtStartLease.Size = new System.Drawing.Size(265, 22);
            this.dtStartLease.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 335);
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
            this.label4.Location = new System.Drawing.Point(28, 171);
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
            this.label5.Location = new System.Drawing.Point(28, 252);
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
            this.label6.Location = new System.Drawing.Point(28, 412);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Lease";
            // 
            // dtEndLease
            // 
            this.dtEndLease.Location = new System.Drawing.Point(32, 438);
            this.dtEndLease.Margin = new System.Windows.Forms.Padding(4);
            this.dtEndLease.Name = "dtEndLease";
            this.dtEndLease.Size = new System.Drawing.Size(265, 22);
            this.dtEndLease.TabIndex = 11;
            // 
            // cmbRoomNum
            // 
            this.cmbRoomNum.FormattingEnabled = true;
            this.cmbRoomNum.Location = new System.Drawing.Point(32, 209);
            this.cmbRoomNum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomNum.Name = "cmbRoomNum";
            this.cmbRoomNum.Size = new System.Drawing.Size(265, 24);
            this.cmbRoomNum.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(101, 495);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(380, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(34, 293);
            this.txtBed.Margin = new System.Windows.Forms.Padding(4);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(265, 22);
            this.txtBed.TabIndex = 17;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Available Room",
            "Tenant without Room",
            "Female",
            "Male"});
            this.cmbFilter.Location = new System.Drawing.Point(511, 77);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(182, 24);
            this.cmbFilter.TabIndex = 18;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // room_tenant_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1240, 560);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.btnSearch);
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
            this.Controls.Add(this.txtTenant_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "room_tenant_add";
            this.Text = "room_option";
            this.Load += new System.EventHandler(this.room_tenant_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAssignTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenant_id;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}