using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_37._1
{
    internal class Program
    {
        static void EnterData(out int numberOfEmployees, out string[] arrayNumberOfEmployees, out int[] arrayCostOfOneDay, out int[] arrayNumberOfDaysThatRequirePayment)
        {
            Console.WriteLine("Enter the number of the employees:");
            numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            arrayNumberOfEmployees = new string[numberOfEmployees];
            arrayCostOfOneDay = new int[numberOfEmployees];
            arrayNumberOfDaysThatRequirePayment = new int[numberOfEmployees];
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("Enter the employee's name:");
                arrayNumberOfEmployees[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Enter the cost of one day: {arrayNumberOfEmployees[i]}");
                arrayCostOfOneDay[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"The number of days that require payment: {arrayNumberOfEmployees[i]}");
                arrayNumberOfDaysThatRequirePayment[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }

        static void CalculationOfEachEmployee(in int numberOfEmployees,
                                              in int[] arrayCostOfOneDay,
                                              in int[] arrayNumberOfDaysThatRequirePayment,
                                              in string[] arrayNumberOfEmployees)
        {
            for (int i = 0; i < numberOfEmployees; i++)
            {
                int amountOfMoneyBePaidEmployee = arrayCostOfOneDay[i] * arrayNumberOfDaysThatRequirePayment[i];
                Console.WriteLine($"The amount of money to be paid to the employee {arrayNumberOfEmployees[i]} = {amountOfMoneyBePaidEmployee}");
            }
        }

        static void CalculationOfTotalAmount(in int numberOfEmployees,
                                             in int[] arrayCostOfOneDay,
                                             in int[] arrayNumberOfDaysThatRequirePayment)
        {
            int totalAmountOfMoneyThatFirmMustPay = 0;

            for (int i = 0; i < numberOfEmployees; i++)
            {
                totalAmountOfMoneyThatFirmMustPay += arrayCostOfOneDay[i] * arrayNumberOfDaysThatRequirePayment[i];
            }
            Console.WriteLine($"The total amount of money that the firm must pay {totalAmountOfMoneyThatFirmMustPay}");
        }
        static void Main(string[] args)
        {
            int numberOfEmployees;
            string[] arrayNumberOfEmployees;
            int[] arrayCostOfOneDay;
            int[] arrayNumberOfDaysThatRequirePayment;

            EnterData(out numberOfEmployees, out arrayNumberOfEmployees, out arrayCostOfOneDay, out arrayNumberOfDaysThatRequirePayment);

            CalculationOfEachEmployee(in numberOfEmployees, in arrayCostOfOneDay, in arrayNumberOfDaysThatRequirePayment, in arrayNumberOfEmployees);

            Console.WriteLine();

            CalculationOfTotalAmount(in numberOfEmployees, in arrayCostOfOneDay, in arrayNumberOfDaysThatRequirePayment);

            Console.ReadKey();

        }
    }
}
