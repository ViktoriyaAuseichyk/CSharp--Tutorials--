using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8._2
{
    internal class Program
    {
        enum Colors
        {
            Blue = 0,
            Green = 1,
            Yellow = 2,
            Red = 3
        }
        static void Main(string[] args)
        {
            string text = "Hello";

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Enter color number '1-15':");
                int color = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Printer.Print(text, color);

                const int whiteColor = 15;

                Printer.Print(whiteColor);

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter color number '0-3':");
                int color = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Printer.PrintMyEnum(text, color);

                const int whiteColor = 15;

                Printer.Print(whiteColor);

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
