using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeArray];

            Extend.RandomFill(array, sizeArray);

            Console.WriteLine();    

            Extend.ShowRandomFill(array, sizeArray);

            Console.WriteLine();

            Extend.SortArray(array);

            Extend.ShowSort(array, sizeArray);

            Console.ReadKey();
        }
    }
}
