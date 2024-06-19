using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 5;
            double j = 0;

            Calculator calculator = new Calculator();

            Console.WriteLine("{0} + {1} = {2}", i, j, calculator.Add(i, j));
            Console.WriteLine("{0} / {1} = {2}", i, j, calculator.Div(i, j));

            Console.ReadKey();
        }
    }
}
