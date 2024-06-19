using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["house"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["pensil"]);
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["sun"]);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(dictionary["książka"]);
            Console.WriteLine(dictionary["dom"]);
            Console.WriteLine(dictionary["długopis"]);
            Console.WriteLine(dictionary["stół"]);
            Console.WriteLine(dictionary["ołówek"]);
            Console.WriteLine(dictionary["jabłko"]);
            Console.WriteLine(dictionary["słońce"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
