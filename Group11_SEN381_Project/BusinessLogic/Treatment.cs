using Group11_SEN381_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Treatment
    {
        private int treatmentID;
        private string treatmentName;
        private string level;
        private int days;

        public int TreatmentID { get => treatmentID; set => treatmentID = value; }
        public string TreatmentName { get => treatmentName; set => treatmentName = value; }
        public string Level { get => level; set => level = value; }
        public int Days { get => days; set => days = value; }

        public Treatment()
        {

        }

        public Treatment(int treatmentID, string treatmentName, string level, int days)
        {
            this.TreatmentID = treatmentID;
            this.TreatmentName = treatmentName;
            this.Level = level;
            this.Days = days;
        }

        public DataTable getTreatment()
        {
            DataHandler dataHandler = new DataHandler();
            return dataHandler.getTreatment();
        }

        public void CreateTreatments()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.CreateTreatments(this);
        }
        
        public void DeleteTreatment()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteTreatment(this);
        }

        public void UpdateTreatments()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.UpdateTreatments(this);
        }
    }
}
