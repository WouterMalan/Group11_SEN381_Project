using Group11_SEN381_Project.BusinessLogic;
using Group11_SEN381_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_SEN381_Project.Presentation
{
    public partial class Report : Form
    {
        BusinessLogic.Report report = new BusinessLogic.Report();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            reportTabSelected();
        }

        public void reportTabSelected()
        {
            DataHandler dataHandler = new DataHandler();
            //the listview of the policy tab
            materialListView3.Items.Clear();
            foreach (DataRow row in report.getReport().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Client_ID"].ToString());
                item.SubItems.Add(row["MC_ID"].ToString());
                item.SubItems.Add(row["Policy_ID"].ToString());
                item.SubItems.Add(row["STimeStamp"].ToString());
                item.SubItems.Add(row["ETimeStamp"].ToString());
                item.SubItems.Add(row["Claim"].ToString());
                materialListView3.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView3.SelectedIndexChanged += (s, args) =>
            {
                if (materialListView3.SelectedItems.Count > 0)
                {
                    ListViewItem item = materialListView3.SelectedItems[0];
                    txtBoxReportid.Text = item.SubItems[0].Text;
                    txtBoxClientID.Text = item.SubItems[1].Text;
                    txtBoxMC_ID.Text = item.SubItems[2].Text;
                    txtBoxPolicyID.Text = item.SubItems[3].Text;
                    txtBoxSTime.Text = item.SubItems[4].Text;
                    txtBoxETime.Text = item.SubItems[5].Text;
                    //display value from listview in combo box
                    if (item.SubItems[6].Text == "Unknown")
                    {
                        cmbClaim.SelectedIndex = 0;
                    }
                    else if (item.SubItems[6].Text == "Approved")
                    {
                        cmbClaim.SelectedIndex = 1;
                    }
                    else
                    {
                        cmbClaim.SelectedIndex = 2;
                    }
                }
            };
            materialListView3.GridLines = false;
            materialListView3.FullRowSelect = true;
            materialListView3.MultiSelect = false;
            materialListView3.View = View.Details;
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            report.Id = int.Parse(txtBoxReportid.Text);
            report.DeleteReport();
            reportTabSelected();
        }
        
        private void clearFields()
        {
            
                txtBoxReportid.Text = "";
                txtBoxClientID.Text = "";
                txtBoxMC_ID.Text = "";
                txtBoxETime.Text = "";
                txtBoxSTime.Text = "";
                cmbClaim.SelectedIndex = -1;
           
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUpdateReport_Click(object sender, EventArgs e)
        {
            report.Id = int.Parse(txtBoxReportid.Text);
            report.Client_ID = txtBoxClientID.Text;
            report.McID = txtBoxMC_ID.Text;
            report.Policy_ID = txtBoxPolicyID.Text;
            report.STimeStamp = DateTime.Parse(txtBoxSTime.Text);
            report.ETimeStamp = DateTime.Parse(txtBoxETime.Text);
            report.Claim = cmbClaim.SelectedItem.ToString();
            report.UpdateReport();
            reportTabSelected();

        }
    }
}
