using MyBankConsoleApp.MyBank.Core.Models;
using MyBankConsoleApp.MyBank.Data.Respositories;
using MyBankConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankConsoleApp.Menus
{
    public static class AccountMenu
    {
       
        public  static User user;
        public static  Account account;

        //AccountMenu (User user, Account account)
        //{
        //   user = user;
        //   account = account;
        //}

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Account Menu");
            Console.WriteLine("============");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Print Statement");
            Console.WriteLine("6. Logout");
            Console.WriteLine("Enter your choice: ");

            string accountChoice = Console.ReadLine();

            Console.Clear();

            switch (accountChoice)
            {
                case "1":
                    decimal balance = Account.Balance;
                    Console.WriteLine($"Account Balance: {balance:C}");
                    break;
                case "2":
                    Console.Write("Enter the amount to withdraw: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    if (withdrawAmount > 0 && withdrawAmount <= Account.Balance)
                    {
                        Account.Balance -= withdrawAmount;
                        Console.WriteLine("Withdrawal successful!");
                    }
                    else
                    {
                        Console.WriteLine("Withdrawal failed. Insufficient balance or invalid amount.");
                    }
                    break;
                case "3":
                    Console.Write("Enter the amount to deposit: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    //Account.Deposit(depositAmount);
                    if (depositAmount > 0)
                    {
                        Account.Balance += depositAmount;
                        Console.WriteLine("Deposit successful!");
                    }
                    else
                    {
                        Console.WriteLine("Deposit failed. Invalid amount.");
                    }
                    break;
                case "4":
                        Console.Write("Enter the recipient's account number: ");
                        string recipientAccountNumber = Console.ReadLine();
                            
                        Console.Write("Enter the amount to transfer: ");
                        decimal transferAmount = decimal.Parse(Console.ReadLine());

                        if (transferAmount > 0 && transferAmount <= Account.Balance)
                        {
                            Account.Balance -= transferAmount;
                         //   recipientAccount.Balance += transferAmount;
                            Console.WriteLine("Transfer successful!");
                        }
                        else
                        {
                            Console.WriteLine("Transfer failed. Insufficient balance or invalid amount.");
                        }
                   
                    break;
                case "5":
                    Console.WriteLine("Logging out....");
                    BankService.Login();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            ShowMenu();
        }




        /*public static void Transfer(long fromAccountNumber, long toAccountNumber, decimal amount) // Change the parameter types to long
        {
            // Get the accounts involved in the transfer
            Account fromAccount = GetAccount(fromAccountNumber);
            Account toAccount = GetAccount(toAccountNumber);

            // Withdraw the amount from the sender's account
            fromAccount.Withdraw(amount);

            // Deposit the amount into the recipient's account
            toAccount.Deposit(amount);
        }

        // Method to print all accounts in the bank
        public static void PrintAccounts()
        {
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
            Console.WriteLine("| FULL NAME     | ACCOUNT NUMBER   | ACCOUNT TYPE | ACCOUNT BAL | NOTE   |");
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
            Account acccount = new Account();
            foreach (var account in Account)
            {
                Console.WriteLine($"| {account.FirstName} {account.LastName,-9} | {account.AccountNumber,-16} | {account.AccountType,-13} | {account.Balance,-11} | {account.Note,-6} |");
            }

            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
        }*/
    }

}
