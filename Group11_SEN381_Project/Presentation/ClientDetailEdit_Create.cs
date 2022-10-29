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
    public partial class ClientDetailEdit_Create : Form
    {
      

        public event EventHandler AddNewEvent;
        public ClientDetailEdit_Create()
        {
            InitializeComponent();
            AddociateAndRaiseViewEvents();
        }

        private void ClientDetailEdit_Create_Load(object sender, EventArgs e)
        {

        }

        private void AddociateAndRaiseViewEvents()
        {
            // add new
            btnSaveClient.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                CreateEditTabControl.TabPages.Remove(MedicalTabPage);
                CreateEditTabControl.TabPages.Add(ClientEditCreate);
                ClientEditCreate.Text = "Create Client";

            };
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {

        }


        
    }
}
