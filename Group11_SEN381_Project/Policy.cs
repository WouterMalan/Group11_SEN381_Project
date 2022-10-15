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
    public partial class Policy : Form
    {
        public Policy()
        {
            InitializeComponent();
        }

        private void Policy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalCallCenterDataSet.Policy' table. You can move, or remove it, as needed.
            this.policyTableAdapter.Fill(this.medicalCallCenterDataSet.Policy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit button
            this.Close();
        }
    }
}
