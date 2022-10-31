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
    public partial class PolicyForm : Form
    {
        public PolicyForm()
        {
            InitializeComponent();
        }

        private void PolicyForm_Load(object sender, EventArgs e)
        {
            policyTabSelected();
        }

        public void policyTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the policy tab
            materialListView3.Items.Clear();
            foreach (DataRow row in dataHandler.getPolicy().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["description"].ToString());
                item.SubItems.Add(row["Date_Time"].ToString());
                item.SubItems.Add(row["Type_of_Policy"].ToString());
                item.SubItems.Add(row["Fee"].ToString());
                item.SubItems.Add(row["expired"].ToString());
                materialListView3.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView3.SelectedIndexChanged += (s, args) =>
            {
                if (materialListView3.SelectedItems.Count > 0)
                {
                    ListViewItem item = materialListView3.SelectedItems[0];
                    txtBoxPolicyId.Text = item.SubItems[0].Text;
                    txtBoxPolicyDesc.Text = item.SubItems[1].Text;
                    txtBoxPolicyDate.Text = item.SubItems[2].Text;
                    txtBoxPolicyType.Text = item.SubItems[3].Text;
                    txtBoxPolicyFee.Text = item.SubItems[4].Text;
                    //display value from listview in combo box
                    if (item.SubItems[5].Text == "True")
                    {
                        cmbExpired.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbExpired.SelectedIndex = 1;
                    }



                }
            };
            materialListView3.GridLines = false;
            materialListView3.FullRowSelect = true;
            materialListView3.MultiSelect = false;
            materialListView3.View = View.Details;
        }

        private void btnPolicySearch_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            materialListView3.Items.Clear();
            if (txtBoxPolicySearch.Text != "")// if the search textbox is not empty
            {
                // check if the search textbox is a number
                if (txtBoxPolicySearch.Text != null && txtBoxPolicySearch.Text.All(char.IsDigit))
                {
                    foreach (DataRow row in dataHandler.searchPolicy(int.Parse(txtBoxPolicySearch.Text)).Rows)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["description"].ToString());
                        item.SubItems.Add(row["Date_Time"].ToString());
                        item.SubItems.Add(row["Type_of_Policy"].ToString());
                        item.SubItems.Add(row["Fee"].ToString());
                        item.SubItems.Add(row["expired"].ToString());
                        materialListView3.Items.Add(item);
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
                //show all the medical conditions
                foreach (DataRow row in dataHandler.getMedicalCondition().Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["Date_Time"].ToString());
                    item.SubItems.Add(row["Type_of_Policy"].ToString());
                    item.SubItems.Add(row["Fee"].ToString());
                    item.SubItems.Add(row["expired"].ToString());
                    materialListView3.Items.Add(item);
                }
                //display the selected listview item in the textboxes
                materialListView3.SelectedIndexChanged += (s, args) =>
                {
                    if (materialListView3.SelectedItems.Count > 0)
                    {
                        ListViewItem item = materialListView3.SelectedItems[0];
                        txtBoxPolicyId.Text = item.SubItems[0].Text;
                        txtBoxPolicyDesc.Text = item.SubItems[1].Text;
                        txtBoxPolicyDate.Text = item.SubItems[2].Text;
                        txtBoxPolicyType.Text = item.SubItems[3].Text;
                        txtBoxPolicyFee.Text = item.SubItems[4].Text;
                        //display value from listview in combo box
                        if (item.SubItems[5].Text == "True")
                        {
                            cmbExpired.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbExpired.SelectedIndex = 1;
                        }

                    }
                };
                materialListView3.GridLines = false;
                materialListView3.FullRowSelect = true;
                materialListView3.MultiSelect = false;
                materialListView3.View = View.Details;
                //show error message
                MessageBox.Show("Please enter a valid Policy id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
