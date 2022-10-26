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
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxConditionName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxConditionDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxConditionId = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialListView2
            // 
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
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(332, 26);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(78, 36);
            this.materialButton5.TabIndex = 35;
            this.materialButton5.Tag = "";
            this.materialButton5.Text = "Search";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.AnimateReadOnly = false;
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox9.Hint = "Search ID";
            this.materialTextBox9.LeadingIcon = null;
            this.materialTextBox9.Location = new System.Drawing.Point(12, 12);
            this.materialTextBox9.MaxLength = 50;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(292, 50);
            this.materialTextBox9.TabIndex = 34;
            this.materialTextBox9.Text = "";
            this.materialTextBox9.TrailingIcon = null;
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(926, 388);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(73, 36);
            this.materialButton6.TabIndex = 33;
            this.materialButton6.Tag = "";
            this.materialButton6.Text = "Delete";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(819, 388);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(77, 36);
            this.materialButton7.TabIndex = 32;
            this.materialButton7.Tag = "";
            this.materialButton7.Text = "Update";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton8.Depth = 0;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(707, 388);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton8.Size = new System.Drawing.Size(76, 36);
            this.materialButton8.TabIndex = 28;
            this.materialButton8.Tag = "";
            this.materialButton8.Text = "Create";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            // 
            // txtBoxConditionName
            // 
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
            // txtBoxConditionDesc
            // 
            this.txtBoxConditionDesc.AnimateReadOnly = false;
            this.txtBoxConditionDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConditionDesc.Depth = 0;
            this.txtBoxConditionDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxConditionDesc.Hint = "Description";
            this.txtBoxConditionDesc.LeadingIcon = null;
            this.txtBoxConditionDesc.Location = new System.Drawing.Point(707, 308);
            this.txtBoxConditionDesc.MaxLength = 50;
            this.txtBoxConditionDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxConditionDesc.Multiline = false;
            this.txtBoxConditionDesc.Name = "txtBoxConditionDesc";
            this.txtBoxConditionDesc.Size = new System.Drawing.Size(292, 50);
            this.txtBoxConditionDesc.TabIndex = 30;
            this.txtBoxConditionDesc.Text = "";
            this.txtBoxConditionDesc.TrailingIcon = null;
            // 
            // txtBoxConditionId
            // 
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
            // Medical_Condition_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 574);
            this.Controls.Add(this.materialListView2);
            this.Controls.Add(this.materialButton5);
            this.Controls.Add(this.materialTextBox9);
            this.Controls.Add(this.materialButton6);
            this.Controls.Add(this.materialButton7);
            this.Controls.Add(this.materialButton8);
            this.Controls.Add(this.txtBoxConditionName);
            this.Controls.Add(this.txtBoxConditionDesc);
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
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionDesc;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionId;
    }
}