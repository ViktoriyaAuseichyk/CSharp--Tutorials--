using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string patternForLogin = @"^[a-z]+$";
            const string patternForPassword = @"\w";

            var loginRegex = new Regex(patternForLogin);
            var passwordRegex = new Regex(patternForPassword);

            while (true)
            {
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                if (loginRegex.IsMatch(login) && passwordRegex.IsMatch(password))
                {
                    Console.WriteLine("Login and Password are saved...");
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Login or Password doesn't match the pattern...Please, try again.");
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
