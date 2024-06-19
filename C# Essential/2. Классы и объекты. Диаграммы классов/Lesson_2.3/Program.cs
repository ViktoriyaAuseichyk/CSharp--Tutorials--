using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите фамилию сотрудника:");
            string surname = Convert.ToString(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("Введите должность сотрудника: 'Директор', 'Заведующий производством', 'Модельер-конструктор', 'Лаборант', 'Закройщик', 'Швея', 'Контролер'.");
            string position = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите стаж работы:");
            decimal lengthOfService = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Employee employee = new Employee(name, surname, position, lengthOfService);

            employee.CalculationOfAdditionalInterest(lengthOfService);
            employee.CalculationOfEmployeeSalary(position);

            Console.WriteLine();

            employee.Show();

            Console.ReadKey();

        }
    }
}
