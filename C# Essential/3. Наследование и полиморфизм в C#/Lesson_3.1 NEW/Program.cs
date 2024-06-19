using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1_NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter print_1 = new ColorPrinter(ConsoleColor.Red);
            print_1.Print("Hello");

            Printer printUp = print_1;
            printUp.Print("Hello");

            ColorPrinter print_2 = new ColorPrinter(ConsoleColor.Green);
            print_2.Print("Hello");

            Console.ReadKey();
        }
    }
}
