﻿namespace boardingHouseProj
{
    partial class frmLogin
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblforgotPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(162, 148);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 254);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(199, 320);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login Account";
            // 
            // lblforgotPassword
            // 
            this.lblforgotPassword.AutoSize = true;
            this.lblforgotPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblforgotPassword.Location = new System.Drawing.Point(181, 447);
            this.lblforgotPassword.Name = "lblforgotPassword";
            this.lblforgotPassword.Size = new System.Drawing.Size(141, 19);
            this.lblforgotPassword.TabIndex = 6;
            this.lblforgotPassword.Text = "Forgot Password?";
            this.lblforgotPassword.Click += new System.EventHandler(this.lblforgotPassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(398, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 32);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(500, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblforgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblforgotPassword;
        private System.Windows.Forms.Button btnClose;
    }
}