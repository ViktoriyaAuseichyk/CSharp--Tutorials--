using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToString(year).Length != 4)
            {
                Console.WriteLine("The year is incorrect. Enter the year again.");
                year = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the sequence number of the month:");
            int sequenceNumber = Convert.ToInt32(Console.ReadLine());

            if (sequenceNumber < 0 &&  sequenceNumber > 12) 
            {
                Console.WriteLine("The sequence number is incorrect. Enter the sequence number again.");
                sequenceNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of days in the month:");
            int daysInMonth = Convert.ToInt32(Console.ReadLine());

            if (daysInMonth < 28 && daysInMonth > 31)
            {
                Console.WriteLine("The number of days in the month is incorrect. Enter the number of days in the month.");
                daysInMonth = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            Calendar calendar = new Calendar(year, sequenceNumber, daysInMonth);

            calendar.GetMonthBySequenceNumber();

            Console.WriteLine();

            IEnumerable<string> getMonthsByNumberOfDaysInMonth = calendar.GetMonthsByNumberOfDaysInMonth();

            foreach (var item in getMonthsByNumberOfDaysInMonth) 
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
