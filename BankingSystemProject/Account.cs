using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemProject
{
    class Account
    {
        //accounts class
        //+ for deposit 
        //- for withdraw
        //show transaction amount
        //show new balance

        //fields          
        double balance;
        double depositAmount;
        double withdrawAmount;        
        //properties        
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
       public double DepositAmount
        {
            get { return this.depositAmount; } 
            set { this.depositAmount = value; }
        }
        public double WithdrawAmount
        {
            get { return this.withdrawAmount; } 
            set { this.withdrawAmount = value; }
        }       
              
        //withdraw method
        public void Withdraw()
        {
            Console.WriteLine("Amount of money you want to withdraw?");
            double amount =double.Parse(Console.ReadLine());
            this.Balance -= amount;
            this.WithdrawAmount = amount;
        }

        //deposit method
        public void Deposit()
        {
            Console.WriteLine("What amount of money would you like to Deposit?");
            double amount = double.Parse(Console.ReadLine());
            this.Balance += amount;
            this.DepositAmount = amount;       
        }
        //balance method
        public void GetBalance()
        {
            Console.WriteLine("Balance, ${0}", this.balance);
        }
        //constructor
        public Account()
        {

        }
        public Account(double depositAmount, double withdrawAmount)
        {
            this.DepositAmount = depositAmount;
            this.WithdrawAmount = withdrawAmount;
        }
       
        public Account(double balance)
        {            
            this.Balance = balance;
            //this.FirstName = firstName;
            //this.LastName = lastName;            
        }

    }
}
