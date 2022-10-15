using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Provider
    {
        private string ProvName;
        private string Location;
        private int PhoneNum;
        private int Rating;
        public Provider()
        {

        }

        public Provider(string provName, string location, int phoneNum, int rating)
        {
            ProvName = provName;
            Location = location;
            PhoneNum = phoneNum;
            Rating = rating;
        }

        public void createProvider(string ProvName, string Location, int PhoneNum)
        {

        }

        public void getProvider(int ProvID)
        {

        }

        public void updateProvider(int ProvID, string ProvName, string Location)
        {

        }
        public void deleteProvider(int ProvID)
        {

        }
    }
}
