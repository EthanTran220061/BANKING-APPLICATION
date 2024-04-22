using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_APPLICATION
{
    abstract class Account
    {
        private int accountNumber;
        protected double balance;
        /// <summary>
        /// Constructor with account number
        /// </summary>
        /// <param name="accountNumber"></param>
        
        public Account(int accountNumber)
        {
            this.accountNumber = accountNumber;
            balance = 0;
        }

        /// <summary>
        /// Constructor with account number and initial balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="initBalance"></param>
        public Account(int accountNumber, double initBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initBalance;
        
        }

        /// <summary>
        /// Read only property
        /// </summary>
        public double Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// Read only properly for account number
        /// </summary>
        public int AccountNumber
        {
            get { return accountNumber; }
        
        }

        public abstract 

            //17:21 video
    }
}
