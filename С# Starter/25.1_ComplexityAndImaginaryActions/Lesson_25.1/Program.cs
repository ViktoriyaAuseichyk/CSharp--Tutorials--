using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            const int WTF_1_Number = 15;
            const int WTF_2_Number = 4;
            const int WTF_3_Number = 2;
            const double PI = 3.1415926535897931;
            int z = 3;
            int x = 1;
            int y = 2; ;
            bool firstExpression = x < y && userNumber > WTF_1_Number;
            bool secondExpression = z != y && userNumber < WTF_2_Number;
            int g;
            double value;
            if (firstExpression)
            {
                g = y;
                value = g + PI;
                Console.WriteLine("Число g = {0}, значение value = {1}", g, value);
            }

            else

                if (secondExpression)
            {
                g = z;
                value = g + PI * WTF_3_Number;
                Console.WriteLine($"Число g = {g}, значение value = {value}");
            }
            else

                Console.WriteLine("Число не подходит");

            Console.ReadKey();

        }
    }
}
