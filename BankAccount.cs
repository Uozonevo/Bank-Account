using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_11_2
{
    internal class BankAccount
    {
        // data members
        protected int routingNumber;
        protected double balance;
        protected string accountUserName;

        public BankAccount(int routingNumber, double balance, string accountUserName) // overloading constructor
        {
            this.routingNumber = routingNumber;
            this.balance = balance;
            this.accountUserName = accountUserName;
        }
        public int RoutingNumber                 // Routing Number property
        { 
            get { return this.routingNumber; } 
            set { this.routingNumber = value; } 
        }
        public double Balance                       // Balance property
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string Name                          // Name property
        { 
            get { return this.accountUserName; } 
            set { this.accountUserName = value; } 
        }
        public override string ToString()           // print string 
        {
            return string.Format($"Routing Number: {routingNumber}\tAccount Holder: {accountUserName}\nBalance: {balance}");
        }
        ~BankAccount() { }                          // destructor
    }
}
