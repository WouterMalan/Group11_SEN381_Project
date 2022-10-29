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
        private int clientPolicyMCTPID;
        private int mcID;
        private DateTime sTimeStamp;
        private DateTime eTimeStamp;
        private string claim;

        public Report(int id, int clientPolicyMCTPID, int mcID, DateTime sTimeStamp, DateTime eTimeStamp, string claim)
        {
            this.id = id;
            this.clientPolicyMCTPID = clientPolicyMCTPID;
            this.mcID = mcID;
            this.sTimeStamp = sTimeStamp;
            this.eTimeStamp = eTimeStamp;
            this.claim = claim;
        }

        public int Id { get => id; set => id = value; }
        public int ClientPolicyMCTPID { get => clientPolicyMCTPID; set => clientPolicyMCTPID = value; }
        public int McID { get => mcID; set => mcID = value; }
        public DateTime STimeStamp { get => sTimeStamp; set => sTimeStamp = value; }
        public DateTime ETimeStamp { get => eTimeStamp; set => eTimeStamp = value; }
        public string Claim { get => claim; set => claim = value; }
    }
}
