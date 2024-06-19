using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year, month, date: 'year, month, date'");
            DateTime userBirth = Convert.ToDateTime(Console.ReadLine());

            DateTime now = DateTime.Now;
            DateTime birthThisYear = new DateTime(now.Year, userBirth.Month, userBirth.Day, 0, 0, 0);

            TimeSpan wait;
            if (birthThisYear < now)
            {
                birthThisYear = new DateTime(now.Year + 1, userBirth.Month, userBirth.Day, 0, 0, 0);
                wait = birthThisYear - now;
            }
            else
            {
                wait = birthThisYear - now;
            }

            TimeSpan userLive = now - userBirth;

            Console.WriteLine();

            Console.WriteLine($"User's birthday: {userBirth}");
            Console.WriteLine($"Time:            {now}");

            Console.WriteLine();
            
            Console.WriteLine($"'{wait.Days}' days left until your birthday");
            Console.WriteLine($"'{userLive.Days}' days you live");

            Console.ReadKey();
        }
    }
}
