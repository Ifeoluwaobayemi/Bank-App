using MyBankConsoleApp.MyBank.Core.Models;
using MyBankConsoleApp.MyBank.Data.Respositories;
using MyBankConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyBankConsoleApp.Menus
{
    public static class AccountMenu 
    {
       
        public  static User user;
        public static  Account account;


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
                        
                            Console.WriteLine("Transfer successful!");
                        }
                        else
                        {
                            Console.WriteLine("Transfer failed. Insufficient balance or invalid amount.");
                        }
                   
                    break;
                case "5":
                    Console.WriteLine("print statement");
                    PrintAccounts();
                    break;

                case "6":
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


        // Method to print all accounts in the bank

          public class BankAccountTransactions
         {
            public string FullName { get; set; }
            public  int AccountNumber { get; set; }

            public string AccountType { get; set; }

            public int Balance { get; set; }

            public string Note { get; set; }


            public  BankAccountTransactions(string fullName, int accountNumber, string accountType, int balance, string note)
            {

                FullName = fullName;
                AccountNumber = accountNumber;
                AccountType = accountType;
                Balance = balance;
                Note = note;

            }

          }






        public static void PrintAccounts()
        {
            Console.WriteLine("write your fullName");
           string? fullName = Console.ReadLine();
           
            Console.WriteLine("write your Account Number");
            int accountNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("write your Account Type");
            string? accountType = Console.ReadLine();
            
            Console.WriteLine(" Acount Balance?");
            int balance = int.Parse(Console.ReadLine());
            
            Console.WriteLine("write a note");
            string? note = Console.ReadLine();

            BankAccountTransactions banktrans = new(fullName, accountNumber, accountType, balance , note);
            
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
            Console.WriteLine("| FULL NAME     | ACCOUNT NUMBER   | ACCOUNT TYPE | ACCOUNT BAL | NOTE   |");
            Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
          
             Console.WriteLine($"| {banktrans.FullName,-12} | {banktrans.AccountNumber ,-19} | {banktrans.AccountType,-17} | {banktrans.Balance,-14} | {banktrans.Note,-10} |");
            

           Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
        }

    }

}
