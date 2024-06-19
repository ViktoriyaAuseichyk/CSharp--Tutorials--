using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input any word:");
            string word = Console.ReadLine();

            Console.WriteLine();

            FindAndReplaceManager.FindNext(word);

            Console.WriteLine();

            for (int i = 0; i < 3; i++) 
            {
                Book.Notes notes = new Book.Notes();

                Console.WriteLine("Input any text:");
                string text = Console.ReadLine();

                Console.WriteLine() ;

                notes.SaveNext(text);
            }
            Console.ReadLine();
        }
    }
}
