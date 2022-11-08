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
            this.ListViewProvider = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.cmbProviderRating = new MaterialSkin.Controls.MaterialComboBox();
            this.btnProviderSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxProviderSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxProviderName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxProviderLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxProviderId = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // ListViewProvider
            // 
            this.ListViewProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewProvider.AutoSizeTable = false;
            this.ListViewProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.ListViewProvider.Depth = 0;
            this.ListViewProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewProvider.FullRowSelect = true;
            this.ListViewProvider.HideSelection = false;
            this.ListViewProvider.Location = new System.Drawing.Point(12, 72);
            this.ListViewProvider.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewProvider.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewProvider.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewProvider.Name = "ListViewProvider";
            this.ListViewProvider.OwnerDraw = true;
            this.ListViewProvider.Size = new System.Drawing.Size(679, 497);
            this.ListViewProvider.TabIndex = 47;
            this.ListViewProvider.UseCompatibleStateImageBehavior = false;
            this.ListViewProvider.View = System.Windows.Forms.View.Details;
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
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(929, 408);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 46;
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
            this.btnUpdate.Location = new System.Drawing.Point(822, 408);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 45;
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
            this.btnCreate.Location = new System.Drawing.Point(710, 408);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreate.Size = new System.Drawing.Size(76, 36);
            this.btnCreate.TabIndex = 44;
            this.btnCreate.Tag = "";
            this.btnCreate.Text = "Create";
            this.btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreate.UseAccentColor = false;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.cmbProviderRating.Hint = "Rating";
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
            // btnProviderSearch
            // 
            this.btnProviderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProviderSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProviderSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProviderSearch.Depth = 0;
            this.btnProviderSearch.HighEmphasis = true;
            this.btnProviderSearch.Icon = null;
            this.btnProviderSearch.Location = new System.Drawing.Point(332, 30);
            this.btnProviderSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProviderSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProviderSearch.Name = "btnProviderSearch";
            this.btnProviderSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProviderSearch.Size = new System.Drawing.Size(78, 36);
            this.btnProviderSearch.TabIndex = 42;
            this.btnProviderSearch.Tag = "";
            this.btnProviderSearch.Text = "Search";
            this.btnProviderSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProviderSearch.UseAccentColor = false;
            this.btnProviderSearch.UseVisualStyleBackColor = true;
            this.btnProviderSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxProviderSearch
            // 
            this.txtBoxProviderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxProviderSearch.AnimateReadOnly = false;
            this.txtBoxProviderSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxProviderSearch.Depth = 0;
            this.txtBoxProviderSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProviderSearch.Hint = "Search ID";
            this.txtBoxProviderSearch.LeadingIcon = null;
            this.txtBoxProviderSearch.Location = new System.Drawing.Point(12, 16);
            this.txtBoxProviderSearch.MaxLength = 50;
            this.txtBoxProviderSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProviderSearch.Multiline = false;
            this.txtBoxProviderSearch.Name = "txtBoxProviderSearch";
            this.txtBoxProviderSearch.Size = new System.Drawing.Size(292, 50);
            this.txtBoxProviderSearch.TabIndex = 41;
            this.txtBoxProviderSearch.Text = "";
            this.txtBoxProviderSearch.TrailingIcon = null;
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
            this.Controls.Add(this.ListViewProvider);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbProviderRating);
            this.Controls.Add(this.btnProviderSearch);
            this.Controls.Add(this.txtBoxProviderSearch);
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

        private MaterialSkin.Controls.MaterialListView ListViewProvider;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private MaterialSkin.Controls.MaterialComboBox cmbProviderRating;
        private MaterialSkin.Controls.MaterialButton btnProviderSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderLocation;
        private MaterialSkin.Controls.MaterialTextBox txtBoxProviderId;
    }
}