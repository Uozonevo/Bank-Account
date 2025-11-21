using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Homework_11_2
{
    internal class Checking:BankAccount
    {
        // data members
        private double overDraft;

        // overloading constructor
        public Checking(int routingNumber, double balance, string accountUserName, double overdue) :base(routingNumber, balance, accountUserName) 
        {
            this.routingNumber = routingNumber;
            this.balance = balance;
            this.accountUserName = accountUserName;
            this.overDraft = overdue;
        }
        // OverDraft property
        public double OverDraft 
        {
            get { return overDraft; }
            set { overDraft = value; }
        }
        // print string
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nOverdraft amount in Checking: $-{overDraft}");
        }
        // destructor
        ~Checking() { }

    }
}
