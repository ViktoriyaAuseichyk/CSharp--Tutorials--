using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block_1 = new Block(15, 15, 18, 18);
            Block block_2 = new Block(15, 15, 18, 18);
            Block block_3 = new Block(18, 18, 32, 32);

            Console.Write("The first block parameters: ");
            Console.Write(block_1.ToString());
            Console.WriteLine();
            Console.Write("The second block parameters: ");
            Console.Write(block_2.ToString());
            Console.WriteLine();
            Console.Write("The third block parameters: ");
            Console.Write(block_3.ToString());
            Console.WriteLine();
            Console.Write("The first block is equal to the second block: ");
            Console.Write(block_1.Equals(block_2));
            Console.WriteLine();
            Console.Write("The second block is equal to the third block: ");
            Console.Write(block_2.Equals(block_3));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
