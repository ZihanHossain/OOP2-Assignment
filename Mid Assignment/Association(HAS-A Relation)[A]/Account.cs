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
        private string dateOfBirth;
        private string accountType;
        public int withdraw, deposit, transfer = 0;

        public Account(string accountName,string accountType ,double balance,Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            this.accountType = accountType;
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

        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }


        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void ShowAccountInformation()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine();
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nDate of Birth:{2}\nBalance:{3}\nWithdrawn:{4} times\nDeposited:{5} times\nTransferd:{6} times", this.accountNumber,this.accountName,this.dateOfBirth,this.balance,this.withdraw,this.deposit,this.transfer);
            Console.WriteLine();
            this.address.PrintAddress();
        }

        public void Withdraw(double amount)
        {
            if(amount > this.balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else if((this.balance - balance) == 0 & this.accountType == "saving")
            {
                Console.WriteLine("Remaining balance cannot be zero in a saving account.");
            }
            else
            {
                this.balance = this.balance - amount;
                this.withdraw++;
                Console.WriteLine("Withdrwa Successful");
                Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            }
        }

        public void Deposit(double amount)
        {
            this.balance = this.balance + amount;
            this.deposit++;
            Console.WriteLine("Deposit Successful");
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
        }

        public void Transfer( Account account,double amount)
        {
            Withdraw(amount);
            account.Deposit(amount);
            this.transfer++;
        }
    }
}
