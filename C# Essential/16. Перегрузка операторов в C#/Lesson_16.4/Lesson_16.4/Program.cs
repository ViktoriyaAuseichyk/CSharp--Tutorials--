using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date_1 = new Date(15, 08, 2023);
            Date date_2 = new Date(29, 12, 2020);
            Date date_3 = date_1 - date_2;

            Console.WriteLine($"The first date:               {date_1.ToStringDate()}");
            Console.WriteLine($"The second date:              {date_2.ToStringDate()}");
            Console.WriteLine($"Number of days between dates: {date_3.ToStringDays()}");

            Console.ReadKey();
        }
    }
}
