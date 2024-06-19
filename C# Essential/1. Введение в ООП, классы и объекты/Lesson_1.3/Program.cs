using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Book[] books = new Book[3];

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Введите название книги:");
                string title = Console.ReadLine();
                Console.WriteLine("Введите имя автора:");
                string author = Console.ReadLine();
                Console.WriteLine("Введите содержание книги:");
                string content = Console.ReadLine();

                books[i] = new Book(title, author, content, i);
                i++;
            }

            for (int j = 0; j < books.Length; j++)
            {
                books[j].Show();
                Console.WriteLine();
            }

            Console.ReadKey();
        }        
    }
}
