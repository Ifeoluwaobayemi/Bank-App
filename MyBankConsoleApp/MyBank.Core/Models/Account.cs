using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBankConsoleApp.MyBank.Core.Models
{
    public class Account
    {
        public static string AccountNumber { get; set; }

        public static BankAccountType AccountType { get; set; }
        public static  decimal Balance { get; set; }
        public static List<Transactions> Transactions { get; set; }

    }


    public enum BankAccountType
    {
        Savings,
        Current
    }

}
