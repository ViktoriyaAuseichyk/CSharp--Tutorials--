using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            /*x += y - x++ * z;
            //x = (x + (y - ((x++) * z)));
            //x = (10 + (12 - ((10) * 3)));
            Console.WriteLine(x);*/

            /*z = --x - y * 5;
            //z = ((--x) - (y * 5));
            // z = ((9) - (12 * 5));
            Console.WriteLine(z);*/

            /*y /= x + 5 % z;
            // y = (y / (x + (5 % z)));
            // y = (12 / (10 + (5 % 3)));
            Console.WriteLine(y);*/

            /*z = x++ + y * 5;
            // z = ((x++) + (y * 5));
            // z = ((10) + (12 * 5));
            Console.WriteLine(z);*/

            x = y - x++ * z;
            // x = (y - ((x++) * z));
            // x = (12 - ((10) * 3));
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
