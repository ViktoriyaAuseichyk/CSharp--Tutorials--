using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_41._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number");
            int IntNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int i = 0;

        /*FirstLabel:
            while (i <= IntNumber)
            {
                Console.WriteLine(i);
                i++;
                goto FirstLabel;
            }

            Console.WriteLine();*/


        /*SecondLabel:
            while (i <= IntNumber)
            {
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i <= IntNumber);
                {
                    goto SecondLabel;
                }
            }

            Console.WriteLine();*/

        ThirdLabel:
            for (i++; i <= IntNumber;)
            {
                Console.WriteLine(i);
                goto ThirdLabel;
            }

            Console.ReadKey();
        }
    }
}
