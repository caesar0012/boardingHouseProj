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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnManageRoom = new System.Windows.Forms.Button();
            this.flpTenant = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowTenant = new System.Windows.Forms.Button();
            this.btnManageTenant = new System.Windows.Forms.Button();
            this.btnCreateTenant = new System.Windows.Forms.Button();
            this.flpStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timeNavi = new System.Windows.Forms.Timer(this.components);
            this.TimeTenant = new System.Windows.Forms.Timer(this.components);
            this.TimeRoom = new System.Windows.Forms.Timer(this.components);
            this.TimeStaff = new System.Windows.Forms.Timer(this.components);
            this.flpAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAdmin = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnBackReco = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.TimeAdmin = new System.Windows.Forms.Timer(this.components);
            this.profileMain = new boardingHouseProj.RoundPictureBox();
            this.flpMain.SuspendLayout();
            this.flpRoom.SuspendLayout();
            this.flpTenant.SuspendLayout();
            this.flpStaff.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileMain)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpMain.Controls.Add(this.btnMenu);
            this.flpMain.Controls.Add(this.btnDashBoard);
            this.flpMain.Controls.Add(this.flpRoom);
            this.flpMain.Controls.Add(this.flpTenant);
            this.flpMain.Controls.Add(this.flpAdmin);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMain.Location = new System.Drawing.Point(0, 87);
            this.flpMain.MaximumSize = new System.Drawing.Size(186, 501);
            this.flpMain.MinimumSize = new System.Drawing.Size(66, 501);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(186, 501);
            this.flpMain.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(180, 50);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "    Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(3, 59);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(180, 54);
            this.btnDashBoard.TabIndex = 13;
            this.btnDashBoard.Text = "           DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click_1);
            // 
            // flpRoom
            // 
            this.flpRoom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpRoom.Controls.Add(this.btnShowRoom);
            this.flpRoom.Controls.Add(this.btnReservation);
            this.flpRoom.Controls.Add(this.btnManageRoom);
            this.flpRoom.Location = new System.Drawing.Point(1, 117);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(1);
            this.flpRoom.MaximumSize = new System.Drawing.Size(179, 140);
            this.flpRoom.MinimumSize = new System.Drawing.Size(179, 54);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(179, 54);
            this.flpRoom.TabIndex = 16;
            // 
            // btnShowRoom
            // 
            this.btnShowRoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowRoom.FlatAppearance.BorderSize = 0;
            this.btnShowRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRoom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnShowRoom.Image")));
            this.btnShowRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowRoom.Location = new System.Drawing.Point(3, 3);
            this.btnShowRoom.Name = "btnShowRoom";
            this.btnShowRoom.Size = new System.Drawing.Size(176, 54);
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
            this.btnReservation.Location = new System.Drawing.Point(3, 63);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(176, 31);
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
            this.btnManageRoom.Location = new System.Drawing.Point(3, 100);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Size = new System.Drawing.Size(176, 34);
            this.btnManageRoom.TabIndex = 14;
            this.btnManageRoom.Text = "Manage Room";
            this.btnManageRoom.UseVisualStyleBackColor = false;
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // flpTenant
            // 
            this.flpTenant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpTenant.Controls.Add(this.btnShowTenant);
            this.flpTenant.Controls.Add(this.btnPayment);
            this.flpTenant.Controls.Add(this.btnManageTenant);
            this.flpTenant.Controls.Add(this.btnCreateTenant);
            this.flpTenant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flpTenant.Location = new System.Drawing.Point(1, 173);
            this.flpTenant.Margin = new System.Windows.Forms.Padding(1);
            this.flpTenant.MaximumSize = new System.Drawing.Size(179, 179);
            this.flpTenant.MinimumSize = new System.Drawing.Size(179, 54);
            this.flpTenant.Name = "flpTenant";
            this.flpTenant.Size = new System.Drawing.Size(179, 54);
            this.flpTenant.TabIndex = 13;
            // 
            // btnShowTenant
            // 
            this.btnShowTenant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowTenant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowTenant.FlatAppearance.BorderSize = 0;
            this.btnShowTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTenant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowTenant.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTenant.Image")));
            this.btnShowTenant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTenant.Location = new System.Drawing.Point(3, 3);
            this.btnShowTenant.Name = "btnShowTenant";
            this.btnShowTenant.Size = new System.Drawing.Size(176, 54);
            this.btnShowTenant.TabIndex = 13;
            this.btnShowTenant.Text = "Tenant";
            this.btnShowTenant.UseVisualStyleBackColor = false;
            this.btnShowTenant.Click += new System.EventHandler(this.btnShowTenant_Click);
            // 
            // btnManageTenant
            // 
            this.btnManageTenant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManageTenant.BackColor = System.Drawing.Color.Transparent;
            this.btnManageTenant.FlatAppearance.BorderSize = 0;
            this.btnManageTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTenant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnManageTenant.Location = new System.Drawing.Point(3, 103);
            this.btnManageTenant.Name = "btnManageTenant";
            this.btnManageTenant.Size = new System.Drawing.Size(176, 34);
            this.btnManageTenant.TabIndex = 12;
            this.btnManageTenant.Text = "Reservation";
            this.btnManageTenant.UseVisualStyleBackColor = false;
            this.btnManageTenant.Click += new System.EventHandler(this.btnManageTenant_Click);
            // 
            // btnCreateTenant
            // 
            this.btnCreateTenant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateTenant.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateTenant.FlatAppearance.BorderSize = 0;
            this.btnCreateTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTenant.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCreateTenant.Location = new System.Drawing.Point(3, 143);
            this.btnCreateTenant.Name = "btnCreateTenant";
            this.btnCreateTenant.Size = new System.Drawing.Size(176, 34);
            this.btnCreateTenant.TabIndex = 14;
            this.btnCreateTenant.Text = "Create Tenant";
            this.btnCreateTenant.UseVisualStyleBackColor = false;
            this.btnCreateTenant.Click += new System.EventHandler(this.btnCreateTenant_Click);
            // 
            // flpStaff
            // 
            this.flpStaff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpStaff.Controls.Add(this.btnShowStaff);
            this.flpStaff.Controls.Add(this.btnManageStaff);
            this.flpStaff.Controls.Add(this.btnCreateEmployee);
            this.flpStaff.Location = new System.Drawing.Point(690, 175);
            this.flpStaff.Margin = new System.Windows.Forms.Padding(1);
            this.flpStaff.MaximumSize = new System.Drawing.Size(179, 140);
            this.flpStaff.MinimumSize = new System.Drawing.Size(179, 54);
            this.flpStaff.Name = "flpStaff";
            this.flpStaff.Size = new System.Drawing.Size(179, 140);
            this.flpStaff.TabIndex = 15;
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowStaff.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowStaff.FlatAppearance.BorderSize = 0;
            this.btnShowStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStaff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnShowStaff.Image")));
            this.btnShowStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowStaff.Location = new System.Drawing.Point(3, 3);
            this.btnShowStaff.MinimumSize = new System.Drawing.Size(160, 54);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(176, 54);
            this.btnShowStaff.TabIndex = 10;
            this.btnShowStaff.Text = "Staff";
            this.btnShowStaff.UseVisualStyleBackColor = false;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnManageStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnManageStaff.FlatAppearance.BorderSize = 0;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnManageStaff.Location = new System.Drawing.Point(3, 63);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(176, 31);
            this.btnManageStaff.TabIndex = 11;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = false;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateEmployee.FlatAppearance.BorderSize = 0;
            this.btnCreateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmployee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCreateEmployee.Location = new System.Drawing.Point(3, 100);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(176, 34);
            this.btnCreateEmployee.TabIndex = 12;
            this.btnCreateEmployee.Text = "Create Account";
            this.btnCreateEmployee.UseVisualStyleBackColor = false;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 87);
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
            this.label1.Location = new System.Drawing.Point(365, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diaz Rodriguez Boarding House";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(781, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timeNavi
            // 
            this.timeNavi.Interval = 10;
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
            // flpAdmin
            // 
            this.flpAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpAdmin.Controls.Add(this.btnShowAdmin);
            this.flpAdmin.Controls.Add(this.btnActivities);
            this.flpAdmin.Controls.Add(this.btnBackReco);
            this.flpAdmin.Location = new System.Drawing.Point(1, 229);
            this.flpAdmin.Margin = new System.Windows.Forms.Padding(1);
            this.flpAdmin.MaximumSize = new System.Drawing.Size(179, 140);
            this.flpAdmin.MinimumSize = new System.Drawing.Size(179, 54);
            this.flpAdmin.Name = "flpAdmin";
            this.flpAdmin.Size = new System.Drawing.Size(179, 54);
            this.flpAdmin.TabIndex = 16;
            // 
            // btnShowAdmin
            // 
            this.btnShowAdmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAdmin.FlatAppearance.BorderSize = 0;
            this.btnShowAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdmin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnShowAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAdmin.Image")));
            this.btnShowAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAdmin.Location = new System.Drawing.Point(3, 3);
            this.btnShowAdmin.MinimumSize = new System.Drawing.Size(160, 54);
            this.btnShowAdmin.Name = "btnShowAdmin";
            this.btnShowAdmin.Size = new System.Drawing.Size(176, 54);
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
            this.btnActivities.Location = new System.Drawing.Point(3, 63);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(176, 31);
            this.btnActivities.TabIndex = 11;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = false;
            // 
            // btnBackReco
            // 
            this.btnBackReco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBackReco.BackColor = System.Drawing.Color.Transparent;
            this.btnBackReco.FlatAppearance.BorderSize = 0;
            this.btnBackReco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackReco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnBackReco.Location = new System.Drawing.Point(3, 100);
            this.btnBackReco.Name = "btnBackReco";
            this.btnBackReco.Size = new System.Drawing.Size(176, 34);
            this.btnBackReco.TabIndex = 12;
            this.btnBackReco.Text = "Backup and Recovery";
            this.btnBackReco.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPayment.BackColor = System.Drawing.Color.DarkGray;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnPayment.Location = new System.Drawing.Point(3, 63);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(176, 34);
            this.btnPayment.TabIndex = 15;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // TimeAdmin
            // 
            this.TimeAdmin.Interval = 10;
            this.TimeAdmin.Tick += new System.EventHandler(this.TimeAdmin_Tick);
            // 
            // profileMain
            // 
            this.profileMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileMain.Image = ((System.Drawing.Image)(resources.GetObject("profileMain.Image")));
            this.profileMain.Location = new System.Drawing.Point(7, 1);
            this.profileMain.Margin = new System.Windows.Forms.Padding(2);
            this.profileMain.Name = "profileMain";
            this.profileMain.Size = new System.Drawing.Size(87, 79);
            this.profileMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileMain.TabIndex = 4;
            this.profileMain.TabStop = false;
            this.profileMain.Click += new System.EventHandler(this.profileMain_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(995, 588);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.flpMain.ResumeLayout(false);
            this.flpRoom.ResumeLayout(false);
            this.flpTenant.ResumeLayout(false);
            this.flpStaff.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnManageTenant;
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
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flpAdmin;
        private System.Windows.Forms.Button btnShowAdmin;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnBackReco;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Timer TimeAdmin;
    }
}

