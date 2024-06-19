using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = 15;

            /*x += y >> x++ * z;
            //x = (x + (y >> ((x++) * z)));
            //x = (5 + (10 >> ((5) * 15)));
            Console.WriteLine(x);*/

            /*z = ++x & y * 5;
            //z = (++x) & (y * 5);
            //z = (6) & (10 * 5);
            Console.WriteLine(z);*/

            /*y /= x + 5 | z;
            //y = (y / (x + (5 | z));
            //y = (10 / (5 + (5 | 15));
            Console.WriteLine(y);*/

            /*z = x++ & y * 5;
            //z = (x++) & (y * 5);
            //z = (5) & (10 * 5);
            Console.WriteLine(z);*/

            /*x = y << x++ ^ z;
            //x = ((y << (x++)) ^ z);
            //x = ((10 << (5)) ^ 15);
            Console.WriteLine(x);*/
            
            Console.ReadKey(); 
        }
    }
}
