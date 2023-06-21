using MyBankConsoleApp.MyBank.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankConsoleApp.MyBank.Data.Respositories
{
    public class UserRepository
    {
        private List<User> users;
       
        private User currentUser;
        private  static List<Account> accounts = new();
      

        //      public UserRepository()
        //   {
        //     users = new List<User>();
        //   currentUser = null;
        //}

        public void AddUser(User user)
        {
            users.Add(user);
        }

     //   public User GetUserByUsernameAndPassword(string firstname, string password)
      //  {
        //    return users.FirstOrDefault(u =>  == firstname && u.Password == password);
            
        //}

        public User GetCurrentUser()
        {
            return currentUser;
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        internal static Account GetAccountByAccountNumber(string? recipientAccountNumber)
        {
            throw new NotImplementedException();
        }


        //public static  Account GetAccount(long accountNumber)
        //{

             
        //    // Iterate over the accounts and find the one with the specified account number


            
        //    foreach (var account in accounts)
        //    {
        //        if (account == accountNumber)
        //        {
        //            return account;
        //        }
        //    }

        //    // Account not found, return null or throw an exception based on your requirements
        //    return null;
        //}


    }
}
