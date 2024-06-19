using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1.25d, 25.5d, 56.8d);
            Point b = new Point(7.28d, 15.7d, 8.75d);
            Point c;

            Console.WriteLine("Point 'a': {0}", a.Show(a));
            Console.WriteLine("+");
            Console.WriteLine("Point 'b': {0}", b.Show(b));
            Console.WriteLine("=");
            c = a + b;
            Console.WriteLine("Point 'c': {0}", c.Show(c));

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Point 'a': {0}", a.Show(a));
            Console.WriteLine("-");
            Console.WriteLine("Point 'b': {0}", b.Show(b));
            Console.WriteLine("=");
            c = a - b;
            Console.WriteLine("Point 'c': {0}", c.Show(c));

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Point 'a': {0}", a.Show(a));
            Console.WriteLine("*");
            Console.WriteLine("Point 'b': {0}", b.Show(b));
            Console.WriteLine("=");
            c = a * b;
            Console.WriteLine("Point 'c': {0}", c.Show(c));

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Point 'a': {0}", a.Show(a));
            Console.WriteLine("/");
            Console.WriteLine("Point 'b': {0}", b.Show(b));
            Console.WriteLine("=");
            c = a / b;
            Console.WriteLine("Point 'c': {0}", c.Show(c));

            Console.ReadKey();
        }
    }
}
