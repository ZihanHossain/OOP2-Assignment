using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation

        public Account(string accountName,double balance,Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void ShowAccountInformation()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}",this.accountNumber,this.accountName,this.balance);
            this.address.PrintAddress();
        }

        public void Withdraw(double amount)
        {
            if(amount > this.balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                this.balance = this.balance - amount;
                Console.WriteLine("Withdrwa Successful");
                Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            }
        }

        public void Deposit(double amount)
        {
            this.balance = this.balance + amount;
            Console.WriteLine("Deposit Successful");
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
        }

        public void Transfer( Account account,double amount)
        {
            Withdraw(amount);
            account.Deposit(amount);
        }
    }
}
