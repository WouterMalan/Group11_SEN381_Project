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
        public ProviderForm()
        {
            InitializeComponent();
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            providerTabSelected();
        }

        public void providerTabSelected()
        {
            {
                DataHandler dataHandler = new DataHandler();

                //the listview of the provider tab
                ListViewProvider.Items.Clear();
                foreach (DataRow row in dataHandler.getProvider().Rows)
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
            dataHandler1.CreateProvider(int.Parse(txtBoxProviderId.Text),txtBoxProviderName.Text, txtBoxProviderLocation.Text, 
                int.Parse(cmbProviderRating.SelectedIndex.ToString()));
            providerTabSelected();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataHandler1.UpdateProvider(int.Parse(txtBoxProviderId.Text), txtBoxProviderName.Text, txtBoxProviderLocation.Text,
                int.Parse(cmbProviderRating.SelectedIndex.ToString()));
            providerTabSelected();
        }
    }
}
