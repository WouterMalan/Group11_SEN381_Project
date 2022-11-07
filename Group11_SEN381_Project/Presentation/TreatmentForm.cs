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
    public partial class TreatmentForm : Form
    {
        DataHandler dataHandler1 = new DataHandler();
        Treatment treatment = new Treatment();
        public TreatmentForm()
        {
            InitializeComponent();
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            treatmentTabSelected();
        }

        public void treatmentTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the policy tab
            materialListView5.Items.Clear();
            foreach (DataRow row in dataHandler.getTreatment().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Treatment_Name"].ToString());
                item.SubItems.Add(row["Description"].ToString());
                materialListView5.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView5.SelectedIndexChanged += (s, args) =>
            {
                if (materialListView5.SelectedItems.Count > 0)
                {
                    ListViewItem item = materialListView5.SelectedItems[0];
                    txtBoxTreatmentId.Text = item.SubItems[0].Text;
                    txtBoxTreatmentName.Text = item.SubItems[1].Text;
                    txtBoxTreatmentDesc.Text = item.SubItems[2].Text;
                    
                }
            };
            materialListView5.GridLines = false;
            materialListView5.FullRowSelect = true;
            materialListView5.MultiSelect = false;
            materialListView5.View = View.Details;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            treatment.TreatmentID = int.Parse(txtBoxTreatmentId.Text);
            treatment.TreatmentName = txtBoxTreatmentName.Text;
            treatment.Level = txtBoxTreatmentDesc.Text;//TODO:CHANGE LEVEL AND TXT BOX NAME
            treatment.Days = int.Parse(txtBoxTreatmentDays.Text);//ADD TXT BOX FOR DAYS
            treatment.CreateTreatments();
            treatmentTabSelected();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            treatment.TreatmentID = int.Parse(txtBoxTreatmentId.Text);
            treatment.TreatmentName = txtBoxTreatmentName.Text;
            treatment.Level = txtBoxTreatmentDesc.Text;//TODO:CHANGE LEVEL AND TXT BOX NAME
            treatment.Days = int.Parse(txtBoxTreatmentDays.Text);//ADD TXT BOX FOR DAYS
            treatment.UpdateTreatments();
            treatmentTabSelected();
        }

        private void btnTreatmentSearch_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            materialListView5.Items.Clear();
            if (txtBoxTreatmentSearch.Text != "")// if the search textbox is not empty
            {
                // check if the search textbox is a number
                if (txtBoxTreatmentSearch.Text != null && txtBoxTreatmentSearch.Text.All(char.IsDigit))
                {
                    foreach (DataRow row in dataHandler.searchTreatment(int.Parse(txtBoxTreatmentSearch.Text)).Rows)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["Treatment_Name"].ToString());
                        item.SubItems.Add(row["Description"].ToString());
                        materialListView5.Items.Add(item);
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
                treatmentTabSelected();
                MessageBox.Show("Please enter a valid Treatment id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
