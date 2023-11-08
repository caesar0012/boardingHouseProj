namespace boardingHouseProj
{
    partial class frmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirstName = new System.Windows.Forms.TextBox();
            this.btnMiddleName = new System.Windows.Forms.TextBox();
            this.btnLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRelationship = new System.Windows.Forms.TextBox();
            this.btnEmergencyContact = new System.Windows.Forms.TextBox();
            this.btnContact = new System.Windows.Forms.TextBox();
            this.btnReserved = new System.Windows.Forms.Button();
            this.btnUnreserved = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkAC = new System.Windows.Forms.CheckBox();
            this.checkWifi = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFirstName
            // 
            this.btnFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFirstName.Location = new System.Drawing.Point(56, 91);
            this.btnFirstName.Name = "btnFirstName";
            this.btnFirstName.Size = new System.Drawing.Size(257, 38);
            this.btnFirstName.TabIndex = 1;
            this.btnFirstName.Text = "First Name*";
            this.btnFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMiddleName
            // 
            this.btnMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMiddleName.Location = new System.Drawing.Point(352, 91);
            this.btnMiddleName.Name = "btnMiddleName";
            this.btnMiddleName.Size = new System.Drawing.Size(257, 38);
            this.btnMiddleName.TabIndex = 2;
            this.btnMiddleName.Text = "Middle Name";
            this.btnMiddleName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLastName
            // 
            this.btnLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLastName.Location = new System.Drawing.Point(668, 91);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(257, 38);
            this.btnLastName.TabIndex = 3;
            this.btnLastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact Information";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Information";
            // 
            // btnRelationship
            // 
            this.btnRelationship.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelationship.Location = new System.Drawing.Point(668, 225);
            this.btnRelationship.Name = "btnRelationship";
            this.btnRelationship.Size = new System.Drawing.Size(257, 38);
            this.btnRelationship.TabIndex = 8;
            this.btnRelationship.Text = "Relationship";
            this.btnRelationship.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnEmergencyContact
            // 
            this.btnEmergencyContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmergencyContact.Location = new System.Drawing.Point(352, 225);
            this.btnEmergencyContact.Name = "btnEmergencyContact";
            this.btnEmergencyContact.Size = new System.Drawing.Size(257, 38);
            this.btnEmergencyContact.TabIndex = 7;
            this.btnEmergencyContact.Text = "Emergency Contact";
            // 
            // btnContact
            // 
            this.btnContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContact.Location = new System.Drawing.Point(56, 225);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(257, 38);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "Contact Number";
            // 
            // btnReserved
            // 
            this.btnReserved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReserved.Location = new System.Drawing.Point(730, 366);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(119, 41);
            this.btnReserved.TabIndex = 12;
            this.btnReserved.Text = "Reserve";
            this.btnReserved.UseVisualStyleBackColor = true;
            // 
            // btnUnreserved
            // 
            this.btnUnreserved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnreserved.Location = new System.Drawing.Point(730, 442);
            this.btnUnreserved.Name = "btnUnreserved";
            this.btnUnreserved.Size = new System.Drawing.Size(126, 41);
            this.btnUnreserved.TabIndex = 13;
            this.btnUnreserved.Text = "Unrserved";
            this.btnUnreserved.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(67, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 38);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Number of beds";
            // 
            // checkAC
            // 
            this.checkAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkAC.AutoSize = true;
            this.checkAC.Location = new System.Drawing.Point(67, 415);
            this.checkAC.Name = "checkAC";
            this.checkAC.Size = new System.Drawing.Size(74, 36);
            this.checkAC.TabIndex = 16;
            this.checkAC.Text = "AC";
            this.checkAC.UseVisualStyleBackColor = true;
            // 
            // checkWifi
            // 
            this.checkWifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkWifi.AutoSize = true;
            this.checkWifi.Location = new System.Drawing.Point(67, 455);
            this.checkWifi.Name = "checkWifi";
            this.checkWifi.Size = new System.Drawing.Size(83, 36);
            this.checkWifi.TabIndex = 17;
            this.checkWifi.Text = "Wifi";
            this.checkWifi.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(308, 366);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 117);
            this.textBox2.TabIndex = 18;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkWifi);
            this.Controls.Add(this.checkAC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUnreserved);
            this.Controls.Add(this.btnReserved);
            this.Controls.Add(this.btnRelationship);
            this.Controls.Add(this.btnEmergencyContact);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnMiddleName);
            this.Controls.Add(this.btnFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPersonal_infoCx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnFirstName;
        private System.Windows.Forms.TextBox btnMiddleName;
        private System.Windows.Forms.TextBox btnLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btnRelationship;
        private System.Windows.Forms.TextBox btnEmergencyContact;
        private System.Windows.Forms.TextBox btnContact;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button btnUnreserved;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkAC;
        private System.Windows.Forms.CheckBox checkWifi;
        private System.Windows.Forms.TextBox textBox2;
    }
}