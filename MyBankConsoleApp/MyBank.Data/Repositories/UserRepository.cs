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
      

        public void AddUser(User user)
        {
            users.Add(user);
        }

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

    }
}
