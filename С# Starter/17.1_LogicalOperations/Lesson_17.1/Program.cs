using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Введите ФИО сотрудника
            Console.Write("Введите ФИО сотрудника: ");
            string name = Console.ReadLine();

            // Введите уровень заработой платы сотрудника
            Console.Write("Введите уровень заработой платы сотрудника: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            

            // Введите уровень выслуги лет сотрудника
            Console.Write("Введите уровень выслуги лет сотрудника: ");
            int years = Convert.ToInt32(Console.ReadLine());

            // Расчет премии
            int x = 0;

            bool result = years < 5 && (x += 10) == 10 ||
                          years >= 5 && years < 10 && (x += 15) == 15 ||
                          years >= 10 && years < 15 && (x += 25) == 25 ||
                          years >= 15 && years < 20 && (x += 35) == 35 ||
                          years >= 20 && years < 25 && (x += 45) == 45 ||
                          years >= 25 && years < 100 && (x += 50) == 50;

            int prize = salary * x / 100;

            Console.WriteLine($"Выдать премию в размере {x}% от заработной платы. " +
                              $"\nПремия составляет: {prize}");
            Console.ReadKey();
        }
    }
}
