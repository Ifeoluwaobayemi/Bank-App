using MyBankConsoleApp.Menus;
using MyBankConsoleApp.MyBank.Core.Models;
using MyBankConsoleApp.MyBank.Data.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBankConsoleApp.MyBank.Core.Models.Account;

namespace MyBankConsoleApp.Services
{
    public static class BankService
    {
        //private UserRepository userRepository;

        //public  BankService()
        //{
        //    userRepository = new UserRepository();
        //}


        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("\t\tHi There, Welcome to My Bank!");
            Console.WriteLine("\nPress any key to continue....");
            Console.ReadKey();
        }

        public static void CreateAccount()
        {
        
            Console.WriteLine("Create New Account");
            Console.WriteLine("==================");

            Console.Write("Enter your Firstname: ");
            string? firstname = Console.ReadLine();
            
            Console.WriteLine("Enter your Lastname: ");
            string? lastname = Console.ReadLine();

            Console.WriteLine("Enter your Email Address: ");
            string? email = Console.ReadLine();

            Console.Write("Enter your preferred password: ");
            string? password = Password.HidePassword();
            User newUser = new(firstname,lastname, email, password);

            Console.Clear();
            Console.WriteLine("Select account type");
            Console.WriteLine("1. Savings");
            Console.WriteLine("2. Current");
            Console.Write("Enter your choice:  ");
            string accountTypeChoice = Console.ReadLine();
           

            //Input validation
            if (accountTypeChoice != "1" && accountTypeChoice != "2")
            {
                Console.WriteLine("Invalid account type choice. Savings account created by default.");
                accountTypeChoice = "1";
            }

            BankAccountType accountType;

            switch (accountTypeChoice)
            {
                case "1":
                    accountType = BankAccountType.Savings;
                    string savingsAccNo = "1456789023";
                    Console.WriteLine($"Congratulations, {firstname} {lastname}! Your account number is {savingsAccNo} and password is {password}. Keep it safe");
                    break;
                case "2":
                    break;
                default:
                    accountType = BankAccountType.Current;
                    string currentAccNo = "1021314156";
                    Console.WriteLine($"Congratulations, {firstname} {lastname}! Your account number is {currentAccNo} and password is {password}. Keep it safe");
                    Console.WriteLine("Invalid account type choice. Default Savings account created.");
                    accountType = BankAccountType.Savings;
                    break;
            }

    
            Console.WriteLine("Account Created Successfully!");
            Console.WriteLine("=============================");
        }

        public static void Login()
        {
            Console.WriteLine("Login");
            Console.WriteLine("=====");

            Console.WriteLine("Enter your email address: ");
            string Email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Password.HidePassword();
            

            //Input validation

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Invalid username or password. Login failed!");
                Console.WriteLine("==========================================");
               
            }

            //if (userRepository != null)
            //{
                
            //   Console.WriteLine("Login Successful!");
            //  Console.WriteLine("=================");
            //   return true;
            //}
            else
            {
                AccountMenu.ShowMenu();
            }
        }

        public static void Deposit()
        {

        }
       /*public static void CheckBalance()
        {
            User currentUser = userRepository.GetCurrentUser();
            Account currentAccount = currentUser.Accounts[0];

            Console.WriteLine("Account Balance: " + currentAccount.Balance);
        }

        public void Withdraw(decimal withdrawAmount)
        {
            User currentUser = userRepository.GetCurrentUser();
            Account currentAccount = currentUser.Accounts[0];

            if (withdrawAmount > currentAccount.Balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed!");
            }
            else
            {
                currentAccount.Balance -= withdrawAmount;
                Console.WriteLine("Withdrawal Successful!");
            }
        }

        public void Transfer(string recipientAccountNumber, decimal transferAmount)
        {
           // User currentUser = userRepository.GetCurrentUser();
            Account currentAccount = currentUser.Accounts[0];

            // Here, you would need to implement the logic to find the recipient's account and perform the transfer

            Console.WriteLine("Transfer Successful!");
        }

        public void AccountStatement()
        {
            User currentUser = userRepository.GetCurrentUser();
            Account currentAccount = currentUser.Accounts[0];

            Console.WriteLine("Account Statement");
            Console.WriteLine("================");
            Console.WriteLine("User: " + currentUser.FirstName);
            Console.WriteLine("Account Number: " + currentAccount.AccountNumber);
            Console.WriteLine("Account Type: " + currentAccount.AccountType);
            Console.WriteLine("Account Balance: " + currentAccount.Balance);
            Console.WriteLine("Note: ");
        }*/
    }
}
