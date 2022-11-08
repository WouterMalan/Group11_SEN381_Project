namespace Group11_SEN381_Project.Presentation
{
    partial class Report
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteReport = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateReport = new MaterialSkin.Controls.MaterialButton();
            this.btnCreateReport = new MaterialSkin.Controls.MaterialButton();
            this.cmbExpired = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSearchReport = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxSearchReport = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxSTime = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxETime = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxClientID = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxMC_ID = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxReportid = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxPolicyID = new MaterialSkin.Controls.MaterialTextBox();
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
            this.columnHeader1,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.materialListView3.Depth = 0;
            this.materialListView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView3.FullRowSelect = true;
            this.materialListView3.HideSelection = false;
            this.materialListView3.Location = new System.Drawing.Point(15, 79);
            this.materialListView3.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView3.Name = "materialListView3";
            this.materialListView3.OwnerDraw = true;
            this.materialListView3.Size = new System.Drawing.Size(629, 536);
            this.materialListView3.TabIndex = 52;
            this.materialListView3.UseCompatibleStateImageBehavior = false;
            this.materialListView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "id";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Client ID";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "MC ID";
            this.columnHeader13.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Policy ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Start Time";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "End Time";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Claim";
            this.columnHeader16.Width = 120;
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteReport.Depth = 0;
            this.btnDeleteReport.HighEmphasis = true;
            this.btnDeleteReport.Icon = null;
            this.btnDeleteReport.Location = new System.Drawing.Point(873, 579);
            this.btnDeleteReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteReport.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteReport.TabIndex = 51;
            this.btnDeleteReport.Tag = "";
            this.btnDeleteReport.Text = "Delete";
            this.btnDeleteReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteReport.UseAccentColor = false;
            this.btnDeleteReport.UseVisualStyleBackColor = true;
            this.btnDeleteReport.Click += new System.EventHandler(this.btnDeleteReport_Click);
            // 
            // btnUpdateReport
            // 
            this.btnUpdateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateReport.Depth = 0;
            this.btnUpdateReport.HighEmphasis = true;
            this.btnUpdateReport.Icon = null;
            this.btnUpdateReport.Location = new System.Drawing.Point(770, 579);
            this.btnUpdateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateReport.Name = "btnUpdateReport";
            this.btnUpdateReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateReport.Size = new System.Drawing.Size(77, 36);
            this.btnUpdateReport.TabIndex = 50;
            this.btnUpdateReport.Tag = "";
            this.btnUpdateReport.Text = "Update";
            this.btnUpdateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateReport.UseAccentColor = false;
            this.btnUpdateReport.UseVisualStyleBackColor = true;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateReport.Depth = 0;
            this.btnCreateReport.HighEmphasis = true;
            this.btnCreateReport.Icon = null;
            this.btnCreateReport.Location = new System.Drawing.Point(663, 579);
            this.btnCreateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateReport.Size = new System.Drawing.Size(76, 36);
            this.btnCreateReport.TabIndex = 49;
            this.btnCreateReport.Tag = "";
            this.btnCreateReport.Text = "Create";
            this.btnCreateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateReport.UseAccentColor = false;
            this.btnCreateReport.UseVisualStyleBackColor = true;
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
            this.cmbExpired.Hint = "Claim";
            this.cmbExpired.IntegralHeight = false;
            this.cmbExpired.ItemHeight = 43;
            this.cmbExpired.Items.AddRange(new object[] {
            "In Progress",
            "Approved",
            "Denied"});
            this.cmbExpired.Location = new System.Drawing.Point(665, 447);
            this.cmbExpired.MaxDropDownItems = 4;
            this.cmbExpired.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbExpired.Name = "cmbExpired";
            this.cmbExpired.Size = new System.Drawing.Size(121, 49);
            this.cmbExpired.StartIndex = 0;
            this.cmbExpired.TabIndex = 48;
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchReport.Depth = 0;
            this.btnSearchReport.HighEmphasis = true;
            this.btnSearchReport.Icon = null;
            this.btnSearchReport.Location = new System.Drawing.Point(368, 34);
            this.btnSearchReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchReport.Size = new System.Drawing.Size(78, 36);
            this.btnSearchReport.TabIndex = 47;
            this.btnSearchReport.Tag = "";
            this.btnSearchReport.Text = "Search";
            this.btnSearchReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchReport.UseAccentColor = false;
            this.btnSearchReport.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearchReport
            // 
            this.txtBoxSearchReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchReport.AnimateReadOnly = false;
            this.txtBoxSearchReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearchReport.Depth = 0;
            this.txtBoxSearchReport.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearchReport.Hint = "Search ID";
            this.txtBoxSearchReport.LeadingIcon = null;
            this.txtBoxSearchReport.Location = new System.Drawing.Point(15, 20);
            this.txtBoxSearchReport.MaxLength = 50;
            this.txtBoxSearchReport.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxSearchReport.Multiline = false;
            this.txtBoxSearchReport.Name = "txtBoxSearchReport";
            this.txtBoxSearchReport.Size = new System.Drawing.Size(295, 50);
            this.txtBoxSearchReport.TabIndex = 46;
            this.txtBoxSearchReport.Text = "";
            this.txtBoxSearchReport.TrailingIcon = null;
            // 
            // txtBoxSTime
            // 
            this.txtBoxSTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSTime.AnimateReadOnly = false;
            this.txtBoxSTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSTime.Depth = 0;
            this.txtBoxSTime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSTime.Hint = "Start Time Stamp";
            this.txtBoxSTime.LeadingIcon = null;
            this.txtBoxSTime.Location = new System.Drawing.Point(665, 308);
            this.txtBoxSTime.MaxLength = 50;
            this.txtBoxSTime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxSTime.Multiline = false;
            this.txtBoxSTime.Name = "txtBoxSTime";
            this.txtBoxSTime.Size = new System.Drawing.Size(292, 50);
            this.txtBoxSTime.TabIndex = 45;
            this.txtBoxSTime.Text = "";
            this.txtBoxSTime.TrailingIcon = null;
            // 
            // txtBoxETime
            // 
            this.txtBoxETime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxETime.AnimateReadOnly = false;
            this.txtBoxETime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxETime.Depth = 0;
            this.txtBoxETime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxETime.Hint = "End Time Stamp";
            this.txtBoxETime.LeadingIcon = null;
            this.txtBoxETime.Location = new System.Drawing.Point(665, 375);
            this.txtBoxETime.MaxLength = 50;
            this.txtBoxETime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxETime.Multiline = false;
            this.txtBoxETime.Name = "txtBoxETime";
            this.txtBoxETime.Size = new System.Drawing.Size(292, 50);
            this.txtBoxETime.TabIndex = 44;
            this.txtBoxETime.Text = "";
            this.txtBoxETime.TrailingIcon = null;
            // 
            // txtBoxClientID
            // 
            this.txtBoxClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClientID.AnimateReadOnly = false;
            this.txtBoxClientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxClientID.Depth = 0;
            this.txtBoxClientID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxClientID.Hint = "Client ID";
            this.txtBoxClientID.LeadingIcon = null;
            this.txtBoxClientID.Location = new System.Drawing.Point(665, 112);
            this.txtBoxClientID.MaxLength = 50;
            this.txtBoxClientID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxClientID.Multiline = false;
            this.txtBoxClientID.Name = "txtBoxClientID";
            this.txtBoxClientID.Size = new System.Drawing.Size(292, 50);
            this.txtBoxClientID.TabIndex = 43;
            this.txtBoxClientID.Text = "";
            this.txtBoxClientID.TrailingIcon = null;
            // 
            // txtBoxMC_ID
            // 
            this.txtBoxMC_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMC_ID.AnimateReadOnly = false;
            this.txtBoxMC_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMC_ID.Depth = 0;
            this.txtBoxMC_ID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxMC_ID.Hint = "MC ID";
            this.txtBoxMC_ID.LeadingIcon = null;
            this.txtBoxMC_ID.Location = new System.Drawing.Point(664, 177);
            this.txtBoxMC_ID.MaxLength = 50;
            this.txtBoxMC_ID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxMC_ID.Multiline = false;
            this.txtBoxMC_ID.Name = "txtBoxMC_ID";
            this.txtBoxMC_ID.Size = new System.Drawing.Size(292, 50);
            this.txtBoxMC_ID.TabIndex = 42;
            this.txtBoxMC_ID.Text = "";
            this.txtBoxMC_ID.TrailingIcon = null;
            // 
            // txtBoxReportid
            // 
            this.txtBoxReportid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxReportid.AnimateReadOnly = false;
            this.txtBoxReportid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxReportid.Depth = 0;
            this.txtBoxReportid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxReportid.Hint = "ID";
            this.txtBoxReportid.LeadingIcon = null;
            this.txtBoxReportid.Location = new System.Drawing.Point(665, 42);
            this.txtBoxReportid.MaxLength = 50;
            this.txtBoxReportid.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxReportid.Multiline = false;
            this.txtBoxReportid.Name = "txtBoxReportid";
            this.txtBoxReportid.Size = new System.Drawing.Size(292, 50);
            this.txtBoxReportid.TabIndex = 41;
            this.txtBoxReportid.Text = "";
            this.txtBoxReportid.TrailingIcon = null;
            // 
            // txtBoxPolicyID
            // 
            this.txtBoxPolicyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPolicyID.AnimateReadOnly = false;
            this.txtBoxPolicyID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolicyID.Depth = 0;
            this.txtBoxPolicyID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPolicyID.Hint = "Policy ID";
            this.txtBoxPolicyID.LeadingIcon = null;
            this.txtBoxPolicyID.Location = new System.Drawing.Point(664, 242);
            this.txtBoxPolicyID.MaxLength = 50;
            this.txtBoxPolicyID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPolicyID.Multiline = false;
            this.txtBoxPolicyID.Name = "txtBoxPolicyID";
            this.txtBoxPolicyID.Size = new System.Drawing.Size(292, 50);
            this.txtBoxPolicyID.TabIndex = 53;
            this.txtBoxPolicyID.Text = "";
            this.txtBoxPolicyID.TrailingIcon = null;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(665, 521);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 54;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 641);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxPolicyID);
            this.Controls.Add(this.materialListView3);
            this.Controls.Add(this.btnDeleteReport);
            this.Controls.Add(this.btnUpdateReport);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.cmbExpired);
            this.Controls.Add(this.btnSearchReport);
            this.Controls.Add(this.txtBoxSearchReport);
            this.Controls.Add(this.txtBoxSTime);
            this.Controls.Add(this.txtBoxETime);
            this.Controls.Add(this.txtBoxClientID);
            this.Controls.Add(this.txtBoxMC_ID);
            this.Controls.Add(this.txtBoxReportid);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
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
        private MaterialSkin.Controls.MaterialButton btnDeleteReport;
        private MaterialSkin.Controls.MaterialButton btnUpdateReport;
        private MaterialSkin.Controls.MaterialButton btnCreateReport;
        private MaterialSkin.Controls.MaterialComboBox cmbExpired;
        private MaterialSkin.Controls.MaterialButton btnSearchReport;
        private MaterialSkin.Controls.MaterialTextBox txtBoxSearchReport;
        private MaterialSkin.Controls.MaterialTextBox txtBoxSTime;
        private MaterialSkin.Controls.MaterialTextBox txtBoxETime;
        private MaterialSkin.Controls.MaterialTextBox txtBoxClientID;
        private MaterialSkin.Controls.MaterialTextBox txtBoxMC_ID;
        private MaterialSkin.Controls.MaterialTextBox txtBoxReportid;
        private MaterialSkin.Controls.MaterialTextBox txtBoxPolicyID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}