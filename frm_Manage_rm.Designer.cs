﻿namespace boardingHouseProj
{
    partial class frmManage_rm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManage_rm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgRoom = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbDefault = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnBed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Room";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(101, 396);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 24);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgRoom
            // 
            this.dgRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            this.dgRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRoom.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRoom.EnableHeadersVisualStyles = false;
            this.dgRoom.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgRoom.Location = new System.Drawing.Point(300, 70);
            this.dgRoom.Name = "dgRoom";
            this.dgRoom.RowHeadersVisible = false;
            this.dgRoom.RowHeadersWidth = 51;
            this.dgRoom.Size = new System.Drawing.Size(603, 373);
            this.dgRoom.TabIndex = 11;
            this.dgRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoom_CellClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(53, 308);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 20);
            this.txtPrice.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(53, 251);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(191, 20);
            this.txtCapacity.TabIndex = 21;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Capacity";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(53, 134);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 20);
            this.txtDescription.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Location = new System.Drawing.Point(53, 76);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(191, 20);
            this.txtRoomNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Room Number";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "None"});
            this.cmbGender.Location = new System.Drawing.Point(53, 188);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 21);
            this.cmbGender.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gender Allowed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Under Renovation",
            "Destroyed",
            "Maintenance"});
            this.cmbStatus.Location = new System.Drawing.Point(53, 359);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 21);
            this.cmbStatus.TabIndex = 27;
            // 
            // cmbDefault
            // 
            this.cmbDefault.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDefault.FormattingEnabled = true;
            this.cmbDefault.Items.AddRange(new object[] {
            "Default",
            "Archive"});
            this.cmbDefault.Location = new System.Drawing.Point(533, 12);
            this.cmbDefault.Name = "cmbDefault";
            this.cmbDefault.Size = new System.Drawing.Size(121, 24);
            this.cmbDefault.TabIndex = 29;
            this.cmbDefault.Text = "Default";
            this.cmbDefault.SelectedIndexChanged += new System.EventHandler(this.cmbDefault_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(691, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 48);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.BackColor = System.Drawing.Color.Transparent;
            this.btnRecover.FlatAppearance.BorderSize = 0;
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecover.Image = ((System.Drawing.Image)(resources.GetObject("btnRecover.Image")));
            this.btnRecover.Location = new System.Drawing.Point(691, 8);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(57, 46);
            this.btnRecover.TabIndex = 31;
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnBed
            // 
            this.btnBed.BackColor = System.Drawing.Color.IndianRed;
            this.btnBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBed.Location = new System.Drawing.Point(812, 18);
            this.btnBed.Name = "btnBed";
            this.btnBed.Size = new System.Drawing.Size(91, 24);
            this.btnBed.TabIndex = 32;
            this.btnBed.Text = "Bed";
            this.btnBed.UseVisualStyleBackColor = false;
            this.btnBed.Click += new System.EventHandler(this.btnBed_Click);
            // 
            // frmManage_rm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(930, 455);
            this.Controls.Add(this.btnBed);
            this.Controls.Add(this.cmbDefault);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgRoom);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManage_rm";
            this.Text = "frm_Manage_rm";
            this.Load += new System.EventHandler(this.frmManage_rm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbDefault;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnBed;
    }
}