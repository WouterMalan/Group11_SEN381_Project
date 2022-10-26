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
    public partial class ProviderForm : Form
    {
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
                materialListView4.Items.Clear();
                foreach (DataRow row in dataHandler.getProvider().Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["Name"].ToString());
                    item.SubItems.Add(row["Location"].ToString());
                    item.SubItems.Add(row["Rating"].ToString());
                    materialListView4.Items.Add(item);
                }
                //display the selected listview item in the textboxes
                materialListView4.SelectedIndexChanged += (s, args) =>
                {
                    if (materialListView4.SelectedItems.Count > 0)
                    {
                        ListViewItem item = materialListView4.SelectedItems[0];
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
                materialListView4.GridLines = false;
                materialListView4.FullRowSelect = true;
                materialListView4.MultiSelect = false;
                materialListView4.View = View.Details;
            }
        }
    }
}
