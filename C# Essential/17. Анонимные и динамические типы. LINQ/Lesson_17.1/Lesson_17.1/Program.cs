using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter '+', '-', '*', '/'");
                var operation = Console.ReadLine();
                Console.WriteLine("Enter the second number:");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Calculator calculator = new Calculator(firstNumber, operation, secondNumber);

                calculator.Show();

                Console.WriteLine(new string('-', 25));
            }
        }
    }
}
