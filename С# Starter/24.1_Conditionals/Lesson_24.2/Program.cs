using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите длину первой стороны треугольника");
            double firstSideTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите длину второй стороны треугольника");
            double secondSideTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите длину третьей стороны треугольника");
            double thirdSideTriangle = Convert.ToDouble(Console.ReadLine());
            bool isTriagleReal = (firstSideTriangle + secondSideTriangle > thirdSideTriangle) &&
                                 (secondSideTriangle + thirdSideTriangle > firstSideTriangle) &&
                                 (thirdSideTriangle + firstSideTriangle > secondSideTriangle);
            if (!isTriagleReal)
            {
                return;
            }

            Console.WriteLine($"Возможен ли треугольник с такими сторонами: {isTriagleReal}");

            bool isTriangleRectangular = Math.Pow(firstSideTriangle, 2) == Math.Pow(secondSideTriangle, 2) + Math.Pow(thirdSideTriangle, 2) ||
                                         Math.Pow(secondSideTriangle, 2) == Math.Pow(thirdSideTriangle, 2) + Math.Pow(firstSideTriangle, 2) ||
                                         Math.Pow(thirdSideTriangle, 2) == Math.Pow(firstSideTriangle, 2) + Math.Pow(secondSideTriangle, 2);

            Console.WriteLine($"Является ли треугольник прямоугольным: {isTriangleRectangular}");

            bool isTriangleEquilateral = firstSideTriangle == secondSideTriangle && thirdSideTriangle == firstSideTriangle;

            Console.WriteLine($"Является ли треугольник равносторонним: {isTriangleEquilateral}");

            bool isTriangleIsosceles = firstSideTriangle == secondSideTriangle && thirdSideTriangle != firstSideTriangle ||
                                       secondSideTriangle == thirdSideTriangle && firstSideTriangle != secondSideTriangle ||
                                       thirdSideTriangle == firstSideTriangle && secondSideTriangle != thirdSideTriangle;
            
            Console.WriteLine($"Является ли треугольник равнобедренным: {isTriangleIsosceles}");

            Console.ReadKey();
        }
    }
}
