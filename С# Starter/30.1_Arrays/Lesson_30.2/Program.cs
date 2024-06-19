using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_30._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dateIsCorrect;
            {
                string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                //string[] number = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
                string nameMonth, numberMonth;
                {
                    Console.WriteLine("Enter the name of the month:");
                    nameMonth = Console.ReadLine();
                    Console.WriteLine("Enter the month number:");
                    numberMonth = Console.ReadLine();
                }
                dateIsCorrect = false;

                int monthIndex = Convert.ToInt32(numberMonth) - 1;

                dateIsCorrect = 0 <= monthIndex && monthIndex <= 11 && months[monthIndex] == nameMonth;

                /*int index = 0;
                while (index < months.Length)
                {
                    bool nameMonthMatched, numberMonthMatched;
                    {
                        nameMonthMatched = months[index] == nameMonth;
                        numberMonthMatched = number[index] == numberMonth;
                    }
                    if (nameMonthMatched && numberMonthMatched)
                    {
                        dateIsCorrect = true;
                        break;
                    }
                    else
                    {
                        index++;
                    }  
                }*/
                if (dateIsCorrect)
                {
                    Console.WriteLine("The data is correct");
                }
                else
                {
                    Console.WriteLine("Try again...");
                }

                Console.ReadKey();
            }
        }
    }
}
