using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    internal static class Calculator
    {
        public static double firstNumber;
        public static double secondNumber;

        public static double InputFirstNumber(double number) 
        {
            return firstNumber = number;
        }

        public static double InputSecondNumber(double number)
        {
            return secondNumber = number;
        }

        public static double Sum()
        {
            return firstNumber + secondNumber;
        }
        public static double Dif()
        {
            return firstNumber - secondNumber;
        }

        public static double Mul()
        {
            return firstNumber * secondNumber;
        }
        public static double Div()
        {
            if (firstNumber == 0)
            {
                Console.WriteLine("Error. You can't divide by zero.");
            }
            else
            {
                return firstNumber / secondNumber;
            }

            return 0;
        }
        public static double RemOfDiv()
        {
            if (firstNumber == 0)
            {
                Console.WriteLine("Error. You can't divide by zero.");
            }
            else
            {
                return firstNumber % secondNumber;
            }

            return 0;
        }

        public static void Search(string sign) 
        { 
            switch (sign) 
            {
                case "+" :
                    {
                        Console.WriteLine($"Result: {Sum()}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine($"Result: {Dif()}");
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"Result: {Mul()}");
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine($"Result: {Div()}");
                        break;
                    }
                case "%":
                    {
                        Console.WriteLine($"Result: {RemOfDiv()}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sign not found. Try again");
                        break;
                    }
            }
        }
    }
}
