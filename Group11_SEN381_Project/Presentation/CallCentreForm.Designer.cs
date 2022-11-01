namespace Group11_SEN381_Project.Presentation
{
    partial class CallCentreForm
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
            this.btnCallCentreSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxMedicalConditionSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEndCall = new MaterialSkin.Controls.MaterialButton();
            this.btnAnswerCall = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxConditionName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxConditionDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxConditionId = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListView2
            // 
            this.materialListView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(345, 82);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(688, 497);
            this.materialListView2.TabIndex = 45;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "id";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Client Name";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Client Phone";
            this.columnHeader10.Width = 120;
            // 
            // btnCallCentreSearch
            // 
            this.btnCallCentreSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCallCentreSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCallCentreSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCallCentreSearch.Depth = 0;
            this.btnCallCentreSearch.HighEmphasis = true;
            this.btnCallCentreSearch.Icon = null;
            this.btnCallCentreSearch.Location = new System.Drawing.Point(655, 26);
            this.btnCallCentreSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCallCentreSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCallCentreSearch.Name = "btnCallCentreSearch";
            this.btnCallCentreSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCallCentreSearch.Size = new System.Drawing.Size(78, 36);
            this.btnCallCentreSearch.TabIndex = 44;
            this.btnCallCentreSearch.Tag = "";
            this.btnCallCentreSearch.Text = "Search";
            this.btnCallCentreSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCallCentreSearch.UseAccentColor = false;
            this.btnCallCentreSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxMedicalConditionSearch
            // 
            this.txtBoxMedicalConditionSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMedicalConditionSearch.AnimateReadOnly = false;
            this.txtBoxMedicalConditionSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMedicalConditionSearch.Depth = 0;
            this.txtBoxMedicalConditionSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxMedicalConditionSearch.Hint = "Search ID";
            this.txtBoxMedicalConditionSearch.LeadingIcon = null;
            this.txtBoxMedicalConditionSearch.Location = new System.Drawing.Point(345, 12);
            this.txtBoxMedicalConditionSearch.MaxLength = 50;
            this.txtBoxMedicalConditionSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxMedicalConditionSearch.Multiline = false;
            this.txtBoxMedicalConditionSearch.Name = "txtBoxMedicalConditionSearch";
            this.txtBoxMedicalConditionSearch.Size = new System.Drawing.Size(292, 50);
            this.txtBoxMedicalConditionSearch.TabIndex = 43;
            this.txtBoxMedicalConditionSearch.Text = "";
            this.txtBoxMedicalConditionSearch.TrailingIcon = null;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEndCall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEndCall.Depth = 0;
            this.btnEndCall.HighEmphasis = true;
            this.btnEndCall.Icon = null;
            this.btnEndCall.Location = new System.Drawing.Point(220, 515);
            this.btnEndCall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEndCall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEndCall.Size = new System.Drawing.Size(64, 36);
            this.btnEndCall.TabIndex = 50;
            this.btnEndCall.Tag = "";
            this.btnEndCall.Text = "End";
            this.btnEndCall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEndCall.UseAccentColor = false;
            this.btnEndCall.UseVisualStyleBackColor = true;
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnswerCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnswerCall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnswerCall.Depth = 0;
            this.btnAnswerCall.HighEmphasis = true;
            this.btnAnswerCall.Icon = null;
            this.btnAnswerCall.Location = new System.Drawing.Point(15, 515);
            this.btnAnswerCall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnswerCall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnswerCall.Size = new System.Drawing.Size(81, 36);
            this.btnAnswerCall.TabIndex = 46;
            this.btnAnswerCall.Tag = "";
            this.btnAnswerCall.Text = "Answer";
            this.btnAnswerCall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnswerCall.UseAccentColor = false;
            this.btnAnswerCall.UseVisualStyleBackColor = true;
            // 
            // txtBoxConditionName
            // 
            this.txtBoxConditionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConditionName.AnimateReadOnly = false;
            this.txtBoxConditionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConditionName.Depth = 0;
            this.txtBoxConditionName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxConditionName.Hint = "Medical Condition";
            this.txtBoxConditionName.LeadingIcon = null;
            this.txtBoxConditionName.Location = new System.Drawing.Point(12, 230);
            this.txtBoxConditionName.MaxLength = 50;
            this.txtBoxConditionName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxConditionName.Multiline = false;
            this.txtBoxConditionName.Name = "txtBoxConditionName";
            this.txtBoxConditionName.Size = new System.Drawing.Size(292, 50);
            this.txtBoxConditionName.TabIndex = 49;
            this.txtBoxConditionName.Text = "";
            this.txtBoxConditionName.TrailingIcon = null;
            // 
            // txtBoxConditionDesc
            // 
            this.txtBoxConditionDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConditionDesc.AnimateReadOnly = false;
            this.txtBoxConditionDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConditionDesc.Depth = 0;
            this.txtBoxConditionDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxConditionDesc.Hint = "Description";
            this.txtBoxConditionDesc.LeadingIcon = null;
            this.txtBoxConditionDesc.Location = new System.Drawing.Point(12, 302);
            this.txtBoxConditionDesc.MaxLength = 50;
            this.txtBoxConditionDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxConditionDesc.Multiline = false;
            this.txtBoxConditionDesc.Name = "txtBoxConditionDesc";
            this.txtBoxConditionDesc.Size = new System.Drawing.Size(292, 50);
            this.txtBoxConditionDesc.TabIndex = 48;
            this.txtBoxConditionDesc.Text = "";
            this.txtBoxConditionDesc.TrailingIcon = null;
            // 
            // txtBoxConditionId
            // 
            this.txtBoxConditionId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConditionId.AnimateReadOnly = false;
            this.txtBoxConditionId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConditionId.Depth = 0;
            this.txtBoxConditionId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxConditionId.Hint = "Client ID";
            this.txtBoxConditionId.LeadingIcon = null;
            this.txtBoxConditionId.Location = new System.Drawing.Point(12, 163);
            this.txtBoxConditionId.MaxLength = 50;
            this.txtBoxConditionId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxConditionId.Multiline = false;
            this.txtBoxConditionId.Name = "txtBoxConditionId";
            this.txtBoxConditionId.Size = new System.Drawing.Size(292, 50);
            this.txtBoxConditionId.TabIndex = 47;
            this.txtBoxConditionId.Text = "";
            this.txtBoxConditionId.TrailingIcon = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 125);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phone";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client Policy";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Medical Condition";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Claim";
            this.columnHeader3.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Online/Offline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Success Message";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.Location = new System.Drawing.Point(6, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 55;
            this.materialLabel1.Text = "Call Centre";
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(130, 515);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 52;
            this.materialButton1.Tag = "";
            this.materialButton1.Text = "Hold";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // CallCentreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 622);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.btnAnswerCall);
            this.Controls.Add(this.txtBoxConditionName);
            this.Controls.Add(this.txtBoxConditionDesc);
            this.Controls.Add(this.txtBoxConditionId);
            this.Controls.Add(this.materialListView2);
            this.Controls.Add(this.btnCallCentreSearch);
            this.Controls.Add(this.txtBoxMedicalConditionSearch);
            this.Name = "CallCentreForm";
            this.Text = "CallCentreForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MaterialSkin.Controls.MaterialButton btnCallCentreSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxMedicalConditionSearch;
        private MaterialSkin.Controls.MaterialButton btnEndCall;
        private MaterialSkin.Controls.MaterialButton btnAnswerCall;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionName;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionDesc;
        private MaterialSkin.Controls.MaterialTextBox txtBoxConditionId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}