namespace boardingHouseProj
{
    partial class dashBoard
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAddon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "DashBoard";
            // 
            // btnReserve
            // 
            this.btnReserve.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Location = new System.Drawing.Point(59, 334);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(126, 31);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "Tenant Reservation";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAddon
            // 
            this.btnAddon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddon.Location = new System.Drawing.Point(233, 334);
            this.btnAddon.Name = "btnAddon";
            this.btnAddon.Size = new System.Drawing.Size(126, 31);
            this.btnAddon.TabIndex = 12;
            this.btnAddon.Text = "Add On";
            this.btnAddon.UseVisualStyleBackColor = false;
            // 
            // dashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(898, 377);
            this.Controls.Add(this.btnAddon);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashBoard";
            this.Text = "dashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnAddon;
    }
}