namespace boardingHouseProj
{
    partial class loadBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadBar));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.timeLoad = new System.Windows.Forms.Timer(this.components);
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMain.Location = new System.Drawing.Point(-2, 215);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(727, 30);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.IndianRed;
            this.pnlProgress.Location = new System.Drawing.Point(1, 215);
            this.pnlProgress.MinimumSize = new System.Drawing.Size(60, 30);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(60, 30);
            this.pnlProgress.TabIndex = 0;
            // 
            // timeLoad
            // 
            this.timeLoad.Enabled = true;
            this.timeLoad.Interval = 15;
            this.timeLoad.Tick += new System.EventHandler(this.timeLoad_Tick);
            // 
            // pbPic
            // 
            this.pbPic.Image = ((System.Drawing.Image)(resources.GetObject("pbPic.Image")));
            this.pbPic.Location = new System.Drawing.Point(-101, -95);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(546, 310);
            this.pbPic.TabIndex = 1;
            this.pbPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(505, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boarding House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(489, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Management System";
            // 
            // loadBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(747, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loadBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadBar";
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Timer timeLoad;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}