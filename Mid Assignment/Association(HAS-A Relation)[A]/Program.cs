using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "";
            //Bank ourBank = new Bank("Developer's bank", 5);
            //ourBank.AddAccount(new Account("Shakib", 2000, new Address(4, 10, "Dhaka" , "Bangladesh")));
            //ourBank.AddAccount(new Account("Mushfiq", 5000, new Address(4, 10, "Sylhet" , "Bangladesh")));
            //ourBank.AddAccount(new Account("Tamim", 3000, new Address(7, 20, "Chittagong" , "Bangladesh")));
            //ourBank.PrintAllAccounts();
            //ourBank.SearchAccount(300);
            //ourBank.PrintAllAccounts();
            //ourBank.Transaction(3,1,2,500);
            Bank ourBank = new Bank("Developer's bank", 5);
            void OpenAccount()
            {
                Console.WriteLine("Enter your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your date of birth: ");
                string dateOfBrith = Console.ReadLine();
                Console.WriteLine("Address:");
                Console.WriteLine("House number: ");
                int houseNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Road Number: ");
                int roadNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Country: ");
                string country = Console.ReadLine();
                Console.WriteLine("Account: ");
                Console.WriteLine("Initial Balance: ");
                int balance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 'saving': For making a saving account.");
                Console.WriteLine("Enter 'checking': For making a checking account.");
                Console.WriteLine("Enter 'quit': For exiting the program.");
                string accountType = Console.ReadLine();
                switch(accountType)
                {
                    case "saving":
                        ourBank.AddAccount(new Account(name ,accountType ,balance, new Address(houseNumber, roadNumber, city, country)));
                        break;
                }
                //ourBank.AddAccount(new Account(name, balance, new Address(houseNumber, roadNumber, city, country)));
            }
            void Account()
            {
                int amount;
                Console.WriteLine("Your Account Number: ");
                int accountNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 'deposit': For making a deposit.");
                Console.WriteLine("Enter 'withdraw': For making a withdrawal.");
                Console.WriteLine("Enter 'transfer': For making a transfer.");
                Console.WriteLine("Enter 'show': Show the number transaction and balance");
                Console.WriteLine("Enter 'quit': For exiting the program.");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "deposit":
                        Console.WriteLine("Amount you want to deposit: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        ourBank.Transaction(2, accountNumber, 0, amount);
                        break;
                    case "withdraw":
                        Console.WriteLine("Amount you want to withdraw: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        ourBank.Transaction(1, accountNumber, 0, amount);
                        break;
                    case "transfer":
                        Console.WriteLine("Amount you want to transfer: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Account number of the recever: ");
                        int accountNumber1 = Convert.ToInt32(Console.ReadLine());
                        ourBank.Transaction(3, accountNumber, accountNumber1, amount);
                        break;
                    case "show":
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valide input");
                        break;

                }
            }
            while(flag != "exit")
            {
                string input = "";
                Console.WriteLine("Enter 'open': For opening an account.");
                Console.WriteLine("Enter 'account': To perform transactions an account.");
                Console.WriteLine("Enter 'quit': For exiting the application.");
                input = Console.ReadLine();
                switch(input)
                {
                    case "open":
                        OpenAccount();
                        break;
                    case "account":
                        Account();
                        break;
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("Please enter a valide input");
                        break;
                }
            }
        }
    }
}
