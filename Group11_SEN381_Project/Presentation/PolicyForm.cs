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
    }
}
