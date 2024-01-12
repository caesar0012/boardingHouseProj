namespace boardingHouseProj
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.flpTenant = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowTenant = new System.Windows.Forms.Button();
            this.btnCreateTenant = new System.Windows.Forms.Button();
            this.btnManageTenant = new System.Windows.Forms.Button();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnManageRoom = new System.Windows.Forms.Button();
            this.flpStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.flpAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAdmin = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnBackReco = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.profileMain = new boardingHouseProj.RoundPictureBox();
            this.timeNavi = new System.Windows.Forms.Timer(this.components);
            this.TimeTenant = new System.Windows.Forms.Timer(this.components);
            this.TimeRoom = new System.Windows.Forms.Timer(this.components);
            this.TimeStaff = new System.Windows.Forms.Timer(this.components);
            this.TimeAdmin = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flpMain.SuspendLayout();
            this.flpTenant.SuspendLayout();
            this.flpRoom.SuspendLayout();
            this.flpStaff.SuspendLayout();
            this.flpAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileMain)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpMain.Controls.Add(this.btnPay);
            this.flpMain.Controls.Add(this.btnDashBoard);
            this.flpMain.Controls.Add(this.flpTenant);
            this.flpMain.Controls.Add(this.flpRoom);
            this.flpMain.Controls.Add(this.flpStaff);
            this.flpMain.Controls.Add(this.flpAdmin);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMain.Location = new System.Drawing.Point(0, 106);
            this.flpMain.Margin = new System.Windows.Forms.Padding(4);
            this.flpMain.MaximumSize = new System.Drawing.Size(248, 617);
            this.flpMain.MinimumSize = new System.Drawing.Size(88, 617);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(88, 617);
            this.flpMain.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(4, 4);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(240, 66);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "        Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(4, 78);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(240, 66);
            this.btnDashBoard.TabIndex = 13;
            this.btnDashBoard.Text = "           DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click_1);
            // 
            // flpTenant
            // 
            this.flpTenant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpTenant.Controls.Add(this.btnShowTenant);
            this.flpTenant.Controls.Add(this.btnCreateTenant);
            this.flpTenant.Controls.Add(this.btnManageTenant);
            this.flpTenant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpTenant.Location = new System.Drawing.Point(1, 149);
            this.flpTenant.Margin = new System.Windows.Forms.Padding(1);
            this.flpTenant.MaximumSize = new System.Drawing.Size(239, 172);
            this.flpTenant.MinimumSize = new System.Drawing.Size(239, 66);
            this.flpTenant.Name = "flpTenant";
            this.flpTenant.Size = new System.Drawing.Size(239, 66);
            this.flpTenant.TabIndex = 13;
            // 
            // btnShowTenant
            // 
            this.btnShowTenant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowTenant.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowTenant.FlatAppearance.BorderSize = 0;
            this.btnShowTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTenant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowTenant.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTenant.Image")));
            this.btnShowTenant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTenant.Location = new System.Drawing.Point(4, 4);
            this.btnShowTenant.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowTenant.Name = "btnShowTenant";
            this.btnShowTenant.Size = new System.Drawing.Size(235, 66);
            this.btnShowTenant.TabIndex = 13;
            this.btnShowTenant.Text = "Tenant";
            this.btnShowTenant.UseVisualStyleBackColor = false;
            this.btnShowTenant.Click += new System.EventHandler(this.btnShowTenant_Click);
            // 
            // btnCreateTenant
            // 
            this.btnCreateTenant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateTenant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateTenant.FlatAppearance.BorderSize = 0;
            this.btnCreateTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTenant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCreateTenant.Location = new System.Drawing.Point(4, 78);
            this.btnCreateTenant.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTenant.Name = "btnCreateTenant";
            this.btnCreateTenant.Size = new System.Drawing.Size(235, 42);
            this.btnCreateTenant.TabIndex = 14;
            this.btnCreateTenant.Text = "Create Tenant";
            this.btnCreateTenant.UseVisualStyleBackColor = false;
            this.btnCreateTenant.Click += new System.EventHandler(this.btnCreateTenant_Click);
            // 
            // btnManageTenant
            // 
            this.btnManageTenant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManageTenant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageTenant.FlatAppearance.BorderSize = 0;
            this.btnManageTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTenant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnManageTenant.Location = new System.Drawing.Point(4, 128);
            this.btnManageTenant.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageTenant.Name = "btnManageTenant";
            this.btnManageTenant.Size = new System.Drawing.Size(235, 42);
            this.btnManageTenant.TabIndex = 16;
            this.btnManageTenant.Text = "Manage Tenant";
            this.btnManageTenant.UseVisualStyleBackColor = false;
            this.btnManageTenant.Click += new System.EventHandler(this.btnManageTenant_Click_1);
            // 
            // flpRoom
            // 
            this.flpRoom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpRoom.Controls.Add(this.btnShowRoom);
            this.flpRoom.Controls.Add(this.btnReservation);
            this.flpRoom.Controls.Add(this.btnManageRoom);
            this.flpRoom.Location = new System.Drawing.Point(1, 217);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(1);
            this.flpRoom.MaximumSize = new System.Drawing.Size(239, 172);
            this.flpRoom.MinimumSize = new System.Drawing.Size(239, 66);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(239, 66);
            this.flpRoom.TabIndex = 16;
            // 
            // btnShowRoom
            // 
            this.btnShowRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowRoom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowRoom.FlatAppearance.BorderSize = 0;
            this.btnShowRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRoom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnShowRoom.Image")));
            this.btnShowRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowRoom.Location = new System.Drawing.Point(4, 4);
            this.btnShowRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowRoom.Name = "btnShowRoom";
            this.btnShowRoom.Size = new System.Drawing.Size(235, 66);
            this.btnShowRoom.TabIndex = 11;
            this.btnShowRoom.Text = "Room";
            this.btnShowRoom.UseVisualStyleBackColor = false;
            this.btnShowRoom.Click += new System.EventHandler(this.btnShowRoom_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnReservation.Location = new System.Drawing.Point(4, 78);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(235, 38);
            this.btnReservation.TabIndex = 13;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManageRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnManageRoom.FlatAppearance.BorderSize = 0;
            this.btnManageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnManageRoom.Location = new System.Drawing.Point(4, 124);
            this.btnManageRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Size = new System.Drawing.Size(235, 42);
            this.btnManageRoom.TabIndex = 14;
            this.btnManageRoom.Text = "Manage Room";
            this.btnManageRoom.UseVisualStyleBackColor = false;
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // flpStaff
            // 
            this.flpStaff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpStaff.Controls.Add(this.btnShowStaff);
            this.flpStaff.Controls.Add(this.btnCreateEmployee);
            this.flpStaff.Controls.Add(this.btnManageStaff);
            this.flpStaff.Location = new System.Drawing.Point(1, 285);
            this.flpStaff.Margin = new System.Windows.Forms.Padding(1);
            this.flpStaff.MaximumSize = new System.Drawing.Size(239, 172);
            this.flpStaff.MinimumSize = new System.Drawing.Size(239, 66);
            this.flpStaff.Name = "flpStaff";
            this.flpStaff.Size = new System.Drawing.Size(239, 66);
            this.flpStaff.TabIndex = 15;
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowStaff.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowStaff.FlatAppearance.BorderSize = 0;
            this.btnShowStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStaff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnShowStaff.Image")));
            this.btnShowStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowStaff.Location = new System.Drawing.Point(4, 4);
            this.btnShowStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowStaff.MinimumSize = new System.Drawing.Size(213, 66);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(235, 66);
            this.btnShowStaff.TabIndex = 10;
            this.btnShowStaff.Text = "Staff";
            this.btnShowStaff.UseVisualStyleBackColor = false;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateEmployee.FlatAppearance.BorderSize = 0;
            this.btnCreateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmployee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCreateEmployee.Location = new System.Drawing.Point(4, 78);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(235, 42);
            this.btnCreateEmployee.TabIndex = 12;
            this.btnCreateEmployee.Text = "Create Account";
            this.btnCreateEmployee.UseVisualStyleBackColor = false;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManageStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnManageStaff.FlatAppearance.BorderSize = 0;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnManageStaff.Location = new System.Drawing.Point(4, 128);
            this.btnManageStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(235, 38);
            this.btnManageStaff.TabIndex = 11;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = false;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // flpAdmin
            // 
            this.flpAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpAdmin.Controls.Add(this.btnShowAdmin);
            this.flpAdmin.Controls.Add(this.btnActivities);
            this.flpAdmin.Controls.Add(this.btnBackReco);
            this.flpAdmin.Location = new System.Drawing.Point(1, 353);
            this.flpAdmin.Margin = new System.Windows.Forms.Padding(1);
            this.flpAdmin.MaximumSize = new System.Drawing.Size(239, 172);
            this.flpAdmin.MinimumSize = new System.Drawing.Size(239, 66);
            this.flpAdmin.Name = "flpAdmin";
            this.flpAdmin.Size = new System.Drawing.Size(239, 66);
            this.flpAdmin.TabIndex = 16;
            // 
            // btnShowAdmin
            // 
            this.btnShowAdmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowAdmin.FlatAppearance.BorderSize = 0;
            this.btnShowAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdmin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAdmin.Image")));
            this.btnShowAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAdmin.Location = new System.Drawing.Point(4, 4);
            this.btnShowAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAdmin.MinimumSize = new System.Drawing.Size(213, 66);
            this.btnShowAdmin.Name = "btnShowAdmin";
            this.btnShowAdmin.Size = new System.Drawing.Size(235, 66);
            this.btnShowAdmin.TabIndex = 10;
            this.btnShowAdmin.Text = "Admin";
            this.btnShowAdmin.UseVisualStyleBackColor = false;
            this.btnShowAdmin.Click += new System.EventHandler(this.btnShowAdmin_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActivities.BackColor = System.Drawing.Color.Transparent;
            this.btnActivities.FlatAppearance.BorderSize = 0;
            this.btnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivities.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnActivities.Location = new System.Drawing.Point(4, 78);
            this.btnActivities.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(235, 38);
            this.btnActivities.TabIndex = 11;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnBackReco
            // 
            this.btnBackReco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBackReco.BackColor = System.Drawing.Color.Transparent;
            this.btnBackReco.FlatAppearance.BorderSize = 0;
            this.btnBackReco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackReco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnBackReco.Location = new System.Drawing.Point(4, 124);
            this.btnBackReco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackReco.Name = "btnBackReco";
            this.btnBackReco.Size = new System.Drawing.Size(235, 42);
            this.btnBackReco.TabIndex = 12;
            this.btnBackReco.Text = "Backup and Recovery";
            this.btnBackReco.UseVisualStyleBackColor = false;
            this.btnBackReco.Click += new System.EventHandler(this.btnBackReco_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.profileMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 106);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(487, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diaz Rodriguez Boarding House";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1209, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // profileMain
            // 
            this.profileMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileMain.Image = ((System.Drawing.Image)(resources.GetObject("profileMain.Image")));
            this.profileMain.Location = new System.Drawing.Point(9, 1);
            this.profileMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileMain.Name = "profileMain";
            this.profileMain.Size = new System.Drawing.Size(116, 97);
            this.profileMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileMain.TabIndex = 4;
            this.profileMain.TabStop = false;
            this.profileMain.Click += new System.EventHandler(this.profileMain_Click);
            // 
            // timeNavi
            // 
            this.timeNavi.Interval = 5;
            this.timeNavi.Tick += new System.EventHandler(this.timeNavi_Tick);
            // 
            // TimeTenant
            // 
            this.TimeTenant.Interval = 10;
            this.TimeTenant.Tick += new System.EventHandler(this.TimeTenant_Tick);
            // 
            // TimeRoom
            // 
            this.TimeRoom.Interval = 10;
            this.TimeRoom.Tick += new System.EventHandler(this.TimeRoom_Tick);
            // 
            // TimeStaff
            // 
            this.TimeStaff.Interval = 10;
            this.TimeStaff.Tick += new System.EventHandler(this.TimeStaff_Tick);
            // 
            // TimeAdmin
            // 
            this.TimeAdmin.Interval = 10;
            this.TimeAdmin.Tick += new System.EventHandler(this.TimeAdmin_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1327, 724);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.flpMain.ResumeLayout(false);
            this.flpTenant.ResumeLayout(false);
            this.flpRoom.ResumeLayout(false);
            this.flpStaff.ResumeLayout(false);
            this.flpAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.Button btnShowRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private RoundPictureBox profileMain;
        private System.Windows.Forms.FlowLayoutPanel flpTenant;
        private System.Windows.Forms.Button btnShowTenant;
        private System.Windows.Forms.Button btnCreateTenant;
        private System.Windows.Forms.FlowLayoutPanel flpStaff;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnManageRoom;
        private System.Windows.Forms.Timer timeNavi;
        private System.Windows.Forms.Timer TimeTenant;
        private System.Windows.Forms.Timer TimeRoom;
        private System.Windows.Forms.Timer TimeStaff;
        private System.Windows.Forms.FlowLayoutPanel flpAdmin;
        private System.Windows.Forms.Button btnShowAdmin;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnBackReco;
        private System.Windows.Forms.Timer TimeAdmin;
        private System.Windows.Forms.Button btnManageTenant;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPay;
    }
}

