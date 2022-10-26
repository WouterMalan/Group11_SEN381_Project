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
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTreatment = new FontAwesome.Sharp.IconButton();
            this.bntProvider = new FontAwesome.Sharp.IconButton();
            this.btnPolicy = new FontAwesome.Sharp.IconButton();
            this.btnMedicalCondition = new FontAwesome.Sharp.IconButton();
            this.btnClient = new FontAwesome.Sharp.IconButton();
            this.btnClientCentre = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleShow = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelShadow.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
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
            this.btnTreatment.Text = "Treatment";
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
            this.bntProvider.Text = "Provider";
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
            this.btnPolicy.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnPolicy.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPolicy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPolicy.IconSize = 32;
            this.btnPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolicy.Location = new System.Drawing.Point(0, 320);
            this.btnPolicy.Name = "btnPolicy";
            this.btnPolicy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPolicy.Size = new System.Drawing.Size(220, 60);
            this.btnPolicy.TabIndex = 3;
            this.btnPolicy.Text = "Policy";
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
            this.btnMedicalCondition.Text = "Medical Condition";
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
            this.btnClient.Text = "Client";
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
            this.btnClientCentre.Text = "Call Centre";
            this.btnClientCentre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientCentre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientCentre.UseVisualStyleBackColor = true;
            this.btnClientCentre.Click += new System.EventHandler(this.btnClientCentre_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Group11_SEN381_Project.Properties.Resources.Ukupholisa_Healthcare_logos_transparent;
            this.btnHome.Location = new System.Drawing.Point(3, 45);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(211, 95);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleShow
            // 
            this.panelTitleShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleShow.Controls.Add(this.lblTitleChildForm);
            this.panelTitleShow.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleShow.Location = new System.Drawing.Point(220, 0);
            this.panelTitleShow.Name = "panelTitleShow";
            this.panelTitleShow.Size = new System.Drawing.Size(1046, 75);
            this.panelTitleShow.TabIndex = 2;
            this.panelTitleShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleShow_MouseDown);
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
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Controls.Add(this.panelDesktop);
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1046, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1046, 9);
            this.panelDesktop.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 708);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleShow);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleShow.ResumeLayout(false);
            this.panelTitleShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelShadow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnClientCentre;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnTreatment;
        private FontAwesome.Sharp.IconButton bntProvider;
        private FontAwesome.Sharp.IconButton btnPolicy;
        private FontAwesome.Sharp.IconButton btnMedicalCondition;
        private FontAwesome.Sharp.IconButton btnClient;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleShow;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

