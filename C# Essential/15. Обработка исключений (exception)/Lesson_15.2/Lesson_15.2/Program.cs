using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStaff = 3;

            Staff company = new Staff(numberOfStaff);

            int period = 2;

            Console.WriteLine("Employees working for the company during {0} years: ", period);

            int show = company[period];

            Console.WriteLine("All staff: ");
            Console.WriteLine();

            for (int i = 0; i < numberOfStaff; i++)
            {
                company.Show(i);
            }

            Console.ReadKey();
        }
    }
}
