using Group11_SEN381_Project.DataAccess;
using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_SEN381_Project
{
    public partial class Policy : MaterialForm
    {
        public Policy()
        {
            InitializeComponent();
            //to change the skin of the UI Windows form
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue400, TextShade.WHITE);
        }

        private void Policy_Load(object sender, EventArgs e)
        {


            clientTabSelected();
            medicalConditionTabSelected();
            policyTabSelected();
            providerTabSelected();
            treatmentTabSelected();
        }

        public void clientTabSelected()
        {
            DataHandler dataHandler = new DataHandler();
            
            //the listview of the client tab
            materialListView1.Items.Clear();
            foreach (DataRow row in dataHandler.getClient().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Name_Surname"].ToString());
                item.SubItems.Add(row["Address"].ToString());
                item.SubItems.Add(row["Phone_Number"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Dependents"].ToString());
                item.SubItems.Add(row["National_id"].ToString());
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

        public void medicalConditionTabSelected()
        {
            DataHandler dataHandler = new DataHandler();
           
            //the listview of the medical Condition tab
            materialListView2.Items.Clear();
            foreach (DataRow row in dataHandler.getMedicalCondition().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Condition_Name"].ToString());
                item.SubItems.Add(row["Description"].ToString());
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
                    txtBoxConditionDesc.Text = item.SubItems[2].Text;

                }
            };
            materialListView2.GridLines = false;
            materialListView2.FullRowSelect = true;
            materialListView2.MultiSelect = false;
            materialListView2.View = View.Details;
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

        public void treatmentTabSelected()
        {
            {
                DataHandler dataHandler = new DataHandler();

                //the listview of the treatment tab
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
        }

        
    }
}
