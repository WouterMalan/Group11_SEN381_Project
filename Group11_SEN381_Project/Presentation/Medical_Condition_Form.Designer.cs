namespace Group11_SEN381_Project.Presentation
{
    partial class Medical_Condition_Form
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
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMedicalConditionSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxMedicalConditionSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDeleteMedicalCondition = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateMedicalCondition = new MaterialSkin.Controls.MaterialButton();
            this.btnCreateMedicalCondition = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxConditionName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPriority = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxConditionId = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialListView2
            // 
            this.materialListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(12, 68);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(679, 497);
            this.materialListView2.TabIndex = 36;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "id";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Condition Name";
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Description";
            this.columnHeader10.Width = 300;
            // 
            // btnMedicalConditionSearch
            // 
            this.btnMedicalConditionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedicalConditionSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMedicalConditionSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMedicalConditionSearch.Depth = 0;
            this.btnMedicalConditionSearch.HighEmphasis = true;
            this.btnMedicalConditionSearch.Icon = null;
            this.btnMedicalConditionSearch.Location = new System.Drawing.Point(332, 26);
            this.btnMedicalConditionSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMedicalConditionSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMedicalConditionSearch.Name = "btnMedicalConditionSearch";
            this.btnMedicalConditionSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMedicalConditionSearch.Size = new System.Drawing.Size(78, 36);
            this.btnMedicalConditionSearch.TabIndex = 35;
            this.btnMedicalConditionSearch.Tag = "";
            this.btnMedicalConditionSearch.Text = "Search";
            this.btnMedicalConditionSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMedicalConditionSearch.UseAccentColor = false;
            this.btnMedicalConditionSearch.UseVisualStyleBackColor = true;
            this.btnMedicalConditionSearch.Click += new System.EventHandler(this.btnMedicalConditionSearch_Click);
            // 
            // txtBoxMedicalConditionSearch
            // 
            this.txtBoxMedicalConditionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMedicalConditionSearch.AnimateReadOnly = false;
            this.txtBoxMedicalConditionSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMedicalConditionSearch.Depth = 0;
            this.txtBoxMedicalConditionSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxMedicalConditionSearch.Hint = "Search ID";
            this.txtBoxMedicalConditionSearch.LeadingIcon = null;
            this.txtBoxMedicalConditionSearch.Location = new System.Drawing.Point(12, 12);
            this.txtBoxMedicalConditionSearch.MaxLength = 50;
            this.txtBoxMedicalConditionSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxMedicalConditionSearch.Multiline = false;
            this.txtBoxMedicalConditionSearch.Name = "txtBoxMedicalConditionSearch";
            this.txtBoxMedicalConditionSearch.Size = new System.Drawing.Size(292, 50);
            this.txtBoxMedicalConditionSearch.TabIndex = 34;
            this.txtBoxMedicalConditionSearch.Text = "";
            this.txtBoxMedicalConditionSearch.TrailingIcon = null;
            // 
            // btnDeleteMedicalCondition
            // 
            this.btnDeleteMedicalCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMedicalCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMedicalCondition.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteMedicalCondition.Depth = 0;
            this.btnDeleteMedicalCondition.HighEmphasis = true;
            this.btnDeleteMedicalCondition.Icon = null;
            this.btnDeleteMedicalCondition.Location = new System.Drawing.Point(926, 429);
            this.btnDeleteMedicalCondition.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteMedicalCondition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteMedicalCondition.Name = "btnDeleteMedicalCondition";
            this.btnDeleteMedicalCondition.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteMedicalCondition.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteMedicalCondition.TabIndex = 33;
            this.btnDeleteMedicalCondition.Tag = "";
            this.btnDeleteMedicalCondition.Text = "Delete";
            this.btnDeleteMedicalCondition.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteMedicalCondition.UseAccentColor = false;
            this.btnDeleteMedicalCondition.UseVisualStyleBackColor = true;
            this.btnDeleteMedicalCondition.Click += new System.EventHandler(this.btnDeleteMedicalCondition_Click);
            // 
            // btnUpdateMedicalCondition
            // 
            this.btnUpdateMedicalCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateMedicalCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateMedicalCondition.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateMedicalCondition.Depth = 0;
            this.btnUpdateMedicalCondition.HighEmphasis = true;
            this.btnUpdateMedicalCondition.Icon = null;
            this.btnUpdateMedicalCondition.Location = new System.Drawing.Point(819, 429);
            this.btnUpdateMedicalCondition.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateMedicalCondition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateMedicalCondition.Name = "btnUpdateMedicalCondition";
            this.btnUpdateMedicalCondition.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateMedicalCondition.Size = new System.Drawing.Size(77, 36);
            this.btnUpdateMedicalCondition.TabIndex = 32;
            this.btnUpdateMedicalCondition.Tag = "";
            this.btnUpdateMedicalCondition.Text = "Update";
            this.btnUpdateMedicalCondition.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateMedicalCondition.UseAccentColor = false;
            this.btnUpdateMedicalCondition.UseVisualStyleBackColor = true;
            this.btnUpdateMedicalCondition.Click += new System.EventHandler(this.btnUpdateMedicalCondition_Click);
            // 
            // btnCreateMedicalCondition
            // 
            this.btnCreateMedicalCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateMedicalCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateMedicalCondition.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateMedicalCondition.Depth = 0;
            this.btnCreateMedicalCondition.HighEmphasis = true;
            this.btnCreateMedicalCondition.Icon = null;
            this.btnCreateMedicalCondition.Location = new System.Drawing.Point(707, 429);
            this.btnCreateMedicalCondition.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateMedicalCondition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateMedicalCondition.Name = "btnCreateMedicalCondition";
            this.btnCreateMedicalCondition.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateMedicalCondition.Size = new System.Drawing.Size(76, 36);
            this.btnCreateMedicalCondition.TabIndex = 28;
            this.btnCreateMedicalCondition.Tag = "";
            this.btnCreateMedicalCondition.Text = "Create";
            this.btnCreateMedicalCondition.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateMedicalCondition.UseAccentColor = false;
            this.btnCreateMedicalCondition.UseVisualStyleBackColor = true;
            this.btnCreateMedicalCondition.Click += new System.EventHandler(this.btnCreateMedicalCondition_Click);
            // 
            // txtBoxConditionName
            // 
            this.txtBoxConditionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConditionName.AnimateReadOnly = false;
            this.txtBoxConditionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConditionName.Depth = 0;
            this.txtBoxConditionName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxConditionName.Hint = "Condition Name";
            this.txtBoxConditionName.LeadingIcon = null;
            this.txtBoxConditionName.Location = new System.Drawing.Point(707, 243);
            this.txtBoxConditionName.MaxLength = 50;
            this.txtBoxConditionName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxConditionName.Multiline = false;
            this.txtBoxConditionName.Name = "txtBoxConditionName";
            this.txtBoxConditionName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxConditionName.TabIndex = 31;
            this.txtBoxConditionName.Text = "";
            this.txtBoxConditionName.TrailingIcon = null;
            // 
            // txtBoxPriority
            // 
            this.txtBoxPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPriority.AnimateReadOnly = false;
            this.txtBoxPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPriority.Depth = 0;
            this.txtBoxPriority.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPriority.Hint = "Priority";
            this.txtBoxPriority.LeadingIcon = null;
            this.txtBoxPriority.Location = new System.Drawing.Point(707, 308);
            this.txtBoxPriority.MaxLength = 50;
            this.txtBoxPriority.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPriority.Multiline = false;
            this.txtBoxPriority.Name = "txtBoxPriority";
            this.txtBoxPriority.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPriority.TabIndex = 30;
            this.txtBoxPriority.Text = "";
            this.txtBoxPriority.TrailingIcon = null;
            // 
            // txtBoxConditionId
            // 
            this.txtBoxConditionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConditionId.AnimateReadOnly = false;
            this.txtBoxConditionId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConditionId.Depth = 0;
            this.txtBoxConditionId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxConditionId.Hint = "ID";
            this.txtBoxConditionId.LeadingIcon = null;
            this.txtBoxConditionId.Location = new System.Drawing.Point(707, 176);
            this.txtBoxConditionId.MaxLength = 50;
            this.txtBoxConditionId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxConditionId.Multiline = false;
            this.txtBoxConditionId.Name = "txtBoxConditionId";
            this.txtBoxConditionId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxConditionId.TabIndex = 29;
            this.txtBoxConditionId.Text = "";
            this.txtBoxConditionId.TrailingIcon = null;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(707, 381);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(76, 36);
            this.btnClear.TabIndex = 37;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Medical_Condition_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 574);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.materialListView2);
            this.Controls.Add(this.btnMedicalConditionSearch);
            this.Controls.Add(this.txtBoxMedicalConditionSearch);
            this.Controls.Add(this.btnDeleteMedicalCondition);
            this.Controls.Add(this.btnUpdateMedicalCondition);
            this.Controls.Add(this.btnCreateMedicalCondition);
            this.Controls.Add(this.txtBoxConditionName);
            this.Controls.Add(this.txtBoxPriority);
            this.Controls.Add(this.txtBoxConditionId);
            this.Name = "Medical_Condition_Form";
            this.Text = "Medical_Condition_Form";
            this.Load += new System.EventHandler(this.Medical_Condition_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MaterialSkin.Controls.MaterialButton btnMedicalConditionSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxMedicalConditionSearch;
        private MaterialSkin.Controls.MaterialButton btnDeleteMedicalCondition;
        private MaterialSkin.Controls.MaterialButton btnUpdateMedicalCondition;
        private MaterialSkin.Controls.MaterialButton btnCreateMedicalCondition;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPriority;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionId;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}