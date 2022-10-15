namespace Group11_SEN381_Project
{
    partial class Policy
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicalCallCenterDataSet = new Group11_SEN381_Project.MedicalCallCenterDataSet();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyTableAdapter = new Group11_SEN381_Project.MedicalCallCenterDataSetTableAdapters.PolicyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofPolicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCallCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.typeofPolicyDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn,
            this.expiredDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.policyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // medicalCallCenterDataSet
            // 
            this.medicalCallCenterDataSet.DataSetName = "MedicalCallCenterDataSet";
            this.medicalCallCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policyBindingSource
            // 
            this.policyBindingSource.DataMember = "Policy";
            this.policyBindingSource.DataSource = this.medicalCallCenterDataSet;
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date_Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // typeofPolicyDataGridViewTextBoxColumn
            // 
            this.typeofPolicyDataGridViewTextBoxColumn.DataPropertyName = "Type_of_Policy";
            this.typeofPolicyDataGridViewTextBoxColumn.HeaderText = "Type_of_Policy";
            this.typeofPolicyDataGridViewTextBoxColumn.Name = "typeofPolicyDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // expiredDataGridViewCheckBoxColumn
            // 
            this.expiredDataGridViewCheckBoxColumn.DataPropertyName = "expired";
            this.expiredDataGridViewCheckBoxColumn.HeaderText = "expired";
            this.expiredDataGridViewCheckBoxColumn.Name = "expiredDataGridViewCheckBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Policy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Policy";
            this.Text = "Policy";
            this.Load += new System.EventHandler(this.Policy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCallCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalCallCenterDataSet medicalCallCenterDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private MedicalCallCenterDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofPolicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}