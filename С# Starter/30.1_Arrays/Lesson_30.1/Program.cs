using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_30._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int index = 0; index < months.Length; index++)
            {
                Console.WriteLine($"{months[index]}");
            }

            Console.ReadKey();
        }
    }
}
