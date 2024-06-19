using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1, 1, "A"), new Point(1, 4, "B"), new Point(4, 4, "C"));
            Console.Write($"{figure.Type} P = ");
            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
