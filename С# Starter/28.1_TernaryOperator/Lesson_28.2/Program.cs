using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = 100;
            ref int x_z = ref x;
            ref int y_z = ref y;
            (x >= y ? ref x_z : ref y_z) = z;
            Console.WriteLine($"Результат: x = {x}, y = {y}");
            Console.ReadKey();
        }
    }
}
