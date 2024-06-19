
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house_1 = new House("Bogrowa", 6);
            
            House house_2 = house_1.Clone();

            Console.WriteLine(house_1.GetHashCode());
            Console.WriteLine(house_2.GetHashCode());

            Console.WriteLine(house_1.ToString());
            Console.WriteLine(house_2.ToString());

            Console.WriteLine(new string('-', 25));

            house_1.FlatNumber = 63;

            Console.WriteLine(house_1.GetHashCode());
            Console.WriteLine(house_2.GetHashCode());

            Console.WriteLine(house_1.ToString());
            Console.WriteLine(house_2.ToString());

            Console.WriteLine(new string('-', 25));

            House house_3 = house_1.DeepClone();

            Console.WriteLine(house_1.GetHashCode());
            Console.WriteLine(house_3.GetHashCode());

            Console.WriteLine(house_1.ToString());
            Console.WriteLine(house_3.ToString());

            Console.WriteLine(new string('-', 25));

            house_3.Adress = "Drukarska";
            house_3.FlatNumber = 8;

            Console.WriteLine(house_1.GetHashCode());
            Console.WriteLine(house_3.GetHashCode());

            Console.WriteLine(house_1.ToString());
            Console.WriteLine(house_3.ToString());

            Console.ReadKey();
        }
    }
}
