using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Group11_SEN381_Project.DataAccess;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Client
    {
        private string id;
        private string fullName;
        private string address;
        private int phoneNum;
        private string email;
        private string dependants;
        private int natID;


        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public string Dependants { get => dependants; set => dependants = value; }
        public int NatID { get => natID; set => natID = value; }

        public Client()
        {

        }
        
        public Client(string fullName, string address, int phoneNum, string email, string dependants, int natID)
        {
            this.FullName = fullName;
            this.Address = address;
            this.PhoneNum = phoneNum;
            this.Email = email;
            this.Dependants = dependants;
            this.NatID = natID;
        }


        public void CreateClient()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.CreateClient(this);
            
        }

        public void updateClient()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.updateClient(this);
        }
        
        public void DeleteClient()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteClient(this);
        }

        public void getClient()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.getClient();
        }
    }
}
