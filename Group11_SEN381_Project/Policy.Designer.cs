﻿namespace Group11_SEN381_Project
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
            this.medicalCallCenterDataSet = new Group11_SEN381_Project.MedicalCallCenterDataSet();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyTableAdapter = new Group11_SEN381_Project.MedicalCallCenterDataSetTableAdapters.PolicyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCallCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 271);
            this.dataGridView1.TabIndex = 2;
            // 
            // Policy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Policy";
            this.Text = "Policy";
            this.Load += new System.EventHandler(this.Policy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalCallCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MedicalCallCenterDataSet medicalCallCenterDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private MedicalCallCenterDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}