using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_33._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix multiplication");
            Console.WriteLine("The dimension of the arrays should be such as to allow multiplication of these matrices.");
            Console.WriteLine("Enter two number for the first array:");
            int firstArray_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x");
            int firstArray_x = Convert.ToInt32(Console.ReadLine());
            int[,] firstArray = new int[firstArray_y, firstArray_x];
            Console.WriteLine("Enter two number for the second array:");
            int secondArray_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x");
            int secondArray_x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int[,] secondArray = new int[secondArray_y, secondArray_x];
            int[,] resultArray = new int[firstArray_y, secondArray_x];

            {
                if (firstArray_x != secondArray_y)
                {
                    Console.WriteLine("The entered numbers don't satisfy the condition. Try again");
                    return;
                }
            }

            {
                for (int i = 0; i < firstArray.GetLength(0); i++)
                {
                    for (int j = 0; j < firstArray.GetLength(1); j++)
                    {
                        Console.WriteLine("Enter number for the first array:");
                        firstArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine();

                for (int i = 0; i < firstArray.GetLength(0); i++)
                {
                    for (int j = 0; j < firstArray.GetLength(1); j++)
                    {
                        Console.Write($"{firstArray[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            {
                for (int i = 0; i < secondArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        Console.WriteLine("Enter number for the second array:");
                        secondArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine();

                for (int i = 0; i < secondArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        Console.Write($"{secondArray[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            {
                for (int i = 0; i < firstArray.GetLength(0); i++)
                {
                    for (int j = 0; j < secondArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < firstArray.GetLength(1); k++)
                        {
                            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
                        }
                    }
                }

                Console.WriteLine("Result:");

                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        Console.Write($"{resultArray[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
