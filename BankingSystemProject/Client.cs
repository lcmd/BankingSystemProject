using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemProject
{
    class Client
    {
        //client class
        //client name
        //client acct number
        //random method to generate account number

        //fields
        private string name = "Lexus Davis";
        private int accountNumber = 0;
        

        //properties

       public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        //methods
        public void Userinfo()
        {            
            Console.WriteLine(this.name + " Account Number: " + this.accountNumber);
        }

        public Client()
        {
        }
             public Client(string name, int accountNumber)
        {
            Random accoutNumberGenerator = new Random(); //object instantiation
            this.AccountNumber = accoutNumberGenerator.Next(100, 300);
            this.Name = name;
        }
    
       
           
        }
    }

