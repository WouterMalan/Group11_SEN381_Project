using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    internal class Report
    {
        private int id;
        private string client_ID;
        private string mcID;
        private string policy_ID;
        private DateTime sTimeStamp;
        private DateTime eTimeStamp;
        private string claim;

        public Report(int id, string client_ID, string mcID,string policy_ID, DateTime sTimeStamp, DateTime eTimeStamp, string claim)
        {
            this.id = id;
            this.Client_ID = client_ID;
            this.mcID = mcID;
            this.Policy_ID = policy_ID;
            this.sTimeStamp = sTimeStamp;
            this.eTimeStamp = eTimeStamp;
            this.claim = claim;
        }

        public int Id { get => id; set => id = value; }
        public string Client_ID { get => client_ID; set => client_ID = value; }
        public string McID { get => mcID; set => mcID = value; }
        public DateTime STimeStamp { get => sTimeStamp; set => sTimeStamp = value; }
        public DateTime ETimeStamp { get => eTimeStamp; set => eTimeStamp = value; }
        public string Claim { get => claim; set => claim = value; }
        public string Policy_ID { get => policy_ID; set => policy_ID = value; }
    }
}
