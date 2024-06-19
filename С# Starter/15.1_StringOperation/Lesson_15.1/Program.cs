using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            string surname = Console.ReadLine();
            Console.WriteLine($"Hello {name}{surname}!\nIt's a good day today!");

            Console.ReadKey();
        }
    }
}
