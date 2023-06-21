using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankConsoleApp
{
    public static class Password
    {
        public static string HidePassword() 
        {
            string? password = "";
            ConsoleKeyInfo keyInput;

            do
            {
                keyInput = Console.ReadKey(true);
                if (keyInput.Key != ConsoleKey.Enter)
                {
                    password += keyInput.KeyChar;
                    Console.Write("*");
                }
            }
            while (keyInput.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return password;

        }

    }
}
