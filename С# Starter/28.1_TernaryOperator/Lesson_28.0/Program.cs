using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = -5;

            string quadrant = x > 0 ? (y > 0 ? "1 Qwdr" : "4 Qwdr") : (y > 0 ? "2 Qwdr" : "3 Qwdr");

            /*
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1 Qwdr");
                }
                else
                {
                    Console.WriteLine("4 Qwdr");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("2 Qwdr");
                }
                else
                {
                    Console.WriteLine("3 Qwdr");
                }
            }
            */

            Console.WriteLine(quadrant);

            Console.ReadKey();
        }
    }
}
