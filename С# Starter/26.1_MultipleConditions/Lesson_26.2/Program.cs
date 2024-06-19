using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_26._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            const int DIVIDER = 2;

            int remainderOfDivisionFirstNumber = firstNumber % DIVIDER;
            bool firstEven = remainderOfDivisionFirstNumber == 0;
            Console.WriteLine($"Является ли первое число четным: {firstEven}");
            int remainderOfDivisionsecondNumber = secondNumber % DIVIDER;
            bool secondEven = remainderOfDivisionsecondNumber == 0;
            Console.WriteLine($"Является ли второе число четным: {secondEven}");
            int remainderOfDivisionThirdNumber = thirdNumber % DIVIDER;
            bool thirdEven = remainderOfDivisionThirdNumber == 0;
            Console.WriteLine($"Является ли третье число четным: {thirdEven}");
            int remainderOfDivisionFourthNumber = fourthNumber % DIVIDER;
            bool fourthEven = remainderOfDivisionFourthNumber == 0;
            Console.WriteLine($"Является ли четвертое число четным: {fourthEven}"); 
            
            if (firstEven)
            {
                bool isFirstNumberLargest = (firstNumber > secondNumber || !secondEven) &&
                (firstNumber > thirdNumber || !thirdEven) && (firstNumber > fourthNumber || !fourthEven);

                if (isFirstNumberLargest)
                {
                    Console.WriteLine($"Наибольшим четным числом является: {firstNumber}");
                }
            }
            else if (secondEven)
            {
                bool isSecondNumberLargest = (secondNumber > thirdNumber || !thirdEven) &&
                (secondNumber > fourthNumber || !fourthEven) && (secondNumber > firstNumber || !firstEven);
                if (isSecondNumberLargest)
                {
                    Console.WriteLine($"Наибольшим четным числом является: {secondNumber}");
                }
            }
            else if (thirdEven)
            {
                bool isThirdNumberLargest = (thirdNumber > fourthNumber || !fourthEven) &&
                (thirdNumber > firstNumber || !firstEven) && (thirdNumber > secondNumber || !secondEven);
                if (isThirdNumberLargest)
                {
                    Console.WriteLine($"Наибольшим четным числом является: {thirdNumber}");
                }
            }
            else if (fourthEven)
            {
                bool isFourthNumberLargest = (fourthNumber > firstNumber || !firstEven) &&
                (fourthNumber > secondNumber || !secondEven) && (fourthNumber > thirdNumber || !thirdEven);
                if (isFourthNumberLargest)
                {
                    Console.WriteLine($"Наибольшим четным числом является: {fourthNumber}");
                }
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadKey();
        }
    }
}
