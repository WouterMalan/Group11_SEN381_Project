namespace Group11_SEN381_Project.Presentation
{
    partial class TreatmentForm
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
            this.materialListView5 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTreatmentSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxTreatmentSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnCreate = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxTreatmentName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxTreatmentDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxTreatmentId = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialListView5
            // 
            this.materialListView5.AutoSizeTable = false;
            this.materialListView5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.materialListView5.Depth = 0;
            this.materialListView5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView5.FullRowSelect = true;
            this.materialListView5.HideSelection = false;
            this.materialListView5.Location = new System.Drawing.Point(12, 75);
            this.materialListView5.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView5.Name = "materialListView5";
            this.materialListView5.OwnerDraw = true;
            this.materialListView5.Size = new System.Drawing.Size(679, 497);
            this.materialListView5.TabIndex = 45;
            this.materialListView5.UseCompatibleStateImageBehavior = false;
            this.materialListView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "id";
            this.columnHeader21.Width = 150;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Condition Name";
            this.columnHeader22.Width = 300;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Description";
            this.columnHeader23.Width = 300;
            // 
            // btnTreatmentSearch
            // 
            this.btnTreatmentSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTreatmentSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTreatmentSearch.Depth = 0;
            this.btnTreatmentSearch.HighEmphasis = true;
            this.btnTreatmentSearch.Icon = null;
            this.btnTreatmentSearch.Location = new System.Drawing.Point(332, 33);
            this.btnTreatmentSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTreatmentSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTreatmentSearch.Name = "btnTreatmentSearch";
            this.btnTreatmentSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTreatmentSearch.Size = new System.Drawing.Size(78, 36);
            this.btnTreatmentSearch.TabIndex = 44;
            this.btnTreatmentSearch.Tag = "";
            this.btnTreatmentSearch.Text = "Search";
            this.btnTreatmentSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTreatmentSearch.UseAccentColor = false;
            this.btnTreatmentSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxTreatmentSearch
            // 
            this.txtBoxTreatmentSearch.AnimateReadOnly = false;
            this.txtBoxTreatmentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTreatmentSearch.Depth = 0;
            this.txtBoxTreatmentSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTreatmentSearch.Hint = "Search ID";
            this.txtBoxTreatmentSearch.LeadingIcon = null;
            this.txtBoxTreatmentSearch.Location = new System.Drawing.Point(12, 19);
            this.txtBoxTreatmentSearch.MaxLength = 50;
            this.txtBoxTreatmentSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxTreatmentSearch.Multiline = false;
            this.txtBoxTreatmentSearch.Name = "txtBoxTreatmentSearch";
            this.txtBoxTreatmentSearch.Size = new System.Drawing.Size(292, 50);
            this.txtBoxTreatmentSearch.TabIndex = 43;
            this.txtBoxTreatmentSearch.Text = "";
            this.txtBoxTreatmentSearch.TrailingIcon = null;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(939, 397);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(832, 397);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Tag = "";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreate.Depth = 0;
            this.btnCreate.HighEmphasis = true;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(720, 397);
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
            // 
            // txtBoxTreatmentName
            // 
            this.txtBoxTreatmentName.AnimateReadOnly = false;
            this.txtBoxTreatmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTreatmentName.Depth = 0;
            this.txtBoxTreatmentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTreatmentName.Hint = "Treatment Name";
            this.txtBoxTreatmentName.LeadingIcon = null;
            this.txtBoxTreatmentName.Location = new System.Drawing.Point(720, 252);
            this.txtBoxTreatmentName.MaxLength = 50;
            this.txtBoxTreatmentName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxTreatmentName.Multiline = false;
            this.txtBoxTreatmentName.Name = "txtBoxTreatmentName";
            this.txtBoxTreatmentName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxTreatmentName.TabIndex = 40;
            this.txtBoxTreatmentName.Text = "";
            this.txtBoxTreatmentName.TrailingIcon = null;
            // 
            // txtBoxTreatmentDesc
            // 
            this.txtBoxTreatmentDesc.AnimateReadOnly = false;
            this.txtBoxTreatmentDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTreatmentDesc.Depth = 0;
            this.txtBoxTreatmentDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTreatmentDesc.Hint = "Description";
            this.txtBoxTreatmentDesc.LeadingIcon = null;
            this.txtBoxTreatmentDesc.Location = new System.Drawing.Point(720, 317);
            this.txtBoxTreatmentDesc.MaxLength = 50;
            this.txtBoxTreatmentDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxTreatmentDesc.Multiline = false;
            this.txtBoxTreatmentDesc.Name = "txtBoxTreatmentDesc";
            this.txtBoxTreatmentDesc.Size = new System.Drawing.Size(292, 50);
            this.txtBoxTreatmentDesc.TabIndex = 39;
            this.txtBoxTreatmentDesc.Text = "";
            this.txtBoxTreatmentDesc.TrailingIcon = null;
            // 
            // txtBoxTreatmentId
            // 
            this.txtBoxTreatmentId.AnimateReadOnly = false;
            this.txtBoxTreatmentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTreatmentId.Depth = 0;
            this.txtBoxTreatmentId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTreatmentId.Hint = "ID";
            this.txtBoxTreatmentId.LeadingIcon = null;
            this.txtBoxTreatmentId.Location = new System.Drawing.Point(720, 185);
            this.txtBoxTreatmentId.MaxLength = 50;
            this.txtBoxTreatmentId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxTreatmentId.Multiline = false;
            this.txtBoxTreatmentId.Name = "txtBoxTreatmentId";
            this.txtBoxTreatmentId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxTreatmentId.TabIndex = 38;
            this.txtBoxTreatmentId.Text = "";
            this.txtBoxTreatmentId.TrailingIcon = null;
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 643);
            this.Controls.Add(this.materialListView5);
            this.Controls.Add(this.btnTreatmentSearch);
            this.Controls.Add(this.txtBoxTreatmentSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxTreatmentName);
            this.Controls.Add(this.txtBoxTreatmentDesc);
            this.Controls.Add(this.txtBoxTreatmentId);
            this.Name = "TreatmentForm";
            this.Text = "TreatmentForm";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView5;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private MaterialSkin.Controls.MaterialButton btnTreatmentSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxTreatmentSearch;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private MaterialSkin.Controls.MaterialTextBox txtBoxTreatmentName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxTreatmentDesc;
        private MaterialSkin.Controls.MaterialTextBox txtBoxTreatmentId;
    }
}