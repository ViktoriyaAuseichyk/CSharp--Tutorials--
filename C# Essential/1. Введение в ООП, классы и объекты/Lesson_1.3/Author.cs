using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    internal class Author
    {
        private string _author;

        public Author(string _author)
        {
            this._author = _author;
        }

        public void Show(int color)
        {
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Автор книги: {_author}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Автор книги: {_author}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Автор книги: {_author}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
