using Group11_SEN381_Project.BusinessLogic;
using Group11_SEN381_Project.DataAccess;
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
    public partial class Client : Form
    {
        private Form currentChildForm;
        DataHandler dataHandler1 = new DataHandler();
        BusinessLogic.Client client = new BusinessLogic.Client();
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientTabSelected();
            txtBoxId.Text = client.clientIDGenerator().ToString();
        }

        public void clientTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the client tab
            materialListView1.Items.Clear();
            foreach (DataRow row in client.getClient().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Name_Surname"].ToString());
                item.SubItems.Add(row["Address"].ToString());
                item.SubItems.Add(row["Phone_Number"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Dependents"].ToString());
                item.SubItems.Add(row["National_id"].ToString());
                item.SubItems.Add(row["Provider_ID"].ToString());
                materialListView1.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView1.SelectedIndexChanged += (s, args) =>
            {
                if (materialListView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = materialListView1.SelectedItems[0];
                    txtBoxId.Text = item.SubItems[0].Text;
                    txtBoxFullName.Text = item.SubItems[1].Text;
                    txtBoxAddress.Text = item.SubItems[2].Text;
                    txtBoxPhoneNumber.Text = item.SubItems[3].Text;
                    txtBoxEmail.Text = item.SubItems[4].Text;
                    txtBoxDependents.Text = item.SubItems[5].Text;
                    txtBoxNationalId.Text = item.SubItems[6].Text;

                }
            };
            materialListView1.GridLines = false;
            materialListView1.FullRowSelect = true;
            materialListView1.MultiSelect = false;
            materialListView1.View = View.Details;
        }

        // This method is used to open a child form inside a panel
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // to remove the border of the form
            childForm.Dock = DockStyle.Fill;
            panelClient.Controls.Add(childForm);
            panelClient.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            materialListView1.Items.Clear();
            if (txtBoxClientSearch.Text != "")// if the search textbox is not empty
            {
                // check if the search textbox is a number
                if (txtBoxClientSearch.Text != null && txtBoxClientSearch.Text.All(char.IsDigit))
                {
                    foreach (DataRow row in dataHandler.searchClient(int.Parse(txtBoxClientSearch.Text)).Rows)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["Name_Surname"].ToString());
                        item.SubItems.Add(row["Address"].ToString());
                        item.SubItems.Add(row["Phone_Number"].ToString());
                        item.SubItems.Add(row["Email"].ToString());
                        item.SubItems.Add(row["Dependents"].ToString());
                        item.SubItems.Add(row["National_id"].ToString());
                        item.SubItems.Add(row["Provider_ID"].ToString());
                        materialListView1.Items.Add(item);
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
                clientTabSelected();
                //show error message
                MessageBox.Show("Please enter a valid client id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            
            client.ID = txtBoxId.Text;
            client.FullName = txtBoxFullName.Text;
            client.Address = txtBoxAddress.Text;
            client.PhoneNum = txtBoxPhoneNumber.Text;
            client.Email = txtBoxEmail.Text;
            client.Dependants = txtBoxDependents.Text;
            client.NatID = txtBoxNationalId.Text;
            client.PolicyID = txtBoxPolicyId.Text;
            client.CreateClient();
            clientTabSelected();
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.ID = txtBoxId.Text;
            client.FullName = txtBoxFullName.Text;
            client.Address = txtBoxAddress.Text;
            client.PhoneNum = txtBoxPhoneNumber.Text;
            client.Email = txtBoxEmail.Text;
            client.Dependants = txtBoxDependents.Text;
            client.NatID = txtBoxNationalId.Text;
            client.PolicyID = txtBoxPolicyId.Text;
            client.updateClient();
            clientTabSelected();
            clearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.ID = txtBoxId.Text;
            client.DeleteClient();
            clientTabSelected();
            clearFields();
        }
        
        private void clearFields()
        {
            
                txtBoxId.Text = "";
                txtBoxFullName.Text = "";
                txtBoxAddress.Text = "";
                txtBoxPhoneNumber.Text = "";
                txtBoxEmail.Text = "";
                txtBoxDependents.Text = "";
                txtBoxNationalId.Text = "";
                txtBoxPolicyId.Text = "";
            
        }
    }
}
