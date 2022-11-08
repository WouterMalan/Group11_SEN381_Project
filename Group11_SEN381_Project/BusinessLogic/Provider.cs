using Group11_SEN381_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Provider
    {
        private int providerID;
        private string provName;
        private string location;
        private int phoneNum;
        private int rating;

        
        public string ProvName { get => provName; set => provName = value; }
        public string Location { get => location; set => location = value; }
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }
        public int Rating { get => rating; set => rating = value; }
        public int ProviderID { get => providerID; set => providerID = value; }

        public Provider()
        {

        }

        public Provider(string provName, string location, int phoneNum, int rating)
        {
            this.ProvName = provName;
            this.Location = location;
            this.PhoneNum = phoneNum;
            this.Rating = rating;
        }

        public DataTable getProvider()
        {
            DataHandler dataHandler = new DataHandler();
            return dataHandler.getProvider();
        }
        
        public void UpdateProvider()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.UpdateProvider(this);
            
        }

        public void DeleteProvider()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteProvider(this);
        }

        public void CreateProvider()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.CreateProvider(this);
        }
    }
}
