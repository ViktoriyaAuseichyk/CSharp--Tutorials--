using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9._2
{
    internal class Program
    {
        public double ArifmeticNumber()
        {
            Console.WriteLine("Enter any number");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public string ArifmeticFunction()
        {
            Console.WriteLine("Enter any function: '+', '-', '*', '/'...");
            string function = Console.ReadLine();
            return function;
        }

        public delegate double Calculate(double x, double y);

        static void Main(string[] args)
        {
            Program program = new Program();
            double firstNumber = program.ArifmeticNumber();
            double secondNumber = program.ArifmeticNumber();
            string function = program.ArifmeticFunction();

            Calculate calculate = null;

            switch (function)
            {
                case "+":
                    {
                        calculate = (x, y) => x + y;
                        break;
                    }
                case "-":
                    {
                        calculate = (x, y) => x - y;
                        break;
                    }
                case "*":
                    {
                        calculate = (x, y) => x * y;
                        break;
                    }
                case "/":
                    {
                        calculate = (x, y) =>
                        {
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Error");
                                return 0;
                            }
                            else
                            {
                                return x / y;
                            }
                        };
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
            double result = calculate(firstNumber, secondNumber);
            Console.WriteLine();
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }   
    }
}

