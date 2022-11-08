using Group11_SEN381_Project.BusinessLogic;
using Group11_SEN381_Project.DataAccess;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_SEN381_Project.Presentation
{
    public partial class Medical_Condition_Form : Form
    {
        DataHandler dataHandler1 = new DataHandler();
        Medical_Condition medical_Condition = new Medical_Condition();
        public Medical_Condition_Form()
        {
            InitializeComponent();
        }

        private void Medical_Condition_Form_Load(object sender, EventArgs e)
        {
            medicalConditionTabSelected();
        }

        public void medicalConditionTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the medical Condition tab
            materialListView2.Items.Clear();
            foreach (DataRow row in medical_Condition.getMedicalCondition().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Condition_Name"].ToString());
                item.SubItems.Add(row["Priority"].ToString());
                materialListView2.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView2.SelectedIndexChanged += (s, args) =>
            {
                if (materialListView2.SelectedItems.Count > 0)
                {
                    ListViewItem item = materialListView2.SelectedItems[0];
                    txtBoxConditionId.Text = item.SubItems[0].Text;
                    txtBoxConditionName.Text = item.SubItems[1].Text;
                    txtBoxPriority.Text = item.SubItems[2].Text;

                }
            };
            materialListView2.GridLines = false;
            materialListView2.FullRowSelect = true;
            materialListView2.MultiSelect = false;
            materialListView2.View = View.Details;
        }

        private void btnMedicalConditionSearch_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            materialListView2.Items.Clear();
            if (txtBoxMedicalConditionSearch.Text != "")// if the search textbox is not empty
            {
                // check if the search textbox is a number
                if (txtBoxMedicalConditionSearch.Text != null && txtBoxMedicalConditionSearch.Text.All(char.IsDigit))
                {
                    foreach (DataRow row in dataHandler.searchMedicalCondition(int.Parse(txtBoxMedicalConditionSearch.Text)).Rows)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["Condition_Name"].ToString());
                        item.SubItems.Add(row["Priority"].ToString());
                        materialListView2.Items.Add(item);
                    }
                }
                else
                {
                    //show message when the search textbox is not a number
                    MessageBox.Show("Please enter a ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else// if the search box is empty
            {
                medicalConditionTabSelected();
                //show error message
                MessageBox.Show("Please enter a valid client id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateMedicalCondition_Click(object sender, EventArgs e)
        {
            if (txtBoxConditionName.Text != "" && txtBoxPriority.Text != "")
            {
                medical_Condition.ConditionID = txtBoxConditionId.Text;
                medical_Condition.ConditionName1 = txtBoxConditionName.Text;
                medical_Condition.Priority1 = txtBoxPriority.Text;
                medical_Condition.CreateMedicalConditions();
                medicalConditionTabSelected();
                MessageBox.Show("Medical Condition created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid medical condition name and description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateMedicalCondition_Click(object sender, EventArgs e)
        {
            if (txtBoxConditionName.Text != "" && txtBoxPriority.Text != "")
            {
                medical_Condition.ConditionID = txtBoxConditionId.Text;
                medical_Condition.ConditionName1 = txtBoxConditionName.Text;
                medical_Condition.Priority1 = txtBoxPriority.Text;
                medical_Condition.UpdateMedicalConditions();
                medicalConditionTabSelected();
                MessageBox.Show("Medical Condition updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid medical condition name and description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMedicalCondition_Click(object sender, EventArgs e)
        {
            if (txtBoxConditionName.Text != "" && txtBoxPriority.Text != "")
            {
                medical_Condition.ConditionID = txtBoxConditionId.Text;
                medical_Condition.DeleteMedicalCondition();
                medicalConditionTabSelected();
                MessageBox.Show("Medical Condition deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid medical condition name and description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
