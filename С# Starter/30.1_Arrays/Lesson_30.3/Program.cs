using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_30._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string nameMonth;
            {
                Console.WriteLine("Enter the name of the month:");
                nameMonth = Console.ReadLine();
            }

            int index = 0;

            while (index < months.Length)
            {
                if (nameMonth == months[index])
                {
                    index++;
                    Console.WriteLine("Enter the name of the month:");
                    nameMonth = Console.ReadLine();
                }
                else if (index == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the name of the month:");
                    nameMonth = Console.ReadLine();
                }
            }

            Console.ReadKey();

        }
    }
}
