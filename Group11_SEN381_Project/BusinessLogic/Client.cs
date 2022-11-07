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
        private string phoneNum;
        private string email;
        private string dependants;
        private string natID;
        private string policyID;


        public string ID { get => id; set => id = clientIDGenerator(id); }// set the id to the value of the clientIDGenerator method

        public string FullName   { get => fullName; set => fullName = value; }
        public string Address    { get => address; set => address = value; }
        public string PhoneNum   { get => phoneNum; set => phoneNum = value; }
        public string Email      { get => email; set => email = value; }
        public string Dependants { get => dependants; set => dependants = value; }
        public string NatID      { get => natID; set => natID = value; }
        public string PolicyID   { get => policyID; set => policyID = value; }

        public Client(){}
        
        public Client(string fullName, string address, string phoneNum, string email, string dependants, string natID,string policy_ID)
        {
            this.FullName = fullName;
            this.Address = address;
            this.PhoneNum = phoneNum;
            this.Email = email;
            this.Dependants = dependants;
            this.NatID = natID;
            this.PolicyID = policy_ID;
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

        // generate client ID
        public string clientIDGenerator(string id)
        {
            string[] characters = { "G", "H", "J", "K", "L" };
            string[] numbers    = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random ran = new Random();
            string code = "";
            int letter = ran.Next(0, characters.Length);
            for (int i = 0; i < 8; i++)
            {
                int number = ran.Next(0, numbers.Length);
                code = code + numbers[number];
            }
            code = characters[letter] + code;
            return code;
        }
    }
}
