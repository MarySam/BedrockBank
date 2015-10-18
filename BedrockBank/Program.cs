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
            bool success = false;
            short attempts = 1;
            Console.WriteLine("*************Welcome to Bedrock Bank**********");
            try
            {
                while (!success && attempts++ < 4)
                {
                    Console.Write("Please enter your ssn(without the dashes): ");
                    //Get string ssn
                    var ssn = Console.ReadLine();
                    int convertedSSN;
                    //Converting the SSN into an integer
                    if (int.TryParse(ssn, out convertedSSN) == true)
                    {
                        //if conversion is successful, get the accounts for ssn
                        var accounts = BankFactory.GetAllAccountsBySSN(convertedSSN);
                        for (int i = 0; i < accounts.Length; i++)
                        {
                            //enumerate through the list of accounts
                            if (!success)
                            {
                                //Mark it as a successful attempt
                                success = true;
                            }
                            //print a meaningful index to the user
                            Console.WriteLine("{0}. Name: {1}", i + 1, accounts[i].Name);
                        }
                        if (success)
                        {
                            //Let's ask the user for the account to pull up the details
                            Console.WriteLine("Type 0 to exit");
                            while (true)
                            {
                                Console.Write("Please select an account number: ");
                                var accountIndex = Console.ReadLine();
                                int convertedAccountIndex;
                                if (int.TryParse(accountIndex, out convertedAccountIndex) == true)
                                {
                                    if (convertedAccountIndex == 0)
                                        break;
                                    else if (convertedAccountIndex < 0 || convertedAccountIndex > accounts.Length)
                                        continue;
                                    var account = accounts[convertedAccountIndex - 1];
                                    Console.WriteLine("Account number: {0}, Name: {1}, Balance: {2:c}",
                                        account.AccountNumber, account.Name, account.Balance);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Sorry, system is down. Please try again later.");
            }

        }
    }
}



//How to populate a table in the database
/*Account myAccount = BankFactory.CreateAccount("Mary1", 123123, 0);
Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}",
myAccount.AccountNumber, myAccount.Name, myAccount.Balance);

Account myAccount2 = BankFactory.CreateAccount("Mary2", 123123, 500);
Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}",
myAccount2.AccountNumber, myAccount2.Name, myAccount2.Balance);
//myAccount.AccountNumber = 10;
//Console.WriteLine(myAccount.Balance);

BankFactory.CreateStatements();

Console.ReadLine();*/




