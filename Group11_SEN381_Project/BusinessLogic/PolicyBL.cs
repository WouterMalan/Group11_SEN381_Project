using Group11_SEN381_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class PolicyBL
    {
        private string PolicyID;
        private string Description;
        private DateTime StartDate;
        private string Importance;
        private double Fee;
        private int Expired;

        public string PolicyID1 { get => PolicyID; set => PolicyID = value; }
        public string Description1 { get => Description; set => Description = value; }
        public DateTime StartDate1 { get => StartDate; set => StartDate = value; }
        public string Importance1 { get => Importance; set => Importance = value; }
        public double Fee1 { get => Fee; set => Fee = value; }
        public int Expired1 { get => Expired; set => Expired = value; }

        public PolicyBL()
        {

        }

        public PolicyBL(string id, string description, DateTime startDate, string importance, double fee, int expired)
        {
            this.PolicyID = id;
            Description1 = description;
            StartDate1 = startDate;
            Importance1 = importance;
            Fee1 = fee;
            Expired1 = expired;
        }

        public void getPolicy()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.getPolicy();
        }

        public void CreatePolicy()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.CreatePolicy(this);
        }

        public void UpdatePolicy()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.UpdatePolicy(this);
        }

        public void DeletePolicy()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeletePolicy(this);
        }
    }
}
