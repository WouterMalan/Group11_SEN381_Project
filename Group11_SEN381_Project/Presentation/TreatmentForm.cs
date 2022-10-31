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
    public partial class TreatmentForm : Form
    {
        public TreatmentForm()
        {
            InitializeComponent();
        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            treatmentTabSelected();
        }

        public void treatmentTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the policy tab
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
