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
            DataHandler dataHandler = new DataHandler();
            // add new
            btnSaveClient.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                //dataHandler.CreateClient(int.Parse(txtBoxId.Text),txtBoxFullName.Text, txtBoxAddress.Text, txtBoxPhoneNumber.Text, txtBoxEmail.Text, 
                //    txtBoxDependents.Text, int.Parse(txtBoxNationalId.Text));

            };
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            //AddociateAndRaiseViewEvents();// add new event handler to the button
        }
    }
}
