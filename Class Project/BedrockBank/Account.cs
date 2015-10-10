using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public enum TypeOfAccount
    {
        Checking,
        Savings
    }
    /// <summary>
    /// This defines the Account
    /// Allows the user to deposit and
    /// Withdraw
    /// </summary>
    public class Account
    {
        #region Variables
        private static int lastAccountNumber = 0;
        private double balance = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Account number of the account
        /// </summary>
       
        [Key]
        public int AccountNumber { get; private set; }

        public string Name { get; set; }
        public int SSN { get; set; }
        public double Balance {
            get
            {
                return balance;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Not sufficient fund!!");
                }
                balance = value;
            }
        }

        public string Statement { get; set; }

        public TypeOfAccount AccountType { get; set; }
        #endregion

        #region Constructor

        static Account()
        {

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Account()
        {
            //AccountNumber = lastAccountNumber + 1;
            //lastAccountNumber = AccountNumber;

            //Alternatively
            AccountNumber = ++lastAccountNumber;
        }

        public Account(string name)
        {
            AccountNumber = ++lastAccountNumber;
            Name = name;
        }

        #endregion

        #region Methods

        public void Deposit(double amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return false;
            }
            Balance -= amount;
            return true;
        }
        #endregion
    }
}
