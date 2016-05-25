using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankingSystemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankMenu();
            Swag();
            Account account = new Account();
            Swag();            
            Client accountNew = new Client();
            //random number generator
            Random accoutNumberGenerator = new Random(); //object instantiation
            accountNew.AccountNumber = accoutNumberGenerator.Next(100000, 999999);
            int bankMenu = 0;
          
            do
            {
                Console.WriteLine("If you want to pursue more than one transaction press the number that corresponds to what you want to do. \nEx: If you want to check balance press 2, if you want to Deposit money after checking balance press 3.");
                Swag();
                // Console.WriteLine("1-View Client Info, 2 - View Balance, 3 - Deposit, 4 - Withdrawal, 5 - Exit");
                bankMenu = int.Parse(Console.ReadLine());
                Swag();
                switch (bankMenu)
                {
                    case 1:
                        //view client info
                        accountNew.Userinfo();
                        Swag();
                        break;                       
                    case 2:
                        Console.WriteLine("\n" + accountNew.AccountNumber);
                        account.GetBalance();
                        Swag();
                        break;
                    case 3:
                        account.Deposit();
                        Console.WriteLine(DateTime.Now);
                        account.GetBalance();
                        Swag();                       
                        break;
                    case 4:
                        account.Withdraw();
                        Console.WriteLine(DateTime.Now);
                        account.GetBalance();
                        Swag();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        Console.WriteLine("Thank you for banking with Lexus C. M. Davis Banking, \"Where we keep your money out of reach from the Feds!\"");
                        Swag();
                        break;
                    default:
                        Console.WriteLine("NUMBERS 1-5 ARE THE ONLY NUMBERS YOU CAN USE WHILE CHOOSING FROM MENU..\nLexus C. M. Davis Banking appreciates YOU!!");
                        Swag();
                        break;
                }
            } while (bankMenu != 5);
            string accountsummary = ("AccountSummary.txt");
            StreamWriter summary = new StreamWriter(accountsummary);
            using (summary)
            {
                summary.WriteLine(DateTime.Now);
                summary.WriteLine("Lexus C. M. Davis Banking");
                summary.WriteLine("Swagger, USA");
                Swag();
                summary.WriteLine("Client Name: {0}", accountNew.Name);
                
                summary.WriteLine("Account Number: {0} ", accountNew.AccountNumber);
                summary.WriteLine("Withdraw -: {0}", account.WithdrawAmount); 
                summary.WriteLine("Deposit + : {0}", account.DepositAmount);
                summary.WriteLine("Account Balance: {0}", account.Balance);
            }
        }
            //while (playAgain == "y");

        public static void BankMenu()
        {
            //menu class
            //1. view client info
            //2. view account info
            //3. deposit funds
            //4. withdraw
            //5. exit

            Console.WriteLine("-----------------------------");
            Console.WriteLine("**Lexus C. M. Davis Banking**");
            Console.WriteLine("-----------------------------");
            Swag(); //spacer 
            Console.WriteLine("Choose a menu option.");
            Swag();
            Console.WriteLine("1. View Client Info: ");
            Console.WriteLine("2. View Account Info: ");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }

        //spacer method
        static void Swag()
        {
            Console.WriteLine();
        }
       
    }

   
}
           
   
    


    

    
        


    

