using Group11_SEN381_Project.BusinessLogic;
using Group11_SEN381_Project.DataAccess;
using MaterialSkin;
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
    public partial class Client : Form
    {
        private Form currentChildForm;
        //even handlers
        public event EventHandler AddNewEvent;
        public Client()
        {
            InitializeComponent();
            


        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientTabSelected();
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

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // to remove the border of the form
            childForm.Dock = DockStyle.Fill;
            panelClient.Controls.Add(childForm);
            panelClient.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddociateAndRaiseViewEvents()
        {
            ClientDetailEdit_Create clientDetailEdit_Create = new ClientDetailEdit_Create();
            // add new
            btnCreateClient.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                OpenChildForm(clientDetailEdit_Create);
                clientDetailEdit_Create.AddNewEvent += delegate
                {
                    clientTabSelected();
                };
                

            };
        }


        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientDetailEdit_Create());
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            
        }
    }
}
