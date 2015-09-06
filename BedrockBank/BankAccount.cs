using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{

    /// <summary>
    /// BankAccountTraining
    /// </summary>
    class BankAccount
    {
        #region Variables
        static int lastAccountNumber = 0;
        #endregion

        #region properties
        /// <summary>
        /// Account Balance
        /// </summary>
        public double Balance { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int AccountNumber { get; private set; }
        public AccountType TypeOfBankAccount { get; set; }
        #endregion

        #region Enum
        public enum AccountType
        { Checking,
        Savings,
        CD}
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        #region Constructors
        public BankAccount()
        {
            lastAccountNumber = lastAccountNumber + 1;
            AccountNumber = lastAccountNumber;

           // (short hand way to write) AccountNumber = ++lastAccountNumber;

        }

        #endregion


        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns>New balance</returns>

        public double Deposit(double amount)
        {
            Balance = Balance + amount;
            // (shortcut) Balance += amount; 
            return Balance; 
         
        }
        public double Withdraw(double amount)
        {
            if(amount>Balance)
            {
                throw new ArgumentOutOfRangeException("Not sufficient funds in the account");
            }

            Balance = Balance - amount;
            return Balance;
        }
        #endregion

    }
}
