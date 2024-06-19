using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Calculator.InputFirstNumber(firstNumber);

            Console.WriteLine();

            Console.WriteLine("Input a second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());  
            Calculator.InputSecondNumber(secondNumber);

            Console.WriteLine();

            Console.WriteLine("Input a math sign: '+', '-', '*', '/', '%'.");
            string sign = Console.ReadLine();

            Console.WriteLine();

            Calculator.Search(sign);

            Console.ReadKey();
        }
    }
}
