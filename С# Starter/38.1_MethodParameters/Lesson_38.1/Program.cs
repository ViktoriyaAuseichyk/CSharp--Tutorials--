using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_38._1
{
    internal class Program
    {
        static int FirstMethod(ref int firstIntNumber, ref int secondIntNumber, ref int thirdIntNumber)
        {
            int sumIntNumber = firstIntNumber + secondIntNumber + thirdIntNumber;
            return sumIntNumber;
        }

        static int SecondMethod(ref int firstIntNumber, ref int secondIntNumber, ref int thirdIntNumber)
        {
            firstIntNumber++;
            secondIntNumber++;
            thirdIntNumber++;

            int SumEnlaredIntNumber = firstIntNumber + secondIntNumber + thirdIntNumber;
            return SumEnlaredIntNumber;

        }

        static int ThirdMethod(ref int firstIntNumber, ref int secondIntNumber, ref int thirdIntNumber, bool trueOrFalse)
        {
            int thirdResult = 0;

            if (trueOrFalse == true)
            {
                thirdResult = FirstMethod(ref firstIntNumber, ref secondIntNumber, ref thirdIntNumber);
                return thirdResult;
            }
            else 
            {
                thirdResult = SecondMethod(ref firstIntNumber, ref secondIntNumber, ref thirdIntNumber);
                return thirdResult;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write true or false");
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter first integer number");
            int firstIntNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number");
            int secondIntNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer number");
            int thirdIntNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int Result = ThirdMethod(ref firstIntNumber, ref secondIntNumber, ref thirdIntNumber);

            Console.WriteLine();
            
            Console.WriteLine($"First Number = {firstIntNumber}, Second Number = {secondIntNumber}, Third Number = {thirdIntNumber}");
            
            Console.WriteLine();
            
            Console.WriteLine(Result);
            
            Console.ReadKey();
        }
    }
}
