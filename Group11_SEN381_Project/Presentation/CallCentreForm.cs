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
        Report report = new Report();
        public CallCentreForm()
        {
            InitializeComponent();
        }

        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            if (txtBoxClientId.Text != "" && txtBoxConditionName.Text != "" && txtBoxConditionDesc.Text != "")
            {
                report.Client_ID = txtBoxClientId.Text;
                report.Description1 = txtBoxConditionName.Text;
                report.StartDate1 = txtBoxConditionDesc.Text;
                report.CallCenterCheck();
                reportTabSelected();// refresh the listview
                clearFields();

            }
            DateTime now = DateTime.Now;
        }
    }
}
