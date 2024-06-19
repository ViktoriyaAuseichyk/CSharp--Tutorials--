using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Enter any word in English:");
                string key = Console.ReadLine(); 
                Console.WriteLine("Enter the translation of this word in Polish:");
                string value = Console.ReadLine();

                Word<string, string> word = new Word<string, string>(key, value);

                dictionary.Add(word);

                Console.WriteLine();

            }

            Console.WriteLine("Number of words: {0}", dictionary.Count);

            dictionary.Show();

            Console.ReadKey();
        }
    }
}
