using MyBankConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBankConsoleApp.MyBank.Core.Models
{
    public  class User
    {
        public static string FirstName { get; set; }
        
        public static string LastName{ get; set; }
            
    
        public static  string Email { get; set; }
   
        public static  string Password { get; set; }
        public static  List<Account> Accounts { get; set; }



       public User(string firstname, string lastname, string email, string password) 
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email; 
            Password = password;
        }
        

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
        /*public void SanitizeName()
        {
            //Check if the name starts with a digit or lowercase letter
            if (char.IsDigit(Firstname[0]) || char.IsLower(Lastname[0]))
            {
                Firstname = char.ToUpper(Firstname[0]) + Firstname.Substring(1);    
            }
            if (char.IsDigit(Lastname[0]) && char.IsLower(Lastname[0]))
            {
                Lastname = char.ToUpper(Lastname[0]) + Lastname.Substring(1);
            }
        }*/
    }
}
