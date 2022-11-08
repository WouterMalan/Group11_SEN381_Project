namespace Group11_SEN381_Project
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelTitleShow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnTreatment = new FontAwesome.Sharp.IconButton();
            this.bntProvider = new FontAwesome.Sharp.IconButton();
            this.btnPolicy = new FontAwesome.Sharp.IconButton();
            this.btnMedicalCondition = new FontAwesome.Sharp.IconButton();
            this.btnClient = new FontAwesome.Sharp.IconButton();
            this.btnClientCentre = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.btnOpenProviders = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btnOpenPolicy = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenClient = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleShow.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.btnTreatment);
            this.panelMenu.Controls.Add(this.bntProvider);
            this.panelMenu.Controls.Add(this.btnPolicy);
            this.panelMenu.Controls.Add(this.btnMedicalCondition);
            this.panelMenu.Controls.Add(this.btnClient);
            this.panelMenu.Controls.Add(this.btnClientCentre);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 708);
            this.panelMenu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(56, 45);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelTitleShow
            // 
            this.panelTitleShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleShow.Controls.Add(this.btnMaximize);
            this.panelTitleShow.Controls.Add(this.btnClose);
            this.panelTitleShow.Controls.Add(this.btnMinimize);
            this.panelTitleShow.Controls.Add(this.lblTitleChildForm);
            this.panelTitleShow.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleShow.Location = new System.Drawing.Point(220, 0);
            this.panelTitleShow.Name = "panelTitleShow";
            this.panelTitleShow.Size = new System.Drawing.Size(1046, 75);
            this.panelTitleShow.TabIndex = 2;
            this.panelTitleShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleShow_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.pieChart1);
            this.panelDesktop.Controls.Add(this.btnOpenProviders);
            this.panelDesktop.Controls.Add(this.btnOpenPolicy);
            this.panelDesktop.Controls.Add(this.materialCard3);
            this.panelDesktop.Controls.Add(this.materialCard2);
            this.panelDesktop.Controls.Add(this.btnOpenClient);
            this.panelDesktop.Controls.Add(this.materialCard1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1046, 633);
            this.panelDesktop.TabIndex = 3;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(122, 28);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMaximize.IconSize = 18;
            this.btnMaximize.Location = new System.Drawing.Point(988, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 19);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(1014, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 19);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(964, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 19);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 36);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnTreatment
            // 
            this.btnTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTreatment.FlatAppearance.BorderSize = 0;
            this.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreatment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTreatment.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.btnTreatment.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTreatment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTreatment.IconSize = 32;
            this.btnTreatment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTreatment.Location = new System.Drawing.Point(0, 440);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTreatment.Size = new System.Drawing.Size(220, 60);
            this.btnTreatment.TabIndex = 5;
            this.btnTreatment.Tag = "Treatment";
            this.btnTreatment.Text = "   Treatment";
            this.btnTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // bntProvider
            // 
            this.bntProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntProvider.FlatAppearance.BorderSize = 0;
            this.bntProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntProvider.ForeColor = System.Drawing.Color.Gainsboro;
            this.bntProvider.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt;
            this.bntProvider.IconColor = System.Drawing.Color.Gainsboro;
            this.bntProvider.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntProvider.IconSize = 32;
            this.bntProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntProvider.Location = new System.Drawing.Point(0, 380);
            this.bntProvider.Name = "bntProvider";
            this.bntProvider.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bntProvider.Size = new System.Drawing.Size(220, 60);
            this.bntProvider.TabIndex = 4;
            this.bntProvider.Tag = "Provider";
            this.bntProvider.Text = "   Provider";
            this.bntProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntProvider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntProvider.UseVisualStyleBackColor = true;
            this.bntProvider.Click += new System.EventHandler(this.bntProvider_Click);
            // 
            // btnPolicy
            // 
            this.btnPolicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPolicy.FlatAppearance.BorderSize = 0;
            this.btnPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolicy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPolicy.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnPolicy.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPolicy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPolicy.IconSize = 32;
            this.btnPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolicy.Location = new System.Drawing.Point(0, 320);
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPolicy.Size = new System.Drawing.Size(220, 60);
            this.btnPolicy.TabIndex = 3;
            this.btnPolicy.Tag = "Polilcy";
            this.btnPolicy.Text = "   Policy";
            this.btnPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPolicy.UseVisualStyleBackColor = true;
            this.btnPolicy.Click += new System.EventHandler(this.btnPolicy_Click);
            // 
            // btnMedicalCondition
            // 
            this.btnMedicalCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicalCondition.FlatAppearance.BorderSize = 0;
            this.btnMedicalCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalCondition.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedicalCondition.IconChar = FontAwesome.Sharp.IconChar.BriefcaseMedical;
            this.btnMedicalCondition.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMedicalCondition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicalCondition.IconSize = 32;
            this.btnMedicalCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalCondition.Location = new System.Drawing.Point(0, 260);
            this.btnMedicalCondition.Name = "btnMedicalCondition";
            this.btnMedicalCondition.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMedicalCondition.Size = new System.Drawing.Size(220, 60);
            this.btnMedicalCondition.TabIndex = 2;
            this.btnMedicalCondition.Tag = "Medical Condition";
            this.btnMedicalCondition.Text = "   Medical Condition";
            this.btnMedicalCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicalCondition.UseVisualStyleBackColor = true;
            this.btnMedicalCondition.Click += new System.EventHandler(this.btnMedicalCondition_Click);
            // 
            // btnClient
            // 
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClient.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClient.IconSize = 32;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 200);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClient.Size = new System.Drawing.Size(220, 60);
            this.btnClient.TabIndex = 1;
            this.btnClient.Tag = "Client";
            this.btnClient.Text = "   Client";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnClientCentre
            // 
            this.btnClientCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientCentre.FlatAppearance.BorderSize = 0;
            this.btnClientCentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientCentre.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientCentre.IconChar = FontAwesome.Sharp.IconChar.PhoneVolume;
            this.btnClientCentre.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientCentre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientCentre.IconSize = 32;
            this.btnClientCentre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientCentre.Location = new System.Drawing.Point(0, 140);
            this.btnClientCentre.Name = "btnClientCentre";
            this.btnClientCentre.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientCentre.Size = new System.Drawing.Size(220, 60);
            this.btnClientCentre.TabIndex = 0;
            this.btnClientCentre.Tag = "Call Centre";
            this.btnClientCentre.Text = "   Call Centre";
            this.btnClientCentre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientCentre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientCentre.UseVisualStyleBackColor = true;
            this.btnClientCentre.Click += new System.EventHandler(this.btnClientCentre_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(179, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 140);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Image = global::Group11_SEN381_Project.Properties.Resources.Ukupholisa_Healthcare_logos_transparent2;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(173, 140);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Group11_SEN381_Project.Properties.Resources.Ukupholisa_Healthcare_logos_transparent2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.Location = new System.Drawing.Point(580, 135);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(345, 411);
            this.pieChart1.TabIndex = 26;
            this.pieChart1.Text = "pieChart1";
            // 
            // btnOpenProviders
            // 
            this.btnOpenProviders.Depth = 0;
            this.btnOpenProviders.Icon = global::Group11_SEN381_Project.Properties.Resources.icons8_close_pane_96;
            this.btnOpenProviders.ImageKey = "(none)";
            this.btnOpenProviders.Location = new System.Drawing.Point(887, 45);
            this.btnOpenProviders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenProviders.Name = "btnOpenProviders";
            this.btnOpenProviders.Size = new System.Drawing.Size(56, 56);
            this.btnOpenProviders.TabIndex = 24;
            this.btnOpenProviders.Text = "materialFloatingActionButton3";
            this.btnOpenProviders.UseVisualStyleBackColor = true;
            this.btnOpenProviders.Click += new System.EventHandler(this.btnOpenProviders_Click);
            // 
            // btnOpenPolicy
            // 
            this.btnOpenPolicy.Depth = 0;
            this.btnOpenPolicy.Icon = global::Group11_SEN381_Project.Properties.Resources.icons8_close_pane_96;
            this.btnOpenPolicy.ImageKey = "(none)";
            this.btnOpenPolicy.Location = new System.Drawing.Point(561, 45);
            this.btnOpenPolicy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPolicy.Name = "btnOpenPolicy";
            this.btnOpenPolicy.Size = new System.Drawing.Size(56, 56);
            this.btnOpenPolicy.TabIndex = 25;
            this.btnOpenPolicy.Text = "materialFloatingActionButton2";
            this.btnOpenPolicy.UseVisualStyleBackColor = true;
            this.btnOpenPolicy.Click += new System.EventHandler(this.btnOpenPolicy_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(672, 18);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(240, 100);
            this.materialCard3.TabIndex = 22;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 54);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "100000";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(15, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(146, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Number of Providers";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(346, 18);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(240, 100);
            this.materialCard2.TabIndex = 23;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "100000";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(15, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Number of Policies";
            // 
            // btnOpenClient
            // 
            this.btnOpenClient.Depth = 0;
            this.btnOpenClient.Icon = global::Group11_SEN381_Project.Properties.Resources.icons8_close_pane_96;
            this.btnOpenClient.ImageKey = "(none)";
            this.btnOpenClient.Location = new System.Drawing.Point(231, 45);
            this.btnOpenClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenClient.Name = "btnOpenClient";
            this.btnOpenClient.Size = new System.Drawing.Size(56, 56);
            this.btnOpenClient.TabIndex = 21;
            this.btnOpenClient.Text = "materialFloatingActionButton1";
            this.btnOpenClient.UseVisualStyleBackColor = true;
            this.btnOpenClient.Click += new System.EventHandler(this.btnOpenClient_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.materialLabel10);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(16, 18);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(240, 100);
            this.materialCard1.TabIndex = 20;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(17, 54);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(55, 19);
            this.materialLabel9.TabIndex = 4;
            this.materialLabel9.Text = "100000";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(17, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(128, 19);
            this.materialLabel10.TabIndex = 3;
            this.materialLabel10.Text = "Number of Clients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 708);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleShow);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitleShow.ResumeLayout(false);
            this.panelTitleShow.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnClientCentre;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnTreatment;
        private FontAwesome.Sharp.IconButton bntProvider;
        private FontAwesome.Sharp.IconButton btnPolicy;
        private FontAwesome.Sharp.IconButton btnMedicalCondition;
        private FontAwesome.Sharp.IconButton btnClient;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelTitleShow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMenu;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnOpenProviders;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnOpenPolicy;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnOpenClient;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
    }
}

