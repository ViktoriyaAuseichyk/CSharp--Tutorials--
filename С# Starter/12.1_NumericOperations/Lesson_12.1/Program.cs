using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte firstNumber = 35;
            short secondNumber = -25;
            int thirdNumber = 89;
            long fourthNumber = 15;
            sbyte sum = (sbyte)(firstNumber + secondNumber + thirdNumber + fourthNumber);
            short dif = (short)(firstNumber - secondNumber - thirdNumber - fourthNumber);
            Console.WriteLine($"Summa = {sum}\n,Difference = {dif}\n");
            Console.ReadKey();

        }
    }
}
