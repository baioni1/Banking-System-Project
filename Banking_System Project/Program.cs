using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Banking_System_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("AccountSummary.txt");
            bool exit = true;
            using (writer)
            {
                
               Client clientInfo = new Client();
               Account clientAccount = new Account(); 
               Console.WriteLine("Welcome to BaseLine Banking System");
               Console.WriteLine("Please choose from the Menu List");
               writer.WriteLine($"Account Name:    {clientInfo.ClientName}");
               writer.WriteLine($"Account Number:  {clientInfo.ClientAccountNum}");
                do
                {
                    decimal amount = 0.00M;
                    Console.WriteLine("");
                    Console.WriteLine("         Menu");
                    Console.WriteLine("*************************");
                    Console.WriteLine("1. Client Information\n2. Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit");
                    int userChoice = 0;
                    int.TryParse(Console.ReadLine(), out userChoice);
                    Console.Clear();
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine($"Account Name:    {clientInfo.ClientName}");
                            Console.WriteLine($"Account Number:  {clientInfo.ClientAccountNum}");
                            Console.WriteLine("");
                            break;
                        case 2:
                            
                            
                            Console.WriteLine($"Your account balance is:   ${clientAccount.AccountBalance}");
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.WriteLine("Please enter Deposit Amount:");
                            amount+= decimal.Parse(Console.ReadLine());
                            clientAccount.Deposit(amount);
                            writer.WriteLine("");
                            writer.WriteLine($"{clientAccount.Time}     +       ${amount}      ${clientAccount.AccountBalance}");
                            break;
                        case 4:
                            Console.WriteLine("Please enter Withdraw Amount:");
                            amount+= decimal.Parse(Console.ReadLine());
                            clientAccount.WithDraw(amount);
                            writer.WriteLine("");
                            writer.WriteLine($"{clientAccount.Time}     -       ${amount}      ${clientAccount.AccountBalance}");
                            //writer.WriteLine                   
                            break;
                        case 5:
                            Console.WriteLine("Thank you for Banking Online");
                            exit = false;                           
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }

                }
                while(exit);
            }
        }
    }
}
