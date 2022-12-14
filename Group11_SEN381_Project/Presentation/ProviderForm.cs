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
    public partial class ProviderForm : Form
    {
        DataHandler dataHandler1 = new DataHandler();
        Provider provider = new Provider();
        public ProviderForm()
        {
            InitializeComponent();
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            providerTabSelected();
            idGeneratorProvider();
            pbErrorLocation.Visible = false;
            pbErrorName.Visible = false;
        }

        public void providerTabSelected()
        {
            {
                DataHandler dataHandler = new DataHandler();

                //the listview of the provider tab
                ListViewProvider.Items.Clear();
                foreach (DataRow row in provider.getProvider().Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["Name"].ToString());
                    item.SubItems.Add(row["Location"].ToString());
                    item.SubItems.Add(row["Rating"].ToString());
                    ListViewProvider.Items.Add(item);
                }
                //display the selected listview item in the textboxes
                ListViewProvider.SelectedIndexChanged += (s, args) =>
                {
                    if (ListViewProvider.SelectedItems.Count > 0)
                    {
                        ListViewItem item = ListViewProvider.SelectedItems[0];
                        txtBoxProviderId.Text = item.SubItems[0].Text;
                        txtBoxProviderName.Text = item.SubItems[1].Text;
                        txtBoxProviderLocation.Text = item.SubItems[2].Text;
                        switch (item.SubItems[3].Text)
                        {
                            case "1":
                                cmbProviderRating.SelectedIndex = 0;
                                break;
                            case "2":
                                cmbProviderRating.SelectedIndex = 1;
                                break;
                            case "3":
                                cmbProviderRating.SelectedIndex = 2;
                                break;
                            case "4":
                                cmbProviderRating.SelectedIndex = 3;
                                break;
                            case "5":
                                cmbProviderRating.SelectedIndex = 4;
                                break;
                        }

                    }
                };
                ListViewProvider.GridLines = false;
                ListViewProvider.FullRowSelect = true;
                ListViewProvider.MultiSelect = false;
                ListViewProvider.View = View.Details;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            ListViewProvider.Items.Clear();
            if (txtBoxProviderSearch.Text != "")// if the search textbox is not empty
            {
                // check if the search textbox is a number
                if (txtBoxProviderSearch.Text != null && txtBoxProviderSearch.Text.All(char.IsDigit))
                {
                    foreach (DataRow row in dataHandler.searchProvider(int.Parse(txtBoxProviderSearch.Text)).Rows)
                    {
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["Name"].ToString());
                        item.SubItems.Add(row["Location"].ToString());
                        item.SubItems.Add(row["Rating"].ToString());
                        ListViewProvider.Items.Add(item);
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
                providerTabSelected();
                //show error message
                MessageBox.Show("Please enter a valid Provider ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBoxProviderId.Text != "" && txtBoxProviderName.Text != "" && txtBoxProviderLocation.Text != "" && cmbProviderRating.SelectedIndex !=-1)
            {
                provider.ProviderID = int.Parse(txtBoxProviderId.Text);
                provider.ProvName = txtBoxProviderName.Text;
                provider.Location = txtBoxProviderLocation.Text;
                provider.Rating = int.Parse(cmbProviderRating.SelectedItem.ToString());
                provider.CreateProvider();
                providerTabSelected();
                idGeneratorProvider();
                clearFields();
            }
            else
            {
                
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(txtBoxProviderName.Text == "")
                {
                    pbErrorName.Visible = true;
                    txtBoxProviderName.Focus();
                }
                else
                {
                    pbErrorName.Visible = false;
                }
                if (txtBoxProviderLocation.Text == "")
                {
                    pbErrorLocation.Visible = true;
                    txtBoxProviderLocation.Focus();
                }
                else
                {
                        pbErrorLocation.Visible = false;
                }
                
            }
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxProviderId.Text != "" && txtBoxProviderName.Text != "" && txtBoxProviderLocation.Text != "" && cmbProviderRating.SelectedIndex != -1)
            {
                provider.ProviderID = int.Parse(txtBoxProviderId.Text);
                provider.ProvName = txtBoxProviderName.Text;
                provider.Location = txtBoxProviderLocation.Text;
                provider.Rating = int.Parse(cmbProviderRating.SelectedItem.ToString());
                provider.UpdateProvider();
                providerTabSelected();
                idGeneratorProvider();
                clearFields();
            }
            else
            {

                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtBoxProviderName.Text == "")
                {
                    pbErrorName.Visible = true;
                    txtBoxProviderName.Focus();
                }
                else
                {
                    pbErrorName.Visible = false;
                }
                if (txtBoxProviderLocation.Text == "")
                {
                    pbErrorLocation.Visible = true;
                    txtBoxProviderLocation.Focus();
                }
                else
                {
                    pbErrorLocation.Visible = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxProviderId.Text != "")
            {
                provider.ProviderID = int.Parse(txtBoxProviderId.Text);
                provider.DeleteProvider();
                providerTabSelected();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            providerTabSelected();
            clearFields();
        }

        private void idGeneratorProvider()
        {
            int id = 0;
            foreach (DataRow row in provider.getProvider().Rows)
            {
                id = int.Parse(row["id"].ToString());
            }
            id++;
            txtBoxProviderId.Text = id.ToString();
        }

        private void clearFields()
        {
            txtBoxProviderName.Text = "";
            txtBoxProviderLocation.Text = "";
            cmbProviderRating.SelectedIndex = -1;
            idGeneratorProvider();
            pbErrorName.Visible = false;
            pbErrorLocation.Visible = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
