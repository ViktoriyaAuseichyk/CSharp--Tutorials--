using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число от 0 до 10 (целое/дробное)");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            double number = 3;
            double numberResult = 10;
            bool numberMore = userNumber > number;
            double result;
            if (numberMore)
            {
                result = userNumber + numberResult;
            }
            else
            {
                result = userNumber * numberResult;
            }
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }
    }
}
