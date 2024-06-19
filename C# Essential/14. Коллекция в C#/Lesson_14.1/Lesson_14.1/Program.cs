using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14._1
{
    internal class Program
    {
        static public IEnumerable<int> CreateAnArrayOfEvenNumbers(int[] array)
        {
            if (array[i] != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        yield return array[i];
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else
            {
                yield break;
            }
        }


        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeArray = random.Next(10, 20);
            int[] num = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                num[i] = random.Next(10, 50);
            }

            Console.Write("All Numbers in the array: ");
            foreach (int i in num)
            {
                Console.Write(" {0}. ", i);
            }

            Console.WriteLine();

            Console.Write("All even numbers in the array: ");

            foreach (int i in CreateAnArrayOfEvenNumbers(num))
            {
                Console.Write(" {0}.", i);
            }

            Console.ReadKey();
        }
    }
}
