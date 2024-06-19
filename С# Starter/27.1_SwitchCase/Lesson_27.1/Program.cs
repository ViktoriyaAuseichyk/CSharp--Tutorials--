using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите код знака арифметической операции");
            Console.WriteLine("Сложение(+) : 001");
            Console.WriteLine("Вычитание(-): 002");
            Console.WriteLine("Умножение(*): 003");
            Console.WriteLine("Деление(/)  : 004");

            string numerCommand = Console.ReadLine();

            const string ADDITION = "001", SUBTRACTION = "002", MULTIPLICATION = "003", DIVISION = "004";

            double result;
            switch (numerCommand)
            {
                case ADDITION:
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    }
                case SUBTRACTION:
                    {
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    }
                case MULTIPLICATION:
                    {
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    }
                case DIVISION:
                    {
                        if (firstNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine($"Результат: {result}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ");
                            break;
                        }

                    }
                default:
                    {
                        Console.WriteLine("НЕВЕРНАЯ КОМАНДА");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
