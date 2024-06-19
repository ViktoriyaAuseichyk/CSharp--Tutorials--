using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Какой размерностью массив хотите создать? : ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            IntArray array = new IntArray(sizeArray);

            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            Console.WriteLine();

            for (int i = 0; i < sizeArray; i++) 
            {
                Console.WriteLine($"{i} = {array[i]}");
            }

            Console.WriteLine();

            array.OutputMinandMaxNumber();

            Console.WriteLine();

            array.OutputSumAllNumberAndArithmeticMean();

            Console.WriteLine();

            array.OutputOddNumber();

            Console.ReadKey();
        }
    }
}
