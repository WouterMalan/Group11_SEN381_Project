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
    public partial class PolicyForm : Form
    {
        DataHandler dataHandler1 = new DataHandler();
        PolicyBL policy = new PolicyBL();
        public PolicyForm()
        {
            InitializeComponent();
        }

        private void PolicyForm_Load(object sender, EventArgs e)
        {
            policyTabSelected();
            idGeneratorPolicy();
            pbErrorImportance.Visible = false;
            pbErrorFee.Visible = false;
            pbErrorYear.Visible = false;
            pbErrorExpired.Visible = false;
            
        }

        public void policyTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the policy tab
            materialListView3.Items.Clear();
            foreach (DataRow row in policy.getPolicy().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["description"].ToString());
                item.SubItems.Add(row["Date_Time"].ToString());
                item.SubItems.Add(row["Importance"].ToString());
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
                    txtBoxImportance.Text = item.SubItems[3].Text;
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
                        item.SubItems.Add(row["Importance"].ToString());
                        item.SubItems.Add(row["Fee"].ToString());
                        item.SubItems.Add(row["expired"].ToString());
                        materialListView3.Items.Add(item);
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
                policyTabSelected();
                MessageBox.Show("Please enter a valid Policy id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxPolicyId.Text != "" && txtBoxPolicyDate.Text != "" && txtBoxImportance.Text != "" && txtBoxPolicyFee.Text != "" && cmbExpired.SelectedIndex !=-1)
            {
                policy.PolicyID1 = txtBoxPolicyId.Text;
                policy.Description1 = txtBoxPolicyDesc.Text;
                policy.StartDate1 = DateTime.Parse(txtBoxPolicyDate.Text);
                policy.Importance1 = txtBoxImportance.Text;
                //make the fee field round to 2 decimal places
                policy.Fee1 = Math.Round(double.Parse(txtBoxPolicyFee.Text), 2);
                policy.Expired1 = int.Parse(cmbExpired.SelectedIndex.ToString());
                policy.CreatePolicy();
                policyTabSelected();// refresh the listview
                idGeneratorPolicy();// generate a new id
            clearFields();

            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxImportance.Text == "")
                {
                    pbErrorImportance.Visible = true;
                }
                else
                {
                    pbErrorImportance.Visible = false;
                }
                if (txtBoxPolicyFee.Text == "")
                {
                    pbErrorFee.Visible = true;
                }
                else
                {
                    pbErrorFee.Visible = false;
                }
                if (txtBoxPolicyDate.Text == "")
                {
                    pbErrorYear.Visible = true;

                }
                else
                {
                    pbErrorYear.Visible = false;
                }
                if(cmbExpired.SelectedIndex == -1)
                {
                    pbErrorExpired.Visible = true;
                    
                }
                else
                {
                    pbErrorExpired.Visible = false;
                }
            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxPolicyId.Text != "" && txtBoxPolicyDesc.Text != "" && txtBoxPolicyDate.Text != "" && txtBoxImportance.Text != "" && txtBoxPolicyFee.Text != "" && cmbExpired.SelectedIndex !=-1)
            {
                policy.PolicyID1 = txtBoxPolicyId.Text;
                policy.Description1 = txtBoxPolicyDesc.Text;
                policy.StartDate1 = DateTime.Parse(txtBoxPolicyDate.Text);
                policy.Importance1 = txtBoxImportance.Text;
                //make the fee field round to 2 decimal places
                policy.Fee1 = Math.Round(double.Parse(txtBoxPolicyFee.Text), 2);
                policy.Expired1 = int.Parse(cmbExpired.SelectedIndex.ToString());
                policy.UpdatePolicy();
                policyTabSelected();// refresh the listview
                idGeneratorPolicy();// generate a new id
                clearFields();
                
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxImportance.Text == "")
                {
                    pbErrorImportance.Visible = true;
                }
                else
                {
                    pbErrorImportance.Visible = false;
                }
                if (txtBoxPolicyFee.Text == "")
                {
                    pbErrorFee.Visible = true;
                }
                else
                {
                    pbErrorFee.Visible = false;
                }
                if (txtBoxPolicyDate.Text == "")
                {
                    pbErrorYear.Visible = true;

                }
                else
                {
                    pbErrorYear.Visible = false;


                }
                if (cmbExpired.SelectedIndex == -1)
                {
                    pbErrorExpired.Visible = true;

                }
                else
                {
                    pbErrorExpired.Visible = false;
                }

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            policy.PolicyID1 = txtBoxPolicyId.Text;
            policy.DeletePolicy();
            policyTabSelected();//refresh the listview
            clearFields();
        }

        private void idGeneratorPolicy()
        {
            string sixDigits = "00";
            string[] type = { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random ran = new Random();
            string polCode = "";
            DateTime dt = DateTime.Now;
            string year = dt.Year.ToString();
            int iType = ran.Next(0, type.Length);
            polCode = sixDigits + year + type[iType];
            txtBoxPolicyId.Text = polCode;
        }

        private void clearFields()
        {
            txtBoxPolicyDesc.Text = "";
            txtBoxPolicyDate.Text = "";
            txtBoxImportance.Text = "";
            txtBoxPolicyFee.Text = "";
            cmbExpired.SelectedIndex = -1;
            idGeneratorPolicy();
            pbErrorFee.Visible = false;
            pbErrorImportance.Visible = false;
            pbErrorYear.Visible = false;
            pbErrorExpired.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
