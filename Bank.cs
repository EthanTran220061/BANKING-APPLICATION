﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_APPLICATION
{
    class Bank
    {

        //List
        private List<Account> accounts;

        //make sequential account number
        private static int nextAccountNumber = 1000;


        /// <summary>
        /// Create bank object
        /// </summary>
        public Bank()
        {
            accounts = new List<Account>();

        }

        /// <summary>
        /// Add Account
        /// </summary>
        /// <param name="account"></param>
        public void AddAccount(Account account)
        {
            this.accounts.Add(account);

        }

        /// <summary>
        /// Get the next account number
        /// </summary>
        /// <returns></returns>
        public static int NextAccountNumber()
        {
            nextAccountNumber += 1;

            return nextAccountNumber; // ++nextAccountNumber


        
        }

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public Account GetAccount(int accountNumber)
        {
            foreach(Account account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }

        /// <summary>
        /// Deposit amount 
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Deposit(int accountNumber, double amount)
        { 
            Account account = GetAccount(accountNumber);

            if (account != null)
            { 
                return account.Deposit(amount);
            }

            return false;
        }

        /// <summary>
        /// Withdraw an amount
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Withdraw(int accountNumber, double amount)
        {
            Account account = GetAccount(accountNumber);

            if (account != null)
            {
                return account.Withdraw(amount);
            }

            return false;
        }

        public bool Transfer(int fromAccountNumber, int toAccountNumber, double amount)
        { 
            Account fromAccount = GetAccount(fromAccountNumber);
            Account toAccount = GetAccount(toAccountNumber);

            if (fromAccount != null && toAccount != null)
            { 
            
            
            }
            return false;
        }
    }
}
