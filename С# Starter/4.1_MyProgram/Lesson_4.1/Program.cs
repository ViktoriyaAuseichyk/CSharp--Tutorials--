using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вывести на экран белым цветом текст на красном фоне
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");
            // Вывести на экран черным цветом текст на белом фоне
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World");
            // Вывести на экран текст с настройками по умолчанию 
            Console.ResetColor();
            Console.WriteLine("Hello World");
            // Delay
            Console.ReadKey();
        }
    }
}
