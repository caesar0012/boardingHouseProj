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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridRoom = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.clmnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGrid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGrid.Controls.Add(this.gridRoom);
            this.panelGrid.Location = new System.Drawing.Point(91, 107);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1191, 463);
            this.panelGrid.TabIndex = 10;
            // 
            // gridRoom
            // 
            this.gridRoom.AllowUserToDeleteRows = false;
            this.gridRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnRoom,
            this.clmnDesc,
            this.clmnCapacity,
            this.Column5,
            this.clmnStatus,
            this.clmnEdit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRoom.EnableHeadersVisualStyles = false;
            this.gridRoom.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridRoom.Location = new System.Drawing.Point(0, 0);
            this.gridRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridRoom.Name = "gridRoom";
            this.gridRoom.RowHeadersVisible = false;
            this.gridRoom.RowHeadersWidth = 51;
            this.gridRoom.Size = new System.Drawing.Size(1187, 459);
            this.gridRoom.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(788, 602);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 44);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayment.BackColor = System.Drawing.Color.IndianRed;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(1067, 602);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(139, 44);
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
            this.btnMaintain.Location = new System.Drawing.Point(464, 602);
            this.btnMaintain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(139, 44);
            this.btnMaintain.TabIndex = 14;
            this.btnMaintain.Text = "Maintenance";
            this.btnMaintain.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1179, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 44);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clmnRoom
            // 
            this.clmnRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnRoom.FillWeight = 87.19263F;
            this.clmnRoom.HeaderText = "Room";
            this.clmnRoom.MinimumWidth = 2;
            this.clmnRoom.Name = "clmnRoom";
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
            this.clmnCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnCapacity.FillWeight = 89.98338F;
            this.clmnCapacity.HeaderText = "Capacity";
            this.clmnCapacity.MinimumWidth = 6;
            this.clmnCapacity.Name = "clmnCapacity";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 127;
            // 
            // clmnStatus
            // 
            this.clmnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnStatus.FillWeight = 89.98338F;
            this.clmnStatus.HeaderText = "Status";
            this.clmnStatus.Items.AddRange(new object[] {
            "Available",
            "Maintenance",
            "Renovation",
            "Destroyed"});
            this.clmnStatus.MinimumWidth = 6;
            this.clmnStatus.Name = "clmnStatus";
            this.clmnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.NullValue = "Options";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmnEdit.HeaderText = "";
            this.clmnEdit.MinimumWidth = 6;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Text = "";
            this.clmnEdit.Width = 125;
            // 
            // frmManage_rm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1333, 697);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManage_rm";
            this.Text = "frm_Manage_rm";
            this.Load += new System.EventHandler(this.frmManage_rm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridRoom;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmnStatus;
        private System.Windows.Forms.DataGridViewButtonColumn clmnEdit;
    }
}