using Group11_SEN381_Project.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_SEN381_Project.BusinessLogic
{
    internal class ClientPresenter
    {
        private IClientView view;
        private Client client;

        public ClientPresenter(IClientView view)
        {
            this.view = view;
            client = new Client();
            AddociateAndRaiseViewEvents();
        }

        private void AddociateAndRaiseViewEvents()
        {
            // search
            view.SearchEvent += delegate
            {
                client = new Client(view.FullName, view.Address, view.PhoneNum, view.Email, view.Dependants, view.NatID);
                if (client.SearchClient())
                {
                    view.FullName = client.FullName;
                    view.Address = client.Address;
                    view.PhoneNum = client.PhoneNum;
                    view.Email = client.Email;
                    view.Dependants = client.Dependants;
                    view.NatID = client.NatID;
                }
                else
                {
                    MessageBox.Show("Client not found");
                }
            };

            // add new
            view.AddNewEvent += delegate
            {
                client = new Client(view.FullName, view.Address, view.PhoneNum, view.Email, view.Dependants, view.NatID);
                if (client.AddNewClient())
                {
                    MessageBox.Show("Client added successfully");
                }
                else
                {
                    MessageBox.Show("Client not added");
                }
            };

            // edit
            view.EditEvent += delegate
            {
                client = new Client(view.FullName, view.Address, view.PhoneNum, view.Email, view.Dependants, view.NatID);
                if (client.EditClient())
                {
                    MessageBox.Show("Client edited successfully");
                }
                else
                {
                    MessageBox.Show("Client not edited");
                }
            };

            // delete
            view.DeleteEvent += delegate
            {
                client = new Client(view.FullName, view.Address, view.PhoneNum, view.Email, view.Dependants, view.NatID);
                if (client.DeleteClient())
                {
                    MessageBox.Show("Client deleted successfully");
                }
                else
                {
                    MessageBox.Show("Client not deleted");
                }
            };

            // save
            view.SaveEvent += delegate
            {
                client = new Client(view.FullName, view.Address, view.PhoneNum, view.Email, view.Dependants, view.NatID);
                if (client.SaveClient())
                {
                    MessageBox.Show("Client saved successfully");
                }
                else
                {
                    MessageBox.Show("Client not saved");
                }
            };

            // cancel
            view.CancelEvent += delegate
            {
                client = new Client(view.FullName, view.Address, view.PhoneNum, view.Email, view.Dependants, view.NatID);
                if (client.CancelClient())
                {
                    MessageBox.Show("Client cancelled successfully");
                }
                else
                {
                    MessageBox.Show("Client not cancelled");
                }
            };

        }

    }
}
