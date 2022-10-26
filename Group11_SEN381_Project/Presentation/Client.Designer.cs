namespace Group11_SEN381_Project.Presentation
{
    partial class Client
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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxDependents = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxNationalId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxId = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(12, 74);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(679, 497);
            this.materialListView1.TabIndex = 27;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name_Surname";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dependents";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "National_id";
            this.columnHeader7.Width = 115;
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(337, 28);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(78, 36);
            this.materialButton4.TabIndex = 26;
            this.materialButton4.Tag = "";
            this.materialButton4.Text = "Search";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBox8.AnimateReadOnly = false;
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox8.Hint = "Search ID";
            this.materialTextBox8.LeadingIcon = null;
            this.materialTextBox8.Location = new System.Drawing.Point(17, 14);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(292, 50);
            this.materialTextBox8.TabIndex = 25;
            this.materialTextBox8.Text = "";
            this.materialTextBox8.TrailingIcon = null;
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(928, 536);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(73, 36);
            this.materialButton3.TabIndex = 24;
            this.materialButton3.Tag = "";
            this.materialButton3.Text = "Delete";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(821, 536);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(77, 36);
            this.materialButton2.TabIndex = 23;
            this.materialButton2.Tag = "";
            this.materialButton2.Text = "Update";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(709, 536);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 15;
            this.materialButton1.Tag = "";
            this.materialButton1.Text = "Create";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // txtBoxDependents
            // 
            this.txtBoxDependents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDependents.AnimateReadOnly = false;
            this.txtBoxDependents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDependents.Depth = 0;
            this.txtBoxDependents.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDependents.Hint = "Dependents";
            this.txtBoxDependents.LeadingIcon = null;
            this.txtBoxDependents.Location = new System.Drawing.Point(709, 392);
            this.txtBoxDependents.MaxLength = 50;
            this.txtBoxDependents.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxDependents.Multiline = false;
            this.txtBoxDependents.Name = "txtBoxDependents";
            this.txtBoxDependents.Size = new System.Drawing.Size(292, 50);
            this.txtBoxDependents.TabIndex = 22;
            this.txtBoxDependents.Text = "";
            this.txtBoxDependents.TrailingIcon = null;
            // 
            // txtBoxNationalId
            // 
            this.txtBoxNationalId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNationalId.AnimateReadOnly = false;
            this.txtBoxNationalId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNationalId.Depth = 0;
            this.txtBoxNationalId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxNationalId.Hint = "National ID";
            this.txtBoxNationalId.LeadingIcon = null;
            this.txtBoxNationalId.Location = new System.Drawing.Point(709, 461);
            this.txtBoxNationalId.MaxLength = 50;
            this.txtBoxNationalId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxNationalId.Multiline = false;
            this.txtBoxNationalId.Name = "txtBoxNationalId";
            this.txtBoxNationalId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxNationalId.TabIndex = 21;
            this.txtBoxNationalId.Text = "";
            this.txtBoxNationalId.TrailingIcon = null;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPhoneNumber.AnimateReadOnly = false;
            this.txtBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhoneNumber.Depth = 0;
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPhoneNumber.Hint = "Phone Number";
            this.txtBoxPhoneNumber.LeadingIcon = null;
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(709, 260);
            this.txtBoxPhoneNumber.MaxLength = 50;
            this.txtBoxPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPhoneNumber.Multiline = false;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPhoneNumber.TabIndex = 20;
            this.txtBoxPhoneNumber.Text = "";
            this.txtBoxPhoneNumber.TrailingIcon = null;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxEmail.AnimateReadOnly = false;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Depth = 0;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEmail.Hint = "Email";
            this.txtBoxEmail.LeadingIcon = null;
            this.txtBoxEmail.Location = new System.Drawing.Point(709, 327);
            this.txtBoxEmail.MaxLength = 50;
            this.txtBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(292, 50);
            this.txtBoxEmail.TabIndex = 19;
            this.txtBoxEmail.Text = "";
            this.txtBoxEmail.TrailingIcon = null;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxFullName.AnimateReadOnly = false;
            this.txtBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFullName.Depth = 0;
            this.txtBoxFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxFullName.Hint = "Full Name";
            this.txtBoxFullName.LeadingIcon = null;
            this.txtBoxFullName.Location = new System.Drawing.Point(709, 122);
            this.txtBoxFullName.MaxLength = 50;
            this.txtBoxFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxFullName.Multiline = false;
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxFullName.TabIndex = 18;
            this.txtBoxFullName.Text = "";
            this.txtBoxFullName.TrailingIcon = null;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxAddress.AnimateReadOnly = false;
            this.txtBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddress.Depth = 0;
            this.txtBoxAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxAddress.Hint = "Address";
            this.txtBoxAddress.LeadingIcon = null;
            this.txtBoxAddress.Location = new System.Drawing.Point(709, 187);
            this.txtBoxAddress.MaxLength = 50;
            this.txtBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxAddress.Multiline = false;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(292, 50);
            this.txtBoxAddress.TabIndex = 17;
            this.txtBoxAddress.Text = "";
            this.txtBoxAddress.TrailingIcon = null;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxId.AnimateReadOnly = false;
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxId.Depth = 0;
            this.txtBoxId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxId.Hint = "ID";
            this.txtBoxId.LeadingIcon = null;
            this.txtBoxId.Location = new System.Drawing.Point(709, 55);
            this.txtBoxId.MaxLength = 50;
            this.txtBoxId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxId.Multiline = false;
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxId.TabIndex = 16;
            this.txtBoxId.Text = "";
            this.txtBoxId.TrailingIcon = null;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 603);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialTextBox8);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.txtBoxDependents);
            this.Controls.Add(this.txtBoxNationalId);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxId);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txtBoxDependents;
        private MaterialSkin.Controls.MaterialTextBox txtBoxNationalId;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox txtBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox txtBoxFullName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxAddress;
        private MaterialSkin.Controls.MaterialTextBox txtBoxId;
    }
}