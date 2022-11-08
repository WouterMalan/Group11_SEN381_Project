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
            this.panelClient = new System.Windows.Forms.Panel();
            this.btnSearchClient = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxClientSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxPolicyId = new MaterialSkin.Controls.MaterialTextBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCreateClient = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxDependents = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxNationalId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxId = new MaterialSkin.Controls.MaterialTextBox();
            this.panelClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.btnClear);
            this.panelClient.Controls.Add(this.txtBoxPolicyId);
            this.panelClient.Controls.Add(this.materialListView1);
            this.panelClient.Controls.Add(this.btnDelete);
            this.panelClient.Controls.Add(this.btnUpdate);
            this.panelClient.Controls.Add(this.btnCreateClient);
            this.panelClient.Controls.Add(this.txtBoxDependents);
            this.panelClient.Controls.Add(this.txtBoxNationalId);
            this.panelClient.Controls.Add(this.txtBoxPhoneNumber);
            this.panelClient.Controls.Add(this.txtBoxEmail);
            this.panelClient.Controls.Add(this.txtBoxFullName);
            this.panelClient.Controls.Add(this.txtBoxAddress);
            this.panelClient.Controls.Add(this.txtBoxId);
            this.panelClient.Controls.Add(this.btnSearchClient);
            this.panelClient.Controls.Add(this.txtBoxClientSearch);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClient.Location = new System.Drawing.Point(0, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(1068, 700);
            this.panelClient.TabIndex = 0;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchClient.Depth = 0;
            this.btnSearchClient.HighEmphasis = true;
            this.btnSearchClient.Icon = null;
            this.btnSearchClient.Location = new System.Drawing.Point(391, 36);
            this.btnSearchClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchClient.Size = new System.Drawing.Size(78, 36);
            this.btnSearchClient.TabIndex = 52;
            this.btnSearchClient.Tag = "";
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchClient.UseAccentColor = false;
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // txtBoxClientSearch
            // 
            this.txtBoxClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClientSearch.AnimateReadOnly = false;
            this.txtBoxClientSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxClientSearch.Depth = 0;
            this.txtBoxClientSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxClientSearch.Hint = "Search ID";
            this.txtBoxClientSearch.LeadingIcon = null;
            this.txtBoxClientSearch.Location = new System.Drawing.Point(18, 22);
            this.txtBoxClientSearch.MaxLength = 50;
            this.txtBoxClientSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxClientSearch.Multiline = false;
            this.txtBoxClientSearch.Name = "txtBoxClientSearch";
            this.txtBoxClientSearch.Size = new System.Drawing.Size(345, 50);
            this.txtBoxClientSearch.TabIndex = 51;
            this.txtBoxClientSearch.Text = "";
            this.txtBoxClientSearch.TrailingIcon = null;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(732, 588);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 68;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtBoxPolicyId
            // 
            this.txtBoxPolicyId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxPolicyId.AnimateReadOnly = false;
            this.txtBoxPolicyId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyId.Depth = 0;
            this.txtBoxPolicyId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyId.Hint = "Policy ID";
            this.txtBoxPolicyId.LeadingIcon = null;
            this.txtBoxPolicyId.Location = new System.Drawing.Point(732, 514);
            this.txtBoxPolicyId.MaxLength = 50;
            this.txtBoxPolicyId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyId.Multiline = false;
            this.txtBoxPolicyId.Name = "txtBoxPolicyId";
            this.txtBoxPolicyId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyId.TabIndex = 67;
            this.txtBoxPolicyId.Text = "";
            this.txtBoxPolicyId.TrailingIcon = null;
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.columnHeader7,
            this.columnHeader8});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(12, 106);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(702, 538);
            this.materialListView1.TabIndex = 66;
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
            this.columnHeader2.Text = "Full Name";
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
            this.columnHeader7.Text = "National id";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Policy id";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(951, 646);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(844, 646);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Tag = "";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateClient.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreateClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateClient.Depth = 0;
            this.btnCreateClient.HighEmphasis = true;
            this.btnCreateClient.Icon = null;
            this.btnCreateClient.Location = new System.Drawing.Point(732, 646);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateClient.Size = new System.Drawing.Size(76, 36);
            this.btnCreateClient.TabIndex = 56;
            this.btnCreateClient.Tag = "";
            this.btnCreateClient.Text = "Create";
            this.btnCreateClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateClient.UseAccentColor = false;
            this.btnCreateClient.UseVisualStyleBackColor = false;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click_1);
            // 
            // txtBoxDependents
            // 
            this.txtBoxDependents.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxDependents.AnimateReadOnly = false;
            this.txtBoxDependents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDependents.Depth = 0;
            this.txtBoxDependents.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDependents.Hint = "Dependents";
            this.txtBoxDependents.LeadingIcon = null;
            this.txtBoxDependents.Location = new System.Drawing.Point(732, 378);
            this.txtBoxDependents.MaxLength = 50;
            this.txtBoxDependents.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxDependents.Multiline = false;
            this.txtBoxDependents.Name = "txtBoxDependents";
            this.txtBoxDependents.Size = new System.Drawing.Size(292, 50);
            this.txtBoxDependents.TabIndex = 63;
            this.txtBoxDependents.Text = "";
            this.txtBoxDependents.TrailingIcon = null;
            // 
            // txtBoxNationalId
            // 
            this.txtBoxNationalId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxNationalId.AnimateReadOnly = false;
            this.txtBoxNationalId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNationalId.Depth = 0;
            this.txtBoxNationalId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxNationalId.Hint = "National ID";
            this.txtBoxNationalId.LeadingIcon = null;
            this.txtBoxNationalId.Location = new System.Drawing.Point(732, 447);
            this.txtBoxNationalId.MaxLength = 50;
            this.txtBoxNationalId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxNationalId.Multiline = false;
            this.txtBoxNationalId.Name = "txtBoxNationalId";
            this.txtBoxNationalId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxNationalId.TabIndex = 62;
            this.txtBoxNationalId.Text = "";
            this.txtBoxNationalId.TrailingIcon = null;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxPhoneNumber.AnimateReadOnly = false;
            this.txtBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhoneNumber.Depth = 0;
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPhoneNumber.Hint = "Phone Number";
            this.txtBoxPhoneNumber.LeadingIcon = null;
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(732, 246);
            this.txtBoxPhoneNumber.MaxLength = 50;
            this.txtBoxPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPhoneNumber.Multiline = false;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPhoneNumber.TabIndex = 61;
            this.txtBoxPhoneNumber.Text = "";
            this.txtBoxPhoneNumber.TrailingIcon = null;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxEmail.AnimateReadOnly = false;
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmail.Depth = 0;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEmail.Hint = "Email";
            this.txtBoxEmail.LeadingIcon = null;
            this.txtBoxEmail.Location = new System.Drawing.Point(732, 313);
            this.txtBoxEmail.MaxLength = 50;
            this.txtBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxEmail.Multiline = false;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(292, 50);
            this.txtBoxEmail.TabIndex = 60;
            this.txtBoxEmail.Text = "";
            this.txtBoxEmail.TrailingIcon = null;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxFullName.AnimateReadOnly = false;
            this.txtBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFullName.Depth = 0;
            this.txtBoxFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxFullName.Hint = "Full Name";
            this.txtBoxFullName.LeadingIcon = null;
            this.txtBoxFullName.Location = new System.Drawing.Point(732, 108);
            this.txtBoxFullName.MaxLength = 50;
            this.txtBoxFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxFullName.Multiline = false;
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxFullName.TabIndex = 59;
            this.txtBoxFullName.Text = "";
            this.txtBoxFullName.TrailingIcon = null;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxAddress.AnimateReadOnly = false;
            this.txtBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddress.Depth = 0;
            this.txtBoxAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxAddress.Hint = "Address";
            this.txtBoxAddress.LeadingIcon = null;
            this.txtBoxAddress.Location = new System.Drawing.Point(732, 173);
            this.txtBoxAddress.MaxLength = 50;
            this.txtBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxAddress.Multiline = false;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(292, 50);
            this.txtBoxAddress.TabIndex = 58;
            this.txtBoxAddress.Text = "";
            this.txtBoxAddress.TrailingIcon = null;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxId.AnimateReadOnly = false;
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxId.Depth = 0;
            this.txtBoxId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxId.Hint = "ID";
            this.txtBoxId.LeadingIcon = null;
            this.txtBoxId.Location = new System.Drawing.Point(732, 41);
            this.txtBoxId.MaxLength = 50;
            this.txtBoxId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxId.Multiline = false;
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxId.TabIndex = 57;
            this.txtBoxId.Text = "";
            this.txtBoxId.TrailingIcon = null;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 700);
            this.Controls.Add(this.panelClient);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClient;
        private MaterialSkin.Controls.MaterialButton btnSearchClient;
        private MaterialSkin.Controls.MaterialTextBox txtBoxClientSearch;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyId;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCreateClient;
        private MaterialSkin.Controls.MaterialTextBox txtBoxDependents;
        private MaterialSkin.Controls.MaterialTextBox txtBoxNationalId;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox txtBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox txtBoxFullName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxAddress;
        private MaterialSkin.Controls.MaterialTextBox txtBoxId;
    }
}