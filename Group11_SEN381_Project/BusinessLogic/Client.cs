using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Client
    {
        private string FullName;
        private string Address;
        private int PhoneNum;
        private string Email;
        private string Dependants;
        private int NatID;
        public Client()
        {

        }

        public Client(string fullName, string address, int phoneNum, string email, string dependants, int natID)
        {
            FullName = fullName;
            Address = address;
            PhoneNum = phoneNum;
            Email = email;
            Dependants = dependants;
            NatID = natID;
        }

        public void createClient(string FullName,string Address, int PhoneNum,string Email, string Dependants, int NatID) 
        {
        
        }

        public void getClient(int ClientID) 
        {
            
        }

        public void updateClient(int ClientID, string FullName, int PhoneNum, string Dependants, int NatID)
        {

        }
        public void deleteClient(int ClientID) 
        {
        
        }
    }
}
