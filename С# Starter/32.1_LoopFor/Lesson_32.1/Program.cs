using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_32._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 101;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int a = 2500;
            int z = 2;
            for (int i = 999; i < a; i++)
            {
                i = i + z;
                Console.WriteLine(i);
            }*/

            /*int a = 0;
            int z = 3;
            for (int i = 103; i > a; i--)
            {
                i = i - z;
                Console.WriteLine(i);
            }*/

            decimal a = 5;
            decimal z = 0.2m;
            for (decimal i = 0.8m; i < a;)
            {
                i = i + z;
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
