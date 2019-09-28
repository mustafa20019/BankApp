using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace BankApp
{
    /// <summary> triple slash
    /// This is a bank account
    /// where a user can deposit 
    /// and withdarw money from it
    /// </summary>
    class Account
    {
        private static int lastAccountNumber = 0;

      

        #region Properties
        /// <summary>
        /// Email Address of the account
        /// </summary>
        public string EmailAddress { get; set; } 

        /// <summary>
        /// Autogenerate Account number 
        /// for the account
        /// </summary>
        public int AccountNumber { get; } //set; } 

        /// <summary>
        /// This sets the account type
        /// </summary>
        public string AccountType { get; set; } 

        /// <summary>
        /// This checks the account balance
        /// </summary>
        public decimal Balance { get; private set; } 

        /// <summary>
        /// This checks the created date of the bank account
        /// </summary>
        public DateTime CreatedDate { get; private set; }
        #endregion//this is good t0 keep the code clean

        #region Constructor
        public Account()
        {
            
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        #endregion
    }
}

