namespace boardingHouseProj
{
    partial class EditBed
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
            this.dgBed = new System.Windows.Forms.DataGridView();
            this.clmnBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbTenant = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEndLease = new System.Windows.Forms.DateTimePicker();
            this.cmbBedStats = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBed
            // 
            this.dgBed.ColumnHeadersHeight = 29;
            this.dgBed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnBed,
            this.clmnName,
            this.clmnStart,
            this.clmnEnd,
            this.clmnStatus,
            this.clmnRemove});
            this.dgBed.EnableHeadersVisualStyles = false;
            this.dgBed.Location = new System.Drawing.Point(221, 52);
            this.dgBed.Name = "dgBed";
            this.dgBed.RowHeadersVisible = false;
            this.dgBed.RowHeadersWidth = 51;
            this.dgBed.Size = new System.Drawing.Size(565, 311);
            this.dgBed.TabIndex = 0;
            this.dgBed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBed_CellClick);
            this.dgBed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBed_CellContentClick);
            // 
            // clmnBed
            // 
            this.clmnBed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnBed.FillWeight = 75.08021F;
            this.clmnBed.HeaderText = "Assign Bed";
            this.clmnBed.MinimumWidth = 6;
            this.clmnBed.Name = "clmnBed";
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.FillWeight = 75.08021F;
            this.clmnName.HeaderText = "Name";
            this.clmnName.MinimumWidth = 6;
            this.clmnName.Name = "clmnName";
            // 
            // clmnStart
            // 
            this.clmnStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnStart.FillWeight = 75.08021F;
            this.clmnStart.HeaderText = "StartLease";
            this.clmnStart.MinimumWidth = 6;
            this.clmnStart.Name = "clmnStart";
            // 
            // clmnEnd
            // 
            this.clmnEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnEnd.FillWeight = 75.08021F;
            this.clmnEnd.HeaderText = "EndLease";
            this.clmnEnd.MinimumWidth = 6;
            this.clmnEnd.Name = "clmnEnd";
            // 
            // clmnStatus
            // 
            this.clmnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnStatus.FillWeight = 75.08021F;
            this.clmnStatus.HeaderText = "Status";
            this.clmnStatus.MinimumWidth = 6;
            this.clmnStatus.Name = "clmnStatus";
            // 
            // clmnRemove
            // 
            this.clmnRemove.FillWeight = 224.5989F;
            this.clmnRemove.HeaderText = "";
            this.clmnRemove.MinimumWidth = 6;
            this.clmnRemove.Name = "clmnRemove";
            this.clmnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnRemove.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bed";
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(18, 71);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(179, 20);
            this.txtBed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tenant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "EndLease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "StartLease";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bed Status";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(61, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbTenant
            // 
            this.cmbTenant.FormattingEnabled = true;
            this.cmbTenant.Location = new System.Drawing.Point(15, 137);
            this.cmbTenant.Name = "cmbTenant";
            this.cmbTenant.Size = new System.Drawing.Size(182, 22);
            this.cmbTenant.TabIndex = 12;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(18, 265);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(179, 20);
            this.dtStart.TabIndex = 13;
            // 
            // dtEndLease
            // 
            this.dtEndLease.Location = new System.Drawing.Point(18, 331);
            this.dtEndLease.Name = "dtEndLease";
            this.dtEndLease.Size = new System.Drawing.Size(179, 20);
            this.dtEndLease.TabIndex = 14;
            // 
            // cmbBedStats
            // 
            this.cmbBedStats.FormattingEnabled = true;
            this.cmbBedStats.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Under Maintenance"});
            this.cmbBedStats.Location = new System.Drawing.Point(18, 210);
            this.cmbBedStats.Name = "cmbBedStats";
            this.cmbBedStats.Size = new System.Drawing.Size(182, 22);
            this.cmbBedStats.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Room: ";
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.Location = new System.Drawing.Point(363, 24);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(58, 18);
            this.lblRoomNum.TabIndex = 17;
            this.lblRoomNum.Text = "Room: ";
            // 
            // EditBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(798, 399);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBedStats);
            this.Controls.Add(this.dtEndLease);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cmbTenant);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgBed);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditBed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBed";
            this.Load += new System.EventHandler(this.EditBed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbTenant;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEndLease;
        private System.Windows.Forms.ComboBox cmbBedStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmnRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRoomNum;
    }
}