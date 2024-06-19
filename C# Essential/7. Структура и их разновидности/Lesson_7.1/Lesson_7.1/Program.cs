using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Console.WriteLine("Enter the model name:");
            notebook.Model = Console.ReadLine();
            Console.WriteLine("Enter the name of the manufacturer:");
            notebook.Manufacturer = Console.ReadLine();
            Console.WriteLine("Enter the cost of product:");
            notebook.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            notebook.Show();
            Console.ReadKey();
        }
    }
}
