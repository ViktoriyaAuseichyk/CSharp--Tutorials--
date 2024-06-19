using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_40._1
{
    internal class Program
    {
        static int FactorialRecursion(int Number)
        {
            int Result;
            if (Number == 0 || Number == 1)
            {
                Result = 1;
            }
            else
            {
                Result = Number * FactorialRecursion(Number - 1);
            }
            return Result;
        }
        static int FactorialFOR(int Number)
        {
            int Result = 1;
            for (int i = 1; i < Number + 1; i++)
            {
                Result = Result * i;
            }
            return Result;
        }
        static int IntNumbers()
        {
            Console.WriteLine("Enter any integer number");
            int Number = Convert.ToInt32(Console.ReadLine());
            return Number;
        }
        static void Main(string[] args)
        {
            int Number = IntNumbers();
            
            Console.WriteLine();

            int factorialFOR = FactorialFOR(Number);
            Console.WriteLine(factorialFOR);

            Console.WriteLine();

            int factorialRecursion = FactorialRecursion(Number);
            Console.WriteLine(factorialRecursion);

            Console.ReadKey();
            
        }
    }
}
