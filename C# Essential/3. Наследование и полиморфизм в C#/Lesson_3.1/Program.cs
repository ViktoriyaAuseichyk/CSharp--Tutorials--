using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Label:
            Console.WriteLine("Введите что-нибудь:");
            string value = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Введите число от 1 до 5:");
            int color = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Printer printer = Printer.CreateObject(color);

            printer.Print(value);

            goto Label;

            Console.ReadKey();
        }
    }
}
