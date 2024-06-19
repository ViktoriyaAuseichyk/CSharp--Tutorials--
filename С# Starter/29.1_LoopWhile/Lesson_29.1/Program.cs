using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_29._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целлое число");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                x--;
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
