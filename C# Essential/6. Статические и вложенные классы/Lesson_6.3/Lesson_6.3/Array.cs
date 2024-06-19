using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._3
{
    internal static class Extend
    {
        public static void RandomFill(int[] array, int size)
        {
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
            }
        }

        public static void ShowRandomFill(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Random Array: {array[i]} ");
            }
        }

        public static void SortArray(this int[] array)
        {
            /*for(int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i;  j--)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }
                }
            }*/

            Array.Sort(array);
        }

        public static void ShowSort(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Sort Array: {array[i]} ");
            }
        }
    }
}