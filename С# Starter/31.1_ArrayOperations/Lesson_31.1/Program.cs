using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_31._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter any length");
                int userLength = Convert.ToInt32(Console.ReadLine());
                int[] arrayInteger = new int[userLength];

                int index = 0;

                while (index < arrayInteger.Length)
                {
                    Console.WriteLine("Enter any number for an array cell");
                    arrayInteger[index] = Convert.ToInt32(Console.ReadLine());
                    index++;
                }
                // Sort array
                {
                    int indexArraySort = 0;

                    Array.Sort(arrayInteger);

                    while (indexArraySort < arrayInteger.Length)
                    {
                        Console.Write($"{arrayInteger[indexArraySort]}.");
                        indexArraySort++;
                    }
                }

                Console.WriteLine();
                
                // Reverse array
                {
                    int indexArrayReverse = 0;

                    Array.Reverse(arrayInteger);

                    while (indexArrayReverse < arrayInteger.Length)
                    {
                        Console.Write($"{arrayInteger[indexArrayReverse]}.");
                        indexArrayReverse++;
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Enter any a new integer");
                int newInteger = Convert.ToInt32(Console.ReadLine());

                Array.Resize(ref arrayInteger, arrayInteger.Length + 1);
                arrayInteger[arrayInteger.Length - 1] = newInteger;

                int controlIndex = 0;

                while (controlIndex < arrayInteger.Length)
                {
                    Console.Write($"{arrayInteger[controlIndex]}.");
                    controlIndex++;
                }

                Console.ReadKey();
            }
        }
    }
}
