using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Bank
    {
        private string name;
        private Account[] accounts;//1-* Relation
        public Bank(string name,int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAccountDetails()
        {
            for(int i=0;i<accounts.Length;i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].ShowAccountInformation();
            }
        }

        public void AddAccount(Account account)
        {
            for (int i = 1; i <= accounts.Length; i++)
            {
                if(accounts[i]==null)
                {
                    account.AccountNumber = i;
                    accounts[i] = account;
                    accounts[i].ShowAccountInformation();
                    break;
                }
            }
        }

        public dynamic SearchAccount(int accountNo)
        {
            dynamic flag = null;
            for (int i = 0; i < accounts.Length; i++)
            {
                if(accounts[i] == null)
                {
                    continue;
                }
                if (accounts[i].AccountNumber == accountNo)
                {
                    return accounts[i];
                }
            }
            return flag;    
        }

        public void DeleteAccout(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    flag = 0;
                    for (int j = i; j < (accounts.Length)-1; j++)
                    {
                        accounts[j] = accounts[j+1];

                        if (j == (accounts.Length)-2)
                        {
                         accounts[j] = null;
                        }
                    }
                }
                else
                {
                    flag = 1;
                }
            }
            if(flag==1)
                Console.WriteLine("account not found");
        }

        public void Transaction(int type, int accountNumber, int accountNumber1, int amount)
        {
            if(type == 1)
            {
               if (SearchAccount(accountNumber) != null)
                {
                    SearchAccount(accountNumber).Withdraw(amount);
                }
               else
                {
                    Console.WriteLine("Account Not Found");
                }
            }
            else if(type == 2)
            {
                if (SearchAccount(accountNumber) != null)
                {
                    SearchAccount(accountNumber).Deposit(amount);
                }
                else
                {
                    Console.WriteLine("Account Not Found");
                }
            }
            else if(type == 3)
            {
                if (SearchAccount(accountNumber) != null & SearchAccount(accountNumber1) != null)
                {
                    dynamic recever = SearchAccount(accountNumber1);
                    SearchAccount(accountNumber).Transfer(recever,amount);
                }
                else
                {
                    Console.WriteLine("Account Not Found");
                }
            }
        }
    }
}
