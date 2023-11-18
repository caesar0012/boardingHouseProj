namespace boardingHouseProj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.DataGridRoom = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.Clmn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bed";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room Type";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(68, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(484, 489);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 20);
            this.textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 489);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGrid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrid.Controls.Add(this.DataGridRoom);
            this.panelGrid.Location = new System.Drawing.Point(68, 87);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(894, 256);
            this.panelGrid.TabIndex = 10;
            // 
            // DataGridRoom
            // 
            this.DataGridRoom.AllowUserToDeleteRows = false;
            this.DataGridRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clmn_customer,
            this.clmnRoomNumber,
            this.clmnRoomType,
            this.clmnBed,
            this.clmnPrice,
            this.clmnStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridRoom.EnableHeadersVisualStyles = false;
            this.DataGridRoom.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridRoom.Location = new System.Drawing.Point(0, 0);
            this.DataGridRoom.Name = "DataGridRoom";
            this.DataGridRoom.RowHeadersVisible = false;
            this.DataGridRoom.Size = new System.Drawing.Size(890, 252);
            this.DataGridRoom.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(484, 409);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(800, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayment.BackColor = System.Drawing.Color.IndianRed;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(800, 489);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(104, 36);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnMaintain
            // 
            this.btnMaintain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaintain.BackColor = System.Drawing.Color.IndianRed;
            this.btnMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintain.Location = new System.Drawing.Point(800, 393);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(104, 36);
            this.btnMaintain.TabIndex = 14;
            this.btnMaintain.Text = "Maintenance";
            this.btnMaintain.UseVisualStyleBackColor = false;
            // 
            // Clmn_customer
            // 
            this.Clmn_customer.HeaderText = "Customer Name";
            this.Clmn_customer.Name = "Clmn_customer";
            // 
            // clmnRoomNumber
            // 
            this.clmnRoomNumber.HeaderText = "Room Number";
            this.clmnRoomNumber.Name = "clmnRoomNumber";
            // 
            // clmnRoomType
            // 
            this.clmnRoomType.HeaderText = "Room Type";
            this.clmnRoomType.Name = "clmnRoomType";
            // 
            // clmnBed
            // 
            this.clmnBed.HeaderText = "Bed";
            this.clmnBed.Name = "clmnBed";
            // 
            // clmnPrice
            // 
            this.clmnPrice.HeaderText = "Price";
            this.clmnPrice.Name = "clmnPrice";
            // 
            // clmnStatus
            // 
            this.clmnStatus.HeaderText = "Status";
            this.clmnStatus.Items.AddRange(new object[] {
            "Occupied",
            "Maintenance",
            "Destroyed",
            "Under Renovation",
            "Available"});
            this.clmnStatus.Name = "clmnStatus";
            this.clmnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmManage_rm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1000, 566);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManage_rm";
            this.Text = "frm_Manage_rm";
            this.Load += new System.EventHandler(this.frmManage_rm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DataGridRoom;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clmn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmnStatus;
    }
}