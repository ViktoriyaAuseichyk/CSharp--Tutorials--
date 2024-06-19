using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_39._1
{
    internal class Program
    {
        static int PrintResult(ref int firstIntNumber, ref int secondIntNumber, ref int thirdIntNumber)
        {
            int SumIntNumber = firstIntNumber + secondIntNumber + thirdIntNumber;
            return SumIntNumber;
        }
        static int PrintResult(int firstIntNumber, int secondIntNumber, int thirdIntNumber)
        {
            int DifIntNumber = firstIntNumber - secondIntNumber - thirdIntNumber;
            return DifIntNumber;
        }
        static double PrintResult(ref int firstIntNumber, ref int secondIntNumber)
        {
            double MathPowIntNumber = Math.Pow(firstIntNumber,secondIntNumber);
            return MathPowIntNumber;
        }
        static string PrintResult(ref string firstString,ref string secondString,ref string thirdString)
        {
            string stringIntResult = $"{firstString} + {secondString} + {thirdString}";
            return stringIntResult;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer number");
            int firstIntNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number");
            int secondIntNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer number");
            int thirdIntNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int firstResult = PrintResult(ref firstIntNumber, ref secondIntNumber, ref thirdIntNumber);
            Console.WriteLine(firstResult);

            Console.WriteLine(); 

            int secondResult = PrintResult(firstIntNumber, secondIntNumber, thirdIntNumber);
            Console.WriteLine(secondResult);

            Console.WriteLine();
            
            double thirdResult = PrintResult(ref firstIntNumber, ref secondIntNumber);
            Console.WriteLine(thirdResult);

            Console.WriteLine();

            string firstString = Convert.ToString($"{firstIntNumber}");
            string secondString = Convert.ToString($"{secondIntNumber}");
            string thirdString = Convert.ToString($"{thirdIntNumber}");

            string fourthResult = PrintResult(ref firstString, ref secondString, ref thirdString);
            Console.WriteLine(fourthResult);

            Console.ReadKey();
        }
    }
}
