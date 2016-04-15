using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Project
{
    class Client
    {
        private string clientName;
        private int clientAccountNum;
        private Random rand = new Random();

        public string ClientName { get; set; }

        public int ClientAccountNum { get; set; }
        
        public Client()
        {
            this.ClientName = "Julie Baioni";
            this.ClientAccountNum = RandomGenerator();
        }
        public int RandomGenerator()
        {
            int randomNumber = rand.Next(10000, 99999);
            return randomNumber;
        }

    }
}
