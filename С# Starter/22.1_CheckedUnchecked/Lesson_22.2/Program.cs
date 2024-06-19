using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите первое целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите второе целое число");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;
            int d;
            {
                c = a + b;
                d = a * b;
            }
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"c = {c}, d = {d}");
            Console.ReadKey();
        }
    }
}
