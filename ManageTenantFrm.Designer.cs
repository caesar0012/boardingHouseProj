namespace boardingHouseProj
{
    partial class ManageTenantFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTenantFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.dgTenant = new System.Windows.Forms.DataGridView();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(59, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 22);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(59, 151);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "FirstName";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(59, 211);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "LastName";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(59, 275);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 22);
            this.txtUserName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "UserName";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(59, 332);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Admin"});
            this.cmbRole.Location = new System.Drawing.Point(59, 391);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(168, 21);
            this.cmbRole.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Role";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(98, 442);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 26);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(849, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 26);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Manage Tenant Information";
            // 
            // cmbShow
            // 
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Items.AddRange(new object[] {
            "Default",
            "Recovery"});
            this.cmbShow.Location = new System.Drawing.Point(555, 11);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(137, 21);
            this.cmbShow.TabIndex = 1;
            this.cmbShow.Text = "Default";
            this.cmbShow.SelectedIndexChanged += new System.EventHandler(this.cmbShow_SelectedIndexChanged);
            // 
            // dgTenant
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnName,
            this.clmnUser,
            this.clmnPass,
            this.clmnRole,
            this.clmnDel});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTenant.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgTenant.EnableHeadersVisualStyles = false;
            this.dgTenant.Location = new System.Drawing.Point(331, 66);
            this.dgTenant.Name = "dgTenant";
            this.dgTenant.RowHeadersVisible = false;
            this.dgTenant.Size = new System.Drawing.Size(518, 400);
            this.dgTenant.TabIndex = 0;
            this.dgTenant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTenant_CellClick);
            // 
            // clmnID
            // 
            this.clmnID.FillWeight = 58.25243F;
            this.clmnID.HeaderText = "ID";
            this.clmnID.Name = "clmnID";
            this.clmnID.Width = 50;
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.FillWeight = 121.0085F;
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            // 
            // clmnUser
            // 
            this.clmnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnUser.FillWeight = 113.3266F;
            this.clmnUser.HeaderText = "UserName";
            this.clmnUser.Name = "clmnUser";
            // 
            // clmnPass
            // 
            this.clmnPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPass.FillWeight = 107.1363F;
            this.clmnPass.HeaderText = "Password";
            this.clmnPass.Name = "clmnPass";
            // 
            // clmnRole
            // 
            this.clmnRole.FillWeight = 102.1479F;
            this.clmnRole.HeaderText = "Role";
            this.clmnRole.Name = "clmnRole";
            this.clmnRole.Width = 70;
            // 
            // clmnDel
            // 
            this.clmnDel.FillWeight = 98.12823F;
            this.clmnDel.HeaderText = " ";
            this.clmnDel.Image = ((System.Drawing.Image)(resources.GetObject("clmnDel.Image")));
            this.clmnDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmnDel.Name = "clmnDel";
            this.clmnDel.Width = 84;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Location = new System.Drawing.Point(708, 12);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(70, 25);
            this.btnRestore.TabIndex = 16;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click_1);
            // 
            // ManageTenantFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(930, 498);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.dgTenant);
            this.Controls.Add(this.cmbShow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageTenantFrm";
            this.Text = "ManageTenantFrm";
            this.Load += new System.EventHandler(this.ManageTenantFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.DataGridView dgTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRole;
        private System.Windows.Forms.DataGridViewImageColumn clmnDel;
        private System.Windows.Forms.Button btnRestore;
    }
}