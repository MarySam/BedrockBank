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
            BankAccount myAccount = new BankAccount();
            //Set of the property is called
            myAccount.Name = "Mary";
            myAccount.Deposit(150.25);

            //Get of the property is called
            Console.WriteLine("Account number: {0}, Name: {1}, Balance: {2:c}",
                myAccount.AccountNumber, myAccount.Name, myAccount.Balance);

            BankAccount savingsAccount = new BankAccount();
            savingsAccount.Name = "Mary 2";
            savingsAccount.Deposit(200);

            //Get of the property is called
            Console.WriteLine("Account number: {0}, Name: {1}, Balance: {2:c}",
                savingsAccount.AccountNumber, savingsAccount.Name, savingsAccount.Balance);

        }
    }
}
