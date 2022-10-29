﻿namespace Group11_SEN381_Project.Presentation
{
    partial class ClientDetailEdit_Create
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
            this.CreateEditTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ClientEditCreate = new System.Windows.Forms.TabPage();
            this.MedicalTabPage = new System.Windows.Forms.TabPage();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveClient = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxDependents = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxNationalId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxId = new MaterialSkin.Controls.MaterialTextBox();
            this.CreateEditTabControl.SuspendLayout();
            this.ClientEditCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateEditTabControl
            // 
            this.CreateEditTabControl.Controls.Add(this.ClientEditCreate);
            this.CreateEditTabControl.Controls.Add(this.MedicalTabPage);
            this.CreateEditTabControl.Depth = 0;
            this.CreateEditTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateEditTabControl.Location = new System.Drawing.Point(0, 0);
            this.CreateEditTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateEditTabControl.Multiline = true;
            this.CreateEditTabControl.Name = "CreateEditTabControl";
            this.CreateEditTabControl.SelectedIndex = 0;
            this.CreateEditTabControl.Size = new System.Drawing.Size(677, 605);
            this.CreateEditTabControl.TabIndex = 43;
            // 
            // ClientEditCreate
            // 
            this.ClientEditCreate.Controls.Add(this.btnCancel);
            this.ClientEditCreate.Controls.Add(this.btnSaveClient);
            this.ClientEditCreate.Controls.Add(this.txtBoxDependents);
            this.ClientEditCreate.Controls.Add(this.txtBoxNationalId);
            this.ClientEditCreate.Controls.Add(this.txtBoxPhoneNumber);
            this.ClientEditCreate.Controls.Add(this.txtBoxEmail);
            this.ClientEditCreate.Controls.Add(this.txtBoxFullName);
            this.ClientEditCreate.Controls.Add(this.txtBoxAddress);
            this.ClientEditCreate.Controls.Add(this.txtBoxId);
            this.ClientEditCreate.Location = new System.Drawing.Point(4, 22);
            this.ClientEditCreate.Name = "ClientEditCreate";
            this.ClientEditCreate.Padding = new System.Windows.Forms.Padding(3);
            this.ClientEditCreate.Size = new System.Drawing.Size(669, 579);
            this.ClientEditCreate.TabIndex = 0;
            this.ClientEditCreate.Text = "Client";
            this.ClientEditCreate.UseVisualStyleBackColor = true;
            // 
            // MedicalTabPage
            // 
            this.MedicalTabPage.Location = new System.Drawing.Point(4, 22);
            this.MedicalTabPage.Name = "MedicalTabPage";
            this.MedicalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MedicalTabPage.Size = new System.Drawing.Size(669, 579);
            this.MedicalTabPage.TabIndex = 1;
            this.MedicalTabPage.Text = "Medical";
            this.MedicalTabPage.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(223, 464);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveClient.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveClient.Depth = 0;
            this.btnSaveClient.HighEmphasis = true;
            this.btnSaveClient.Icon = null;
            this.btnSaveClient.Location = new System.Drawing.Point(125, 464);
            this.btnSaveClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveClient.Size = new System.Drawing.Size(64, 36);
            this.btnSaveClient.TabIndex = 43;
            this.btnSaveClient.Tag = "";
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveClient.UseAccentColor = false;
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // txtBoxDependents
            // 
            this.txtBoxDependents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDependents.AnimateReadOnly = false;
            this.txtBoxDependents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDependents.Depth = 0;
            this.txtBoxDependents.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDependents.Hint = "Dependents";
            this.txtBoxDependents.LeadingIcon = null;
            this.txtBoxDependents.Location = new System.Drawing.Point(8, 388);
            this.txtBoxDependents.MaxLength = 50;
            this.txtBoxDependents.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxDependents.Multiline = false;
            this.txtBoxDependents.Name = "txtBoxDependents";
            this.txtBoxDependents.Size = new System.Drawing.Size(292, 50);
            this.txtBoxDependents.TabIndex = 50;
            this.txtBoxDependents.Text = "";
            this.txtBoxDependents.TrailingIcon = null;
            // 
            // txtBoxNationalId
            // 
            this.txtBoxNationalId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNationalId.AnimateReadOnly = false;
            this.txtBoxNationalId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNationalId.Depth = 0;
            this.txtBoxNationalId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxNationalId.Hint = "National ID";
            this.txtBoxNationalId.LeadingIcon = null;
            this.txtBoxNationalId.Location = new System.Drawing.Point(316, 388);
            this.txtBoxNationalId.MaxLength = 50;
            this.txtBoxNationalId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxNationalId.Multiline = false;
            this.txtBoxNationalId.Name = "txtBoxNationalId";
            this.txtBoxNationalId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxNationalId.TabIndex = 49;
            this.txtBoxNationalId.Text = "";
            this.txtBoxNationalId.TrailingIcon = null;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhoneNumber.AnimateReadOnly = false;
            this.txtBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhoneNumber.Depth = 0;
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPhoneNumber.Hint = "Phone Number";
            this.txtBoxPhoneNumber.LeadingIcon = null;
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(8, 304);
            this.txtBoxPhoneNumber.MaxLength = 50;
            this.txtBoxPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPhoneNumber.Multiline = false;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPhoneNumber.TabIndex = 48;
            this.txtBoxPhoneNumber.Text = "";
            this.txtBoxPhoneNumber.TrailingIcon = null;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmail.AnimateReadOnly = false;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Depth = 0;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEmail.Hint = "Email";
            this.txtBoxEmail.LeadingIcon = null;
            this.txtBoxEmail.Location = new System.Drawing.Point(316, 304);
            this.txtBoxEmail.MaxLength = 50;
            this.txtBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(292, 50);
            this.txtBoxEmail.TabIndex = 47;
            this.txtBoxEmail.Text = "";
            this.txtBoxEmail.TrailingIcon = null;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFullName.AnimateReadOnly = false;
            this.txtBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFullName.Depth = 0;
            this.txtBoxFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxFullName.Hint = "Full Name";
            this.txtBoxFullName.LeadingIcon = null;
            this.txtBoxFullName.Location = new System.Drawing.Point(8, 157);
            this.txtBoxFullName.MaxLength = 50;
            this.txtBoxFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxFullName.Multiline = false;
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxFullName.TabIndex = 46;
            this.txtBoxFullName.Text = "";
            this.txtBoxFullName.TrailingIcon = null;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAddress.AnimateReadOnly = false;
            this.txtBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddress.Depth = 0;
            this.txtBoxAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxAddress.Hint = "Address";
            this.txtBoxAddress.LeadingIcon = null;
            this.txtBoxAddress.Location = new System.Drawing.Point(8, 228);
            this.txtBoxAddress.MaxLength = 50;
            this.txtBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxAddress.Multiline = false;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(600, 50);
            this.txtBoxAddress.TabIndex = 45;
            this.txtBoxAddress.Text = "";
            this.txtBoxAddress.TrailingIcon = null;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxId.AnimateReadOnly = false;
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxId.Depth = 0;
            this.txtBoxId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxId.Hint = "ID";
            this.txtBoxId.LeadingIcon = null;
            this.txtBoxId.Location = new System.Drawing.Point(8, 82);
            this.txtBoxId.MaxLength = 50;
            this.txtBoxId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxId.Multiline = false;
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxId.TabIndex = 44;
            this.txtBoxId.Text = "";
            this.txtBoxId.TrailingIcon = null;
            // 
            // ClientDetailEdit_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 605);
            this.Controls.Add(this.CreateEditTabControl);
            this.Name = "ClientDetailEdit_Create";
            this.Text = "ClientDetailEdit_Create";
            this.Load += new System.EventHandler(this.ClientDetailEdit_Create_Load);
            this.CreateEditTabControl.ResumeLayout(false);
            this.ClientEditCreate.ResumeLayout(false);
            this.ClientEditCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl CreateEditTabControl;
        private System.Windows.Forms.TabPage ClientEditCreate;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSaveClient;
        private MaterialSkin.Controls.MaterialTextBox txtBoxDependents;
        private MaterialSkin.Controls.MaterialTextBox txtBoxNationalId;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox txtBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox txtBoxFullName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxAddress;
        private MaterialSkin.Controls.MaterialTextBox txtBoxId;
        private System.Windows.Forms.TabPage MedicalTabPage;
    }
}