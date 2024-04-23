using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_APPLICATION
{
    class CheckingAccount : Account
    {
        // Add the transaction fee on withdrawal
        private const double FEE = 1.75;

        //private int accountNumber;
        //protected double balance;
        /// <summary>
        /// Constructor with account number
        /// </summary>
        /// <param name="accountNumber"></param>

        public CheckingAccount(int accountNumber)
            : base(accountNumber)
        {

        }

        /// <summary>
        /// Constructor with account number and initial balance
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="initBalance"></param>
        public CheckingAccount(int accountNumber, double initBalance)
            : base(accountNumber, initBalance)
        {


        }

        /// <summary>
        /// Method to deposit an amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Deposit(double amount)
        {
            // check positive
            if( amount < 0) 
            {
               
                return false;
            }
            else 
            {
                balance += amount;

            
            }
            return true;
        }

        /// <summary>
        /// Method to withdraw funds
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Withdraw(double amount)
            {   
                if (amount > 0) 
                {
                    // sufficient balance
                    if ((amount + FEE) <= balance)
                    {
                        balance -= (amount + FEE);
                        return true;
                    }
            
                }
            return false;
            }

        /// <summary>
        /// Function to transfer funds
        /// </summary>
        /// <param name="toAccount"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
     public override bool Transfer(Account toAccount, double amount)
        { 
            // first check amount +ve
            // balance is sufficient
            if(Withdraw(amount))
            {
                toAccount.Deposit(amount);
                return true;

            }
            return false;
        }
    }
}
