namespace Group11_SEN381_Project.Presentation
{
    partial class ProviderForm
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
            this.materialListView4 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialButton14 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton15 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton16 = new MaterialSkin.Controls.MaterialButton();
            this.cmbProviderRating = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox11 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxProviderName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxProviderLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxProviderId = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialListView4
            // 
            this.materialListView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView4.AutoSizeTable = false;
            this.materialListView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.materialListView4.Depth = 0;
            this.materialListView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView4.FullRowSelect = true;
            this.materialListView4.HideSelection = false;
            this.materialListView4.Location = new System.Drawing.Point(12, 72);
            this.materialListView4.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView4.Name = "materialListView4";
            this.materialListView4.OwnerDraw = true;
            this.materialListView4.Size = new System.Drawing.Size(679, 497);
            this.materialListView4.TabIndex = 47;
            this.materialListView4.UseCompatibleStateImageBehavior = false;
            this.materialListView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "id";
            this.columnHeader17.Width = 130;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Name";
            this.columnHeader18.Width = 250;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Location";
            this.columnHeader19.Width = 220;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Rating";
            this.columnHeader20.Width = 150;
            // 
            // materialButton14
            // 
            this.materialButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton14.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton14.Depth = 0;
            this.materialButton14.HighEmphasis = true;
            this.materialButton14.Icon = null;
            this.materialButton14.Location = new System.Drawing.Point(929, 408);
            this.materialButton14.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton14.Name = "materialButton14";
            this.materialButton14.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton14.Size = new System.Drawing.Size(73, 36);
            this.materialButton14.TabIndex = 46;
            this.materialButton14.Tag = "";
            this.materialButton14.Text = "Delete";
            this.materialButton14.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton14.UseAccentColor = false;
            this.materialButton14.UseVisualStyleBackColor = true;
            // 
            // materialButton15
            // 
            this.materialButton15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton15.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton15.Depth = 0;
            this.materialButton15.HighEmphasis = true;
            this.materialButton15.Icon = null;
            this.materialButton15.Location = new System.Drawing.Point(822, 408);
            this.materialButton15.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton15.Name = "materialButton15";
            this.materialButton15.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton15.Size = new System.Drawing.Size(77, 36);
            this.materialButton15.TabIndex = 45;
            this.materialButton15.Tag = "";
            this.materialButton15.Text = "Update";
            this.materialButton15.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton15.UseAccentColor = false;
            this.materialButton15.UseVisualStyleBackColor = true;
            // 
            // materialButton16
            // 
            this.materialButton16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton16.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton16.Depth = 0;
            this.materialButton16.HighEmphasis = true;
            this.materialButton16.Icon = null;
            this.materialButton16.Location = new System.Drawing.Point(710, 408);
            this.materialButton16.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton16.Name = "materialButton16";
            this.materialButton16.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton16.Size = new System.Drawing.Size(76, 36);
            this.materialButton16.TabIndex = 44;
            this.materialButton16.Tag = "";
            this.materialButton16.Text = "Create";
            this.materialButton16.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton16.UseAccentColor = false;
            this.materialButton16.UseVisualStyleBackColor = true;
            // 
            // cmbProviderRating
            // 
            this.cmbProviderRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProviderRating.AutoResize = false;
            this.cmbProviderRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProviderRating.Depth = 0;
            this.cmbProviderRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbProviderRating.DropDownHeight = 174;
            this.cmbProviderRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProviderRating.DropDownWidth = 121;
            this.cmbProviderRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbProviderRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbProviderRating.FormattingEnabled = true;
            this.cmbProviderRating.IntegralHeight = false;
            this.cmbProviderRating.ItemHeight = 43;
            this.cmbProviderRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbProviderRating.Location = new System.Drawing.Point(710, 340);
            this.cmbProviderRating.MaxDropDownItems = 4;
            this.cmbProviderRating.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbProviderRating.Name = "cmbProviderRating";
            this.cmbProviderRating.Size = new System.Drawing.Size(121, 49);
            this.cmbProviderRating.StartIndex = 0;
            this.cmbProviderRating.TabIndex = 43;
            // 
            // materialButton10
            // 
            this.materialButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton10.Depth = 0;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(332, 30);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton10.Size = new System.Drawing.Size(78, 36);
            this.materialButton10.TabIndex = 42;
            this.materialButton10.Tag = "";
            this.materialButton10.Text = "Search";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = false;
            this.materialButton10.UseVisualStyleBackColor = true;
            // 
            // materialTextBox11
            // 
            this.materialTextBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox11.AnimateReadOnly = false;
            this.materialTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox11.Depth = 0;
            this.materialTextBox11.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox11.Hint = "Search ID";
            this.materialTextBox11.LeadingIcon = null;
            this.materialTextBox11.Location = new System.Drawing.Point(12, 16);
            this.materialTextBox11.MaxLength = 50;
            this.materialTextBox11.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox11.Multiline = false;
            this.materialTextBox11.Name = "materialTextBox11";
            this.materialTextBox11.Size = new System.Drawing.Size(292, 50);
            this.materialTextBox11.TabIndex = 41;
            this.materialTextBox11.Text = "";
            this.materialTextBox11.TrailingIcon = null;
            // 
            // txtBoxProviderName
            // 
            this.txtBoxProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxProviderName.AnimateReadOnly = false;
            this.txtBoxProviderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxProviderName.Depth = 0;
            this.txtBoxProviderName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProviderName.Hint = "Name";
            this.txtBoxProviderName.LeadingIcon = null;
            this.txtBoxProviderName.Location = new System.Drawing.Point(710, 219);
            this.txtBoxProviderName.MaxLength = 50;
            this.txtBoxProviderName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProviderName.Multiline = false;
            this.txtBoxProviderName.Name = "txtBoxProviderName";
            this.txtBoxProviderName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxProviderName.TabIndex = 40;
            this.txtBoxProviderName.Text = "";
            this.txtBoxProviderName.TrailingIcon = null;
            // 
            // txtBoxProviderLocation
            // 
            this.txtBoxProviderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxProviderLocation.AnimateReadOnly = false;
            this.txtBoxProviderLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxProviderLocation.Depth = 0;
            this.txtBoxProviderLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProviderLocation.Hint = "Location";
            this.txtBoxProviderLocation.LeadingIcon = null;
            this.txtBoxProviderLocation.Location = new System.Drawing.Point(710, 284);
            this.txtBoxProviderLocation.MaxLength = 50;
            this.txtBoxProviderLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProviderLocation.Multiline = false;
            this.txtBoxProviderLocation.Name = "txtBoxProviderLocation";
            this.txtBoxProviderLocation.Size = new System.Drawing.Size(292, 50);
            this.txtBoxProviderLocation.TabIndex = 39;
            this.txtBoxProviderLocation.Text = "";
            this.txtBoxProviderLocation.TrailingIcon = null;
            // 
            // txtBoxProviderId
            // 
            this.txtBoxProviderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxProviderId.AnimateReadOnly = false;
            this.txtBoxProviderId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxProviderId.Depth = 0;
            this.txtBoxProviderId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProviderId.Hint = "ID";
            this.txtBoxProviderId.LeadingIcon = null;
            this.txtBoxProviderId.Location = new System.Drawing.Point(710, 152);
            this.txtBoxProviderId.MaxLength = 50;
            this.txtBoxProviderId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProviderId.Multiline = false;
            this.txtBoxProviderId.Name = "txtBoxProviderId";
            this.txtBoxProviderId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxProviderId.TabIndex = 38;
            this.txtBoxProviderId.Text = "";
            this.txtBoxProviderId.TrailingIcon = null;
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 585);
            this.Controls.Add(this.materialListView4);
            this.Controls.Add(this.materialButton14);
            this.Controls.Add(this.materialButton15);
            this.Controls.Add(this.materialButton16);
            this.Controls.Add(this.cmbProviderRating);
            this.Controls.Add(this.materialButton10);
            this.Controls.Add(this.materialTextBox11);
            this.Controls.Add(this.txtBoxProviderName);
            this.Controls.Add(this.txtBoxProviderLocation);
            this.Controls.Add(this.txtBoxProviderId);
            this.Name = "ProviderForm";
            this.Text = "ProviderForm";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView4;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private MaterialSkin.Controls.MaterialButton materialButton14;
        private MaterialSkin.Controls.MaterialButton materialButton15;
        private MaterialSkin.Controls.MaterialButton materialButton16;
        private MaterialSkin.Controls.MaterialComboBox cmbProviderRating;
        private MaterialSkin.Controls.MaterialButton materialButton10;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox11;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderLocation;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderId;
    }
}