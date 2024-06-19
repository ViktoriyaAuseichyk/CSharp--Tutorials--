using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte e = 5;
            byte r = 99;
            Console.WriteLine($"{e} Равно {r}");
            Console.WriteLine(5 == 99);
            Console.WriteLine($"{e} Не равно {r}");
            Console.WriteLine(5 != 99);
            Console.WriteLine($"{e} Больше {r}");
            Console.WriteLine(5 > 99);
            Console.WriteLine($"{e} Меньше {r}");
            Console.WriteLine(5 < 99);
            Console.WriteLine($"{e} Больше или равно {r}");
            Console.WriteLine(5 >= 99);
            Console.WriteLine($"{e} Меньше или равно {r}");
            Console.WriteLine(5 <= 99);
            
            ushort u = 456;
            ushort i = 987;
            Console.WriteLine($"{u} Равно {i}");
            Console.WriteLine(456 == 987);
            Console.WriteLine($"{u} Не равно {i}");
            Console.WriteLine(456 != 987);
            Console.WriteLine($"{u} Больше {i}");
            Console.WriteLine(456 > 987);
            Console.WriteLine($"{u} Меньше {i}");
            Console.WriteLine(456 < 987);
            Console.WriteLine($"{u} Больше или равно {i}");
            Console.WriteLine(456 >= 987);
            Console.WriteLine($"{u} Меньше или равно {i}");
            Console.WriteLine(456 <= 987);

            uint o = 4567u;
            uint p = 8945u;
            Console.WriteLine($"{o} Равно {p}");
            Console.WriteLine(4567 == 8945);
            Console.WriteLine($"{o} Не равно {p}");
            Console.WriteLine(4567 != 8945);
            Console.WriteLine($"{o} Больше {p}");
            Console.WriteLine(4567 > 8945);
            Console.WriteLine($"{o} Меньше {p}");
            Console.WriteLine(4567 < 8945);
            Console.WriteLine($"{o} Больше или равно {p}");
            Console.WriteLine(4567 >= 8945);
            Console.WriteLine($"{o} Меньше или равно {p}");
            Console.WriteLine(4567 <= 8945);

            ulong a = 45612ul;
            ulong s = 12345ul; 

            sbyte q = 52;
            sbyte w = 52;

            short t = -255;
            short y = -369;

            int d = 4586;
            int f = 1256;

            long g = -785695L;
            long h = 56821L;

            float j = 985.256f;
            float k = 5689.66f; 

            double l = 2545.26;
            double z = 859.568;

            decimal c = 451256.56896m;
            decimal v = 12658.125m; 

            Console.ReadKey();

            




        }
    }
}
