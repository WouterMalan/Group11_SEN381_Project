using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_SEN381_Project.BusinessLogic
{
    internal class Client_LogicHandler
    {
        public void clientIDGenerator(string id)
        {
            string[] characters = { "G", "H", "J", "K", "L" };
            string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random ran = new Random();
            for (int n = 0; n < 200; n++)
            {
                string code = "";
                int letter = ran.Next(0, characters.Length);
                for (int i = 0; i < 8; i++)
                {
                    int number = ran.Next(0, numbers.Length);
                    code = code + numbers[number];
                }
                code = characters[letter] + code;
                
            }
        }
    }
}
