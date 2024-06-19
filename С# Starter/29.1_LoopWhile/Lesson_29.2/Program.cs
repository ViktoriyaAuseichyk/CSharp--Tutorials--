using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_29._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int y = Convert.ToInt32(Console.ReadLine());
            int min = x < y ? x : y;
            int max = x > y ? x : y;
            int it = min + 1;
            while (it < max)
            {
                if (it % 2 != 0)
                {
                    Console.WriteLine(it);
                }
                it++;
            }
            
            Console.ReadKey();
        }
    }
}
