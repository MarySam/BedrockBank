using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class BankFactory
    {
        public static string Name { get; set; }
        public static string Address { get; set; }
        /// <summary>
        /// Creates a bank account
        /// </summary>
        /// <param name="name">Name of the account holder</param>
        /// <param name="ssn">ssn</param>
        /// <param name="balance">initial balance to be deposited</param>
        /// <returns>Account number</returns>
        public static  Account CreateAccount(string name, int ssn, double balance)
        {
            Account account = new Account(name);
            account.SSN = ssn;
            if(balance > 0)
            {
                account.Deposit(balance);
            }
            return account;
        }
    }
}
