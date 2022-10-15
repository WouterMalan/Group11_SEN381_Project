using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Policy
    {
        private int PolicyID;
        private string Description;
        private DateTime StartDate;
        private string PolicyType;
        private double Fee;
        private int Expired;
        
        public Policy()
        {

        }

        public Policy(int policyID, string description, DateTime startDate, string policyType, double fee, int expired)
        {
            PolicyID = policyID;
            Description = description;
            StartDate = startDate;
            PolicyType = policyType;
            Fee = fee;
            Expired = expired;
        }

        public void createPolicy(string Description, DateTime StartDate, double Fee, int Expired)
        {

        }

        public void getPolicy(int PolicyID)
        {

        }

        public void updatePolicy(int PolicyID, string Description, DateTime StartDate, double Fee, int Expired)
        {

        }
        public void deletePolicy(int PolicyID)
        {

        }
    }
}
