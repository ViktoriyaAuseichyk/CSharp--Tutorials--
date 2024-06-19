using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8._2
{
    enum Colors
    {
        Blue = 0,
        Green = 1,
        Yellow = 2,
        Red = 3
    }
    internal static class Printer
    {
        public static void Print(string text, int color) 
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(text);
        }
        public static void Print(int color) 
        {
            Console.ForegroundColor = (ConsoleColor)color;
        }
        public static void PrintMyEnum(string text, int color) 
        { 
            switch (color)
            {
                case (int)Colors.Blue:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(text);
                        break;
                    }
                case (int)Colors.Green:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(text);
                        break;
                    }
                case (int)Colors.Yellow:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(text);
                        break;
                    }
                case (int)Colors.Red:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(text);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Color not found!");
                        break;
                    }
            }
        }
    }
}
