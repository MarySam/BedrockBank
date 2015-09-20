using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class BankFactory
    {
        #region Private
        private static List<Account> accounts = new List<Account>();
        #endregion

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
            using (var db = new BankModel())
            {
                Account account = new Account(name);
                account.SSN = ssn;
                account.AccountType = TypeOfAccount.Checking;
                if (balance > 0)
                {
                    account.Deposit(balance);
                }
                accounts.Add(account);
                db.Accounts.Add(account);
                db.SaveChanges();
                return account;
            }

        }

        public static void CreateStatements()
        {
            //for (int i = 0; i < accounts.Count; i++)
            //{
            //    var account = accounts[i];
            //    account.Statement = string.Format("Starting balance: {0:c}, Ending balance: {0:c}", account.Balance);
            //}
            foreach (var account in accounts)
            {
                account.Statement = string.Format("Starting balance: {0:c}, Ending balance: {0:c}", account.Balance);
            }
        }
    }
}
