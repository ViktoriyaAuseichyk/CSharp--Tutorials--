using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("Number of eliments: {0}", list.Count);
            Console.WriteLine();
            Console.WriteLine("The element at node number '3': {0}", list[3]);
            Console.WriteLine();
            Console.Write("All elements: ");
            foreach (int i in list.GetArray())
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}

