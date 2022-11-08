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
            idGeneratorTreatment();
            pbErrorLevel.Visible = false;
            pbErrorName.Visible = false;
        }

        public void treatmentTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the policy tab
            materialListView5.Items.Clear();
            foreach (DataRow row in treatment.getTreatment().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Treatment_Name"].ToString());
                item.SubItems.Add(row["Level"].ToString());
                item.SubItems.Add(row["Days"].ToString());
                
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
                    txtBoxTreatmentLevel.Text = item.SubItems[2].Text;
                    numericUpDown1.Value = Convert.ToInt32(item.SubItems[3].Text);//Days

                }
            };
            materialListView5.GridLines = false;
            materialListView5.FullRowSelect = true;
            materialListView5.MultiSelect = false;
            materialListView5.View = View.Details;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxTreatmentName.Text != "" && txtBoxTreatmentLevel.Text != "" )
            {
                treatment.TreatmentID = int.Parse(txtBoxTreatmentId.Text);
                treatment.TreatmentName = txtBoxTreatmentName.Text;
                treatment.Level = txtBoxTreatmentLevel.Text;
                treatment.Days = Convert.ToInt32(numericUpDown1.Value);
                treatment.CreateTreatments();
                treatmentTabSelected();
                idGeneratorTreatment();
                clearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxTreatmentName.Text == "")
                {
                    pbErrorName.Visible = true;
                    txtBoxTreatmentName.Focus();
                }
                else
                {
                    pbErrorName.Visible = false;
                }
                if (txtBoxTreatmentLevel.Text == "")
                {
                    pbErrorLevel.Visible = true;
                    txtBoxTreatmentLevel.Focus();
                }
                else
                {
                    pbErrorLevel.Visible = false;
                }


            }
            




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxTreatmentName.Text != "" && txtBoxTreatmentLevel.Text != "" )
            {
                treatment.TreatmentID = int.Parse(txtBoxTreatmentId.Text);
                treatment.TreatmentName = txtBoxTreatmentName.Text;
                treatment.Level = txtBoxTreatmentLevel.Text;
                treatment.Days = Convert.ToInt32(numericUpDown1.Value);
                treatment.UpdateTreatments();
                treatmentTabSelected();
                idGeneratorTreatment();
                clearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxTreatmentName.Text == "")
                {
                    pbErrorName.Visible = true;
                    txtBoxTreatmentName.Focus();
                }
                else
                {
                    pbErrorName.Visible = false;
                }
                if (txtBoxTreatmentLevel.Text == "")
                {
                    pbErrorLevel.Visible = true;
                    txtBoxTreatmentLevel.Focus();
                }
                else
                {
                    pbErrorLevel.Visible = false;
                }


            }
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
                        item.SubItems.Add(row["Level"].ToString());
                        item.SubItems.Add(row["Days"].ToString());
                        materialListView5.Items.Add(item);
                    }
                    clearFields();
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

        private void idGeneratorTreatment()
        {
            int id = 0;
            foreach (DataRow row in treatment.getTreatment().Rows)
            {
                id = int.Parse(row["id"].ToString());
            }
            id++;
            txtBoxTreatmentId.Text = id.ToString();
        }

        private void clearFields()
        {
            
                txtBoxTreatmentName.Text = "";
                txtBoxTreatmentLevel.Text = "";
                numericUpDown1.Value = 0;
            idGeneratorTreatment();
            pbErrorName.Visible = false;
            pbErrorLevel.Visible = false;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            treatment.TreatmentID = int.Parse(txtBoxTreatmentId.Text);
            treatment.DeleteTreatment();
            treatmentTabSelected();
            clearFields();
        }
    }
}
