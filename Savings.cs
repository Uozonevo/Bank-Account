using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_11_2
{
    internal class Savings:BankAccount
    {
        // data members
        private double interest;

        // overloading constructor
        public Savings(int routingNumber, double balance, string accountUserName, double interest):base(routingNumber,balance,accountUserName)
        {
            this.routingNumber = routingNumber;
            this.balance = balance;
            this.accountUserName = accountUserName;
            this.interest = interest;
        }
        // Interest Property
        public double Interest
        { 
            get { return interest; } 
            set { interest = value; }
        }
        public double interestAmount()
        {
            return (interest / 100) * balance;
        }
        // print string
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nInterest Rate: {interest}%\nInterest Amount: ${interestAmount()}");
        }
        // destructor
        ~Savings() { }
    }
}
