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


        //fields
        private string name = "Lexus Davis";             
        private int accountNumber;        
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
            Console.WriteLine(this.Name + ": Your Account Number: " + this.AccountNumber);
        }

        //constructor
        public Client()
        {
        }
        public Client(string name)
        {            
            this.Name = name;
        }
                      
        }
    }

