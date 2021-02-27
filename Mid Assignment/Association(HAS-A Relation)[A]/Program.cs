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
            //Address address1 = new Address(4,10,"Dhaka");
            //Account account1 = new Account(1001, "Shakib", 2000, address1);
            //account1.PrintAccount();

            //Account account2 = new Account(1002,"Tamim",3000,new Address(7,20,"Chittagong"));
            //account2.PrintAccount();

            Bank ourBank = new Bank("Developer's bank", 5);
            ourBank.AddAccount(new Account("Shakib", 2000, new Address(4, 10, "Dhaka" , "Bangladesh")));
            ourBank.AddAccount(new Account("Mushfiq", 5000, new Address(4, 10, "Sylhet" , "Bangladesh")));
            ourBank.AddAccount(new Account("Tamim", 3000, new Address(7, 20, "Chittagong" , "Bangladesh")));
            //ourBank.PrintAllAccounts();
            //ourBank.SearchAccount(300);
            ourBank.DeleteAccout(3003);
            ourBank.PrintAllAccounts();
        }
    }
}
