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
    public partial class Medical_Condition_Form : Form
    {
        public Medical_Condition_Form()
        {
            InitializeComponent();
        }

        private void Medical_Condition_Form_Load(object sender, EventArgs e)
        {
            medicalConditionTabSelected();
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
    }
}
