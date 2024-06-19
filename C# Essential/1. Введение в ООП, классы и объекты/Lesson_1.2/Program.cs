using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника:");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника:");
            double secondSide = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(firstSide, secondSide);

            Console.WriteLine();

            Console.WriteLine($"Площадь прямоугольника...вывод из свойства: {rectangle.Area};");
            Console.WriteLine($"Периметр прямоугольника...вывод из свойства: {rectangle.Perimeter};");

            Console.ReadKey();
        }
    }
}
