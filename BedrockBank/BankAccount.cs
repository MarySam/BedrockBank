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
        #region properties
        /// <summary>
        /// Account Balance
        /// </summary>
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int AccountNumber { get; set; }
        public AccountType TypeOfBankAccount { get; set; }
        #endregion

        #region Enum
        public enum AccountType
        { Checking,
        Savings,
        CD}
        #endregion
    }
}
