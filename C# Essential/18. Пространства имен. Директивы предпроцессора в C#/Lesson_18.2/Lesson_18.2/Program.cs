using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_10._3;

namespace Lesson_18._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            Word<string, string> word_1 = new Word<string, string>("Pen", "Długopis");
            myDictionary.Add(word_1);
            myDictionary.Show();
            Console.ReadKey();
        }
    }
}
