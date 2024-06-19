using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }

        static public Printer CreateObject(int color)
        {
            switch (color)
            {
                case 1:
                    {
                        return new WhitePrinter();
                    }
                case 2:
                    {
                        return new YellowPrinter();
                    }
                case 3:
                    {
                        return new RedPrinter();
                    }
                case 4:
                    {
                        return new BluePrinter();
                    }
                case 5:
                    {
                        return new GreenPrinter();
                    }
                default:
                    {
                        Console.WriteLine("Не найдено");
                        return new WhitePrinter();
                    }
            }
        }
    }
}
