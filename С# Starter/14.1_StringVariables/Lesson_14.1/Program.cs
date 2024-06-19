using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите первое слово:");
            string word_1 = Console.ReadLine();
            for (int i = 0; i < word_1.Length; i++)
                Console.WriteLine(word_1[i]);
      

            Console.WriteLine("Напишите второе слово:");
            string word_2 = Console.ReadLine();
            for (int i = 0; i < word_2.Length; i++)
                Console.WriteLine(word_2[i]);

            Console.WriteLine("Напишите третье слово:");
            string word_3 = Console.ReadLine();
            for (int i = 0; i < word_3.Length; i++)
                Console.WriteLine(word_3[i]);

            Console.WriteLine("Напишите четвертое слово:");
            string word_4 = Console.ReadLine();
            for (int i = 0; i < word_4.Length; i++)
                Console.WriteLine(word_4[i]);

            Console.WriteLine("Напишите пятое слово:");
            string word_5 = Console.ReadLine();
            for (int i = 0; i < word_5.Length; i++)
                Console.WriteLine(word_5[i]);

            Console.ReadKey();

        }
    }
}
