using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_1._1
{
    internal class Program
    {
        static IEnumerable<int> ReturnsOddNumbersSquared(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} = ", i);
                    yield return i * i;
                }
            }
        }

        static void Main(string[] args)
        {
            int length = 5;
            int[] arr = new int[length];

            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(10, 50);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            IEnumerable<int> result = ReturnsOddNumbersSquared(arr);
            
            foreach (var i in result)
            {
                Console.Write("{0}", i);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
