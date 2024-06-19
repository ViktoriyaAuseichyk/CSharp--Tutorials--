using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141593;
            const bool MY_CONST = true;
            Console.WriteLine("Введите любое дробное число");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            bool isConstBigger = PI == userNumber;
            bool result = MY_CONST == isConstBigger;
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }


    }
}
