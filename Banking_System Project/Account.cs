using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System_Project
{
    class Account
    {
        //fields
        private decimal accountBalance;
        private DateTime time = new DateTime();

        public Account()
        {
            this.AccountBalance = 100.00M;
        }
        public decimal AccountBalance { get; set; }
        public DateTime Time { get; set; }

        public void WithDraw(decimal minusAmount)
        {
            this.Time = DateTime.Now;
            this.AccountBalance -= minusAmount;
        }
        public void Deposit(decimal addAmount )
        {
            this.Time = DateTime.Now;
            this.AccountBalance += addAmount;
        }

    }
}
