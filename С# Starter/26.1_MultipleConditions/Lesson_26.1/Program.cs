using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_26._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую длину прямоугольника");
            float firstLengthRectangle = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите вторую длину прямоугольника");
            float secondLengthRectangle = Convert.ToSingle(Console.ReadLine());

            bool isSquare = firstLengthRectangle == secondLengthRectangle;
            if (isSquare)
            {
                Console.WriteLine("Данный прямоугольник - квадрат");
            }
            else
            {
                ;
            }

            float area;
            float perimeter;
            {
                const string AREA = "001", PERIMETER = "002";

                Console.WriteLine("Введите номер команды, которую вы хотите выполнить:");
                Console.WriteLine("Площадь: 001");
                Console.WriteLine("Периметр: 002");

                string numberCommand = Console.ReadLine();

                bool isArea = AREA == numberCommand;
                bool isPerimeter = PERIMETER == numberCommand;

                if (isArea)
                {
                    area = firstLengthRectangle * secondLengthRectangle;
                    Console.WriteLine($"Площадь прямоугольника: {area}");
                }
                else if (isPerimeter)
                {
                    perimeter = 2 * (firstLengthRectangle + secondLengthRectangle);
                    Console.WriteLine($"Периметр прямоугольника: {perimeter}");
                }
                else
                {
                    Console.WriteLine("Неверная команда!");
                }
                
                Console.ReadKey();
            }

        }
    }
}
