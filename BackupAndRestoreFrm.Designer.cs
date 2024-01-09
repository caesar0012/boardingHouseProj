namespace boardingHouseProj
{
    partial class BackupAndRestoreFrm
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestoreBrwse = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup and Restore";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Location = new System.Drawing.Point(272, 22);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(85, 23);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.IndianRed;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Location = new System.Drawing.Point(272, 108);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(85, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRestoreBrwse
            // 
            this.btnRestoreBrwse.BackColor = System.Drawing.Color.IndianRed;
            this.btnRestoreBrwse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBrwse.Location = new System.Drawing.Point(272, 63);
            this.btnRestoreBrwse.Name = "btnRestoreBrwse";
            this.btnRestoreBrwse.Size = new System.Drawing.Size(85, 23);
            this.btnRestoreBrwse.TabIndex = 6;
            this.btnRestoreBrwse.Text = "Browse";
            this.btnRestoreBrwse.UseVisualStyleBackColor = false;
            this.btnRestoreBrwse.Click += new System.EventHandler(this.btnRestoreBrwse_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(24, 66);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(226, 20);
            this.txtRestore.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnRestoreBrwse);
            this.panel2.Controls.Add(this.txtRestore);
            this.panel2.Location = new System.Drawing.Point(65, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 161);
            this.panel2.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(453, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BackupAndRestoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(541, 264);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupAndRestoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupAndRestoreFrm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestoreBrwse;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
    }
}