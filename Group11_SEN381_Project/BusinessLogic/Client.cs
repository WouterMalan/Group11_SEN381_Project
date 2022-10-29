using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Group11_SEN381_Project.BusinessLogic
{
    class Client
    {
        private string fullName;
        private string address;
        private int phoneNum;
        private string email;
        private string dependants;
        private int natID;

        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Client Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 1 to 30 characters")]
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Client Phone number is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be 10 digits")]
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Client Email is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Email must be between 1 to 50 characters")]
        public string Email { get => email; set => email = value; }
        public string Dependants { get => dependants; set => dependants = value; }

        [DisplayName("National ID")]
        [Required(ErrorMessage = "Client National ID is required")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "National ID must be 13 digits")]
        public int NatID { get => natID; set => natID = value; }

        public Client()
        {

        }
        
        public Client(string fullName, string address, int phoneNum, string email, string dependants, int natID)
        {
            this.FullName = fullName;
            this.Address = address;
            this.PhoneNum = phoneNum;
            this.Email = email;
            this.Dependants = dependants;
            this.NatID = natID;
        }



        public bool SearchClient()
        {
            //search for client in database
            return true;
        }

        public bool AddNewClient()
        {
            //add new client to database
            return true;
        }

        public bool EditClient()
        {
            //edit client in database
            return true;
        }

        public bool DeleteClient()
        {
            //delete client from database
            return true;
        }

        public bool SaveClient()
        {
            //save client to database
            return true;
        }

        public bool CancelClient()
        {
            //cancel client
            return true;
        }


    }
}
