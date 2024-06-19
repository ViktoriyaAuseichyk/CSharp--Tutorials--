using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    internal class Title
    {
        private string _title;

        public Title(string _title)
        {
            this._title = _title;
        }

        public void Show(int color)
        {
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Название книги: {_title}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Название книги: {_title}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Название книги: {_title}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
