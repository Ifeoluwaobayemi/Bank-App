using MyBankConsoleApp.MyBank.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static MyBankConsoleApp.MyBank.Core.Models.Account;

namespace MyBankConsoleApp
{
    public  class Transactions
    {   
       
        // Method to deposit money into the account
        public static void Deposit(decimal amount)
        {
          Account.Balance += amount;

        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            // Check if the account is a savings account and if the withdrawal will result in a balance less than 1000
            if (Account.AccountType == BankAccountType.Savings && Account.Balance - amount < 1000m)
            {
                // Throw an exception with a message if there are insufficient funds
                throw new Exception("Insufficient funds");
            }

            // Subtract the amount from the balance
            Balance -= amount;
        }

        // Method to transfer money from the current account to another account
        public void Transfer(decimal amount, Account otherAccount)
        {
            // Withdraw the amount from the current account
            Withdraw(amount);

            // Deposit the amount into the other account
            Transactions.Deposit(amount);
        }

        // Override ToString() method to provide a string representation of the account
        public override string ToString()
        {
            return $"Account {AccountNumber}: {User.FirstName} {User.LastName} ({Account.AccountType}) - Balance: {Account.Balance}";
        }
    }
}

