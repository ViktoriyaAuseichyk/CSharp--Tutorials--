using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            Random rnd = new Random();

            int lenghArray = Convert.ToInt32(rnd.Next(10, 50));
            
            for (int i = 0; i < lenghArray; i++)
            {
                list.Add(rnd.Next(10, 50));
            }

            for (int i = 0; i < lenghArray; i++)
            {
                Console.Write("{0} ", list[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Array lenght: {0}", list.Count);

            int number = rnd.Next(10, 50);
            
            Console.WriteLine("'{0}' - This element is in the array: {1}",number, list.Contains(number));

            int[] ex = list.GetArray();

            for (int i = 0; i < ex.Length; i++)
            {
                Console.Write("{0} ", ex[i]);
            }

            list.Clear();

            Console.ReadKey();

        }
    }
}
