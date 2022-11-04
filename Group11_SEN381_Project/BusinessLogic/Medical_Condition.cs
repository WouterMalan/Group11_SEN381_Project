using Group11_SEN381_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Medical_Condition
    {
        private string conditionID;
        private string ConditionName;
        private string Priority;

        public string ConditionID { get => conditionID; set => conditionID = value; }
        public string ConditionName1 { get => ConditionName; set => ConditionName = value; }
        public string Priority1 { get => Priority; set => Priority = value; }

        public Medical_Condition()
        {

        }

        public Medical_Condition(string conditionName, string priority)
        {
            ConditionName1 = conditionName;
            Priority1 = priority;
        }
        

       public void getMedicalCondition()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.getMedicalCondition();
        }

        public void CreateMedicalConditions()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.CreateMedicalConditions(this);
        }

        public void UpdateMedicalConditions()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.UpdateMedicalConditions(this);
        }

        public void DeleteMedicalCondition()
        {
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteMedicalCondition(this);
        }
    }
}
