using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;

            Random random = new Random();

            MyMatrix matrix = new MyMatrix(random.Next(1,10), random.Next(1,10));

            matrix.ShowBaseArray();

            matrix.ResizeArray();

            matrix.ShowDerivedArray();

            matrix.InputUser();

            Console.ReadKey();
        }
    }
}
