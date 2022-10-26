﻿namespace Group11_SEN381_Project.Presentation
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
            this.materialButton11 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton12 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton13 = new MaterialSkin.Controls.MaterialButton();
            this.cmbExpired = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyType = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyFee = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyDate = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyId = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialListView3
            // 
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
            // materialButton11
            // 
            this.materialButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton11.Depth = 0;
            this.materialButton11.HighEmphasis = true;
            this.materialButton11.Icon = null;
            this.materialButton11.Location = new System.Drawing.Point(940, 475);
            this.materialButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton11.Name = "materialButton11";
            this.materialButton11.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton11.Size = new System.Drawing.Size(73, 36);
            this.materialButton11.TabIndex = 39;
            this.materialButton11.Tag = "";
            this.materialButton11.Text = "Delete";
            this.materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton11.UseAccentColor = false;
            this.materialButton11.UseVisualStyleBackColor = true;
            // 
            // materialButton12
            // 
            this.materialButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton12.Depth = 0;
            this.materialButton12.HighEmphasis = true;
            this.materialButton12.Icon = null;
            this.materialButton12.Location = new System.Drawing.Point(833, 475);
            this.materialButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton12.Name = "materialButton12";
            this.materialButton12.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton12.Size = new System.Drawing.Size(77, 36);
            this.materialButton12.TabIndex = 38;
            this.materialButton12.Tag = "";
            this.materialButton12.Text = "Update";
            this.materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton12.UseAccentColor = false;
            this.materialButton12.UseVisualStyleBackColor = true;
            // 
            // materialButton13
            // 
            this.materialButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton13.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton13.Depth = 0;
            this.materialButton13.HighEmphasis = true;
            this.materialButton13.Icon = null;
            this.materialButton13.Location = new System.Drawing.Point(721, 475);
            this.materialButton13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton13.Name = "materialButton13";
            this.materialButton13.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton13.Size = new System.Drawing.Size(76, 36);
            this.materialButton13.TabIndex = 37;
            this.materialButton13.Tag = "";
            this.materialButton13.Text = "Create";
            this.materialButton13.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton13.UseAccentColor = false;
            this.materialButton13.UseVisualStyleBackColor = true;
            // 
            // cmbExpired
            // 
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
            // materialButton9
            // 
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(335, 22);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(78, 36);
            this.materialButton9.TabIndex = 35;
            this.materialButton9.Tag = "";
            this.materialButton9.Text = "Search";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            // 
            // materialTextBox10
            // 
            this.materialTextBox10.AnimateReadOnly = false;
            this.materialTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox10.Depth = 0;
            this.materialTextBox10.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox10.Hint = "Search ID";
            this.materialTextBox10.LeadingIcon = null;
            this.materialTextBox10.Location = new System.Drawing.Point(15, 8);
            this.materialTextBox10.MaxLength = 50;
            this.materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox10.Multiline = false;
            this.materialTextBox10.Name = "materialTextBox10";
            this.materialTextBox10.Size = new System.Drawing.Size(292, 50);
            this.materialTextBox10.TabIndex = 34;
            this.materialTextBox10.Text = "";
            this.materialTextBox10.TrailingIcon = null;
            // 
            // txtBoxPolicyType
            // 
            this.txtBoxPolicyType.AnimateReadOnly = false;
            this.txtBoxPolicyType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyType.Depth = 0;
            this.txtBoxPolicyType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyType.Hint = "Type of Policy";
            this.txtBoxPolicyType.LeadingIcon = null;
            this.txtBoxPolicyType.Location = new System.Drawing.Point(720, 269);
            this.txtBoxPolicyType.MaxLength = 50;
            this.txtBoxPolicyType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyType.Multiline = false;
            this.txtBoxPolicyType.Name = "txtBoxPolicyType";
            this.txtBoxPolicyType.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyType.TabIndex = 33;
            this.txtBoxPolicyType.Text = "";
            this.txtBoxPolicyType.TrailingIcon = null;
            // 
            // txtBoxPolicyFee
            // 
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
            this.txtBoxPolicyId.AnimateReadOnly = false;
            this.txtBoxPolicyId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyId.Depth = 0;
            this.txtBoxPolicyId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyId.Hint = "ID";
            this.txtBoxPolicyId.LeadingIcon = null;
            this.txtBoxPolicyId.Location = new System.Drawing.Point(720, 64);
            this.txtBoxPolicyId.MaxLength = 50;
            this.txtBoxPolicyId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyId.Multiline = false;
            this.txtBoxPolicyId.Name = "txtBoxPolicyId";
            this.txtBoxPolicyId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyId.TabIndex = 29;
            this.txtBoxPolicyId.Text = "";
            this.txtBoxPolicyId.TrailingIcon = null;
            // 
            // PolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 567);
            this.Controls.Add(this.materialListView3);
            this.Controls.Add(this.materialButton11);
            this.Controls.Add(this.materialButton12);
            this.Controls.Add(this.materialButton13);
            this.Controls.Add(this.cmbExpired);
            this.Controls.Add(this.materialButton9);
            this.Controls.Add(this.materialTextBox10);
            this.Controls.Add(this.txtBoxPolicyType);
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
        private MaterialSkin.Controls.MaterialButton materialButton11;
        private MaterialSkin.Controls.MaterialButton materialButton12;
        private MaterialSkin.Controls.MaterialButton materialButton13;
        private MaterialSkin.Controls.MaterialComboBox cmbExpired;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyType;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyFee;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyDesc;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyDate;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyId;
    }
}