using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите первое целое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите второе целое число");
            int y = Convert.ToInt32(Console.ReadLine());
            bool XIsEven = x % 2 == 0;
            bool YIsEven = y % 2 == 0;
            int ResultXIsEven = XIsEven ? x : ++x;
            Console.WriteLine(ResultXIsEven);
            int ResultYIsEven = YIsEven ? y : ++y;
            Console.WriteLine(ResultYIsEven);
            bool sum = ((x + y) % 4) == 0;
            string result = sum ? "Сумма значений x и y делится на 4" : "Сумма значений x и y на 4 не делится";
            Console.WriteLine("{0}", result);
            Console.ReadKey();
        }
    }
}
