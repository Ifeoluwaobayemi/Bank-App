using MyBankConsoleApp.Menus;
using MyBankConsoleApp.MyBank.Core.Models;
using MyBankConsoleApp.Services;
using System;
using System.Security.Principal;

namespace MyBank.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            BankService.DisplayWelcomeMessage();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Menu");
                Console.WriteLine("====");
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Login");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        BankService.CreateAccount();
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        AccountMenu.ShowMenu();
                        break;
                    case "2":
                        BankService.Login();
                        
                            Console.WriteLine("Logged in successfully!");
                            Console.WriteLine("=======================");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            AccountMenu.ShowMenu();
                        
                      
                        break;
                }
            }
        }
    }
}
