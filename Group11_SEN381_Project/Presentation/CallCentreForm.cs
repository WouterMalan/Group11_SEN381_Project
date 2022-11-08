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
    public partial class CallCentreForm : Form
    {
        DataHandler dataHandler1 = new DataHandler();
        BusinessLogic.Report report = new BusinessLogic.Report();
        BusinessLogic.Client client = new BusinessLogic.Client();
        public CallCentreForm()
        {
            InitializeComponent();
            btnEndCall.Enabled = false;
        }
        private void idGeneratorTreatment()
        {
            int id = 0;
            foreach (DataRow row in report.getReport().Rows)
            {
                id = int.Parse(row["id"].ToString());
            }
            id++;
            txtBoxID.Text = id.ToString();
        }

        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            idGeneratorTreatment();
            btnAnswerCall.Enabled = false;
            btnEndCall.Enabled = true;
            DateTime now = DateTime.Now;
            report.STimeStamp = now;
            
        }
        public void reportTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the client tab
            materialListView2.Items.Clear();
            foreach (DataRow row in client.getClient().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Name_Surname"].ToString());
                item.SubItems.Add(row["Address"].ToString());
                item.SubItems.Add(row["Phone_Number"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Dependents"].ToString());
                item.SubItems.Add(row["National_id"].ToString());
                item.SubItems.Add(row["Policy_ID"].ToString());
                materialListView2.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView2.GridLines = false;
            materialListView2.FullRowSelect = true;
            materialListView2.MultiSelect = false;
            materialListView2.View = View.Details;
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            btnAnswerCall.Enabled = true;
            btnEndCall.Enabled = false;
            if (txtBoxClientId.Text != "" && txtBoxMedicalConditionID.Text != "" && txtBoxPolicyID.Text != "")
            {
                
                report.Id = int.Parse(txtBoxID.Text);
                report.Client_ID = txtBoxClientId.Text;
                report.McID = txtBoxMedicalConditionID.Text;
                report.Policy_ID = txtBoxPolicyID.Text;
                DateTime now = DateTime.Now;
                report.ETimeStamp = now;
                report.Claim = "Unknown";
                report.CreateReport();

            }
        }

        private void CallCentreForm_Load(object sender, EventArgs e)
        {
            reportTabSelected();// refresh the listview
        }
    }
}
