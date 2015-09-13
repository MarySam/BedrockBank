using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //LHS = definition
            //RHS = instantiation (memory is allocated)
            //Account myAccount = new Account();
            //myAccount.Name = "Kal";
            //Account myAccount = new Account("Kal");
            Account myAccount = BankFactory.CreateAccount("Kal", 123123, 0);
            Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}",
                myAccount.AccountNumber, myAccount.Name, myAccount.Balance);

            Account myAccount2 = BankFactory.CreateAccount("Kal2", 123123, 500);
            Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}",
                myAccount2.AccountNumber, myAccount2.Name, myAccount2.Balance);
            //myAccount.AccountNumber = 10;
            //Console.WriteLine(myAccount.Balance);

            BankFactory.CreateStatements();
        }
    }
}
