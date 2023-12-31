namespace boardingHouseProj
{
    partial class TenantManage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dgTenant = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmergeNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmergencyName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(827, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "FirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(23, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // dgTenant
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dgTenant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTenant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTenant.EnableHeadersVisualStyles = false;
            this.dgTenant.Location = new System.Drawing.Point(421, 55);
            this.dgTenant.Name = "dgTenant";
            this.dgTenant.RowHeadersVisible = false;
            this.dgTenant.Size = new System.Drawing.Size(481, 318);
            this.dgTenant.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gender";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(23, 164);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(150, 20);
            this.txtContact.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contact";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(226, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(226, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(226, 164);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(150, 20);
            this.txtSchool.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "School";
            // 
            // txtEmergeNumber
            // 
            this.txtEmergeNumber.Location = new System.Drawing.Point(226, 241);
            this.txtEmergeNumber.Name = "txtEmergeNumber";
            this.txtEmergeNumber.Size = new System.Drawing.Size(150, 20);
            this.txtEmergeNumber.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Emergency Number";
            // 
            // txtEmergencyName
            // 
            this.txtEmergencyName.Location = new System.Drawing.Point(23, 241);
            this.txtEmergencyName.Name = "txtEmergencyName";
            this.txtEmergencyName.Size = new System.Drawing.Size(150, 20);
            this.txtEmergencyName.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Emegerncy Name";
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(23, 309);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(150, 20);
            this.txtRelationship.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Relationship";
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(154, 381);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(78, 23);
            this.btnView.TabIndex = 27;
            this.btnView.Text = "View File";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(120, 350);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 23);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 27);
            this.label9.TabIndex = 29;
            this.label9.Text = "Manage Tenant";
            // 
            // TenantManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(914, 416);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtRelationship);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmergeNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmergencyName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgTenant);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TenantManage";
            this.Text = "TenantManage";
            this.Load += new System.EventHandler(this.TenantManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView dgTenant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmergeNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmergencyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label9;
    }
}