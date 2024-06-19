using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_36._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sentences you want to enter:");
            int numberOfSentencesEnteredByUser = Convert.ToInt32(Console.ReadLine());
            string[][] wholeText = new string[numberOfSentencesEnteredByUser][];
            for (int i = 0; i < numberOfSentencesEnteredByUser; i++)
            {
                Console.WriteLine("Enter sentences:");
                string sentence = Console.ReadLine();
                wholeText[i] = sentence.Split( );
            }
            Console.WriteLine();
            for (int i = 0; i < wholeText.GetLength(0); i++)
            {
                for (int j = 0; j < wholeText[i].GetLength(0); j++)
                {
                    Console.WriteLine($"{wholeText[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
