namespace Group11_SEN381_Project.Presentation
{
    partial class PolicyForm
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
            this.materialListView3 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.cmbExpired = new MaterialSkin.Controls.MaterialComboBox();
            this.btnPolicySearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxPolicySearch = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxImportance = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyFee = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyId = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialListView3
            // 
            this.materialListView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView3.AutoSizeTable = false;
            this.materialListView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.materialListView3.Depth = 0;
            this.materialListView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView3.FullRowSelect = true;
            this.materialListView3.HideSelection = false;
            this.materialListView3.Location = new System.Drawing.Point(12, 64);
            this.materialListView3.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView3.Name = "materialListView3";
            this.materialListView3.OwnerDraw = true;
            this.materialListView3.Size = new System.Drawing.Size(679, 497);
            this.materialListView3.TabIndex = 40;
            this.materialListView3.UseCompatibleStateImageBehavior = false;
            this.materialListView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "id";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Description";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Date";
            this.columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Type";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Fee";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Expired";
            this.columnHeader16.Width = 120;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(940, 516);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(833, 516);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Tag = "";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreate.Depth = 0;
            this.btnCreate.HighEmphasis = true;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(721, 516);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreate.Size = new System.Drawing.Size(76, 36);
            this.btnCreate.TabIndex = 37;
            this.btnCreate.Tag = "";
            this.btnCreate.Text = "Create";
            this.btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreate.UseAccentColor = false;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbExpired
            // 
            this.cmbExpired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExpired.AutoResize = false;
            this.cmbExpired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbExpired.Depth = 0;
            this.cmbExpired.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbExpired.DropDownHeight = 174;
            this.cmbExpired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpired.DropDownWidth = 121;
            this.cmbExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbExpired.FormattingEnabled = true;
            this.cmbExpired.Hint = "Expired";
            this.cmbExpired.IntegralHeight = false;
            this.cmbExpired.ItemHeight = 43;
            this.cmbExpired.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbExpired.Location = new System.Drawing.Point(721, 404);
            this.cmbExpired.MaxDropDownItems = 4;
            this.cmbExpired.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbExpired.Name = "cmbExpired";
            this.cmbExpired.Size = new System.Drawing.Size(121, 49);
            this.cmbExpired.StartIndex = 0;
            this.cmbExpired.TabIndex = 36;
            // 
            // btnPolicySearch
            // 
            this.btnPolicySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPolicySearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPolicySearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPolicySearch.Depth = 0;
            this.btnPolicySearch.HighEmphasis = true;
            this.btnPolicySearch.Icon = null;
            this.btnPolicySearch.Location = new System.Drawing.Point(335, 22);
            this.btnPolicySearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPolicySearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPolicySearch.Name = "btnPolicySearch";
            this.btnPolicySearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPolicySearch.Size = new System.Drawing.Size(78, 36);
            this.btnPolicySearch.TabIndex = 35;
            this.btnPolicySearch.Tag = "";
            this.btnPolicySearch.Text = "Search";
            this.btnPolicySearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPolicySearch.UseAccentColor = false;
            this.btnPolicySearch.UseVisualStyleBackColor = true;
            this.btnPolicySearch.Click += new System.EventHandler(this.btnPolicySearch_Click);
            // 
            // txtBoxPolicySearch
            // 
            this.txtBoxPolicySearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPolicySearch.AnimateReadOnly = false;
            this.txtBoxPolicySearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicySearch.Depth = 0;
            this.txtBoxPolicySearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicySearch.Hint = "Search ID";
            this.txtBoxPolicySearch.LeadingIcon = null;
            this.txtBoxPolicySearch.Location = new System.Drawing.Point(15, 8);
            this.txtBoxPolicySearch.MaxLength = 50;
            this.txtBoxPolicySearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicySearch.Multiline = false;
            this.txtBoxPolicySearch.Name = "txtBoxPolicySearch";
            this.txtBoxPolicySearch.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicySearch.TabIndex = 34;
            this.txtBoxPolicySearch.Text = "";
            this.txtBoxPolicySearch.TrailingIcon = null;
            // 
            // txtBoxImportance
            // 
            this.txtBoxImportance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxImportance.AnimateReadOnly = false;
            this.txtBoxImportance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxImportance.Depth = 0;
            this.txtBoxImportance.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxImportance.Hint = "Importance";
            this.txtBoxImportance.LeadingIcon = null;
            this.txtBoxImportance.Location = new System.Drawing.Point(720, 269);
            this.txtBoxImportance.MaxLength = 50;
            this.txtBoxImportance.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxImportance.Multiline = false;
            this.txtBoxImportance.Name = "txtBoxImportance";
            this.txtBoxImportance.Size = new System.Drawing.Size(292, 50);
            this.txtBoxImportance.TabIndex = 33;
            this.txtBoxImportance.Text = "";
            this.txtBoxImportance.TrailingIcon = null;
            // 
            // txtBoxPolicyFee
            // 
            this.txtBoxPolicyFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPolicyFee.AnimateReadOnly = false;
            this.txtBoxPolicyFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyFee.Depth = 0;
            this.txtBoxPolicyFee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyFee.Hint = "Fee";
            this.txtBoxPolicyFee.LeadingIcon = null;
            this.txtBoxPolicyFee.Location = new System.Drawing.Point(720, 336);
            this.txtBoxPolicyFee.MaxLength = 50;
            this.txtBoxPolicyFee.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyFee.Multiline = false;
            this.txtBoxPolicyFee.Name = "txtBoxPolicyFee";
            this.txtBoxPolicyFee.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyFee.TabIndex = 32;
            this.txtBoxPolicyFee.Text = "";
            this.txtBoxPolicyFee.TrailingIcon = null;
            // 
            // txtBoxPolicyDesc
            // 
            this.txtBoxPolicyDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPolicyDesc.AnimateReadOnly = false;
            this.txtBoxPolicyDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyDesc.Depth = 0;
            this.txtBoxPolicyDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyDesc.Hint = "Description";
            this.txtBoxPolicyDesc.LeadingIcon = null;
            this.txtBoxPolicyDesc.Location = new System.Drawing.Point(720, 131);
            this.txtBoxPolicyDesc.MaxLength = 50;
            this.txtBoxPolicyDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyDesc.Multiline = false;
            this.txtBoxPolicyDesc.Name = "txtBoxPolicyDesc";
            this.txtBoxPolicyDesc.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyDesc.TabIndex = 31;
            this.txtBoxPolicyDesc.Text = "";
            this.txtBoxPolicyDesc.TrailingIcon = null;
            // 
            // txtBoxPolicyDate
            // 
            this.txtBoxPolicyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPolicyDate.AnimateReadOnly = false;
            this.txtBoxPolicyDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyDate.Depth = 0;
            this.txtBoxPolicyDate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyDate.Hint = "YY/MM/DD";
            this.txtBoxPolicyDate.LeadingIcon = null;
            this.txtBoxPolicyDate.Location = new System.Drawing.Point(720, 196);
            this.txtBoxPolicyDate.MaxLength = 50;
            this.txtBoxPolicyDate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyDate.Multiline = false;
            this.txtBoxPolicyDate.Name = "txtBoxPolicyDate";
            this.txtBoxPolicyDate.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyDate.TabIndex = 30;
            this.txtBoxPolicyDate.Text = "";
            this.txtBoxPolicyDate.TrailingIcon = null;
            // 
            // txtBoxPolicyId
            // 
            this.txtBoxPolicyId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPolicyId.AnimateReadOnly = false;
            this.txtBoxPolicyId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyId.Depth = 0;
            this.txtBoxPolicyId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyId.Hint = "ID";
            this.txtBoxPolicyId.LeadingIcon = null;
            this.txtBoxPolicyId.Location = new System.Drawing.Point(721, 64);
            this.txtBoxPolicyId.MaxLength = 50;
            this.txtBoxPolicyId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyId.Multiline = false;
            this.txtBoxPolicyId.Name = "txtBoxPolicyId";
            this.txtBoxPolicyId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyId.TabIndex = 29;
            this.txtBoxPolicyId.Text = "";
            this.txtBoxPolicyId.TrailingIcon = null;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(720, 468);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(76, 36);
            this.btnClear.TabIndex = 41;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 567);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.materialListView3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbExpired);
            this.Controls.Add(this.btnPolicySearch);
            this.Controls.Add(this.txtBoxPolicySearch);
            this.Controls.Add(this.txtBoxImportance);
            this.Controls.Add(this.txtBoxPolicyFee);
            this.Controls.Add(this.txtBoxPolicyDesc);
            this.Controls.Add(this.txtBoxPolicyDate);
            this.Controls.Add(this.txtBoxPolicyId);
            this.Name = "PolicyForm";
            this.Text = "PollicyForm";
            this.Load += new System.EventHandler(this.PolicyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView3;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private MaterialSkin.Controls.MaterialComboBox cmbExpired;
        private MaterialSkin.Controls.MaterialButton btnPolicySearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicySearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxImportance;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyFee;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyDesc;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyDate;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyId;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}