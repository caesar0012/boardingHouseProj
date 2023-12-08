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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.gridRoom = new System.Windows.Forms.DataGridView();
            this.clmnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStatss = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.IndianRed;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(166, 380);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(104, 36);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // gridRoom
            // 
            this.gridRoom.AllowUserToDeleteRows = false;
            this.gridRoom.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.gridRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnRoom,
            this.clmnDesc,
            this.clmnCapacity,
            this.clmnPrice,
            this.clmnStatss});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRoom.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridRoom.EnableHeadersVisualStyles = false;
            this.gridRoom.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridRoom.Location = new System.Drawing.Point(372, 27);
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.RowHeadersVisible = false;
            this.gridRoom.RowHeadersWidth = 51;
            this.gridRoom.Size = new System.Drawing.Size(506, 373);
            this.gridRoom.TabIndex = 11;
            this.gridRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoom_CellClick);
            this.gridRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoom_CellContentClick);
            this.gridRoom.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRoom_CellEndEdit);
            this.gridRoom.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridRoom_EditingControlShowing);
            // 
            // clmnRoom
            // 
            this.clmnRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnRoom.FillWeight = 87.19263F;
            this.clmnRoom.HeaderText = "Room";
            this.clmnRoom.MinimumWidth = 2;
            this.clmnRoom.Name = "clmnRoom";
            this.clmnRoom.Width = 65;
            // 
            // clmnDesc
            // 
            this.clmnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDesc.FillWeight = 142.8572F;
            this.clmnDesc.HeaderText = "Description";
            this.clmnDesc.MinimumWidth = 6;
            this.clmnDesc.Name = "clmnDesc";
            // 
            // clmnCapacity
            // 
            this.clmnCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnCapacity.FillWeight = 89.98338F;
            this.clmnCapacity.HeaderText = "Capacity";
            this.clmnCapacity.MinimumWidth = 6;
            this.clmnCapacity.Name = "clmnCapacity";
            this.clmnCapacity.Width = 81;
            // 
            // clmnPrice
            // 
            this.clmnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPrice.HeaderText = "Price";
            this.clmnPrice.MinimumWidth = 6;
            this.clmnPrice.Name = "clmnPrice";
            // 
            // clmnStatss
            // 
            this.clmnStatss.HeaderText = "Status";
            this.clmnStatss.Items.AddRange(new object[] {
            "Available",
            "Under Renovation",
            "Destroyed"});
            this.clmnStatss.MinimumWidth = 6;
            this.clmnStatss.Name = "clmnStatss";
            this.clmnStatss.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnStatss.Width = 125;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(68, 325);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 20);
            this.txtPrice.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(68, 268);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(191, 20);
            this.txtCapacity.TabIndex = 21;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Capacity";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(68, 188);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 20);
            this.txtDescription.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(68, 114);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(191, 20);
            this.txtRoomNumber.TabIndex = 17;
            this.txtRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Room Number";
            // 
            // frmManage_rm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(930, 455);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridRoom);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManage_rm";
            this.Text = "frm_Manage_rm";
            this.Load += new System.EventHandler(this.frmManage_rm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.DataGridView gridRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmnStatss;
    }
}