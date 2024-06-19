using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    internal class Employee
    {
        private string name;
        private string surname;
        private string position;
        private decimal salary;
        private decimal lengthOfService;
        private decimal percent;
        private decimal tax;
        private readonly decimal taxRevenue = 13m;

        public Employee(string name, string surname, string position, decimal lengthOfService)
        {
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.lengthOfService = lengthOfService;
        }

        public void CalculationOfAdditionalInterest(decimal lengthOfService)
        {
            if (lengthOfService < 0 && lengthOfService == 0)
            {
                Console.WriteLine("Стаж работы не может быть больше либо равно '0'.");
            }
            else if (lengthOfService > 0 && lengthOfService < 5)
            {
                this.percent = 5m;
            }
            else if (lengthOfService > 5 && lengthOfService < 10)
            {
                this.percent = 10m;
            }
            else if (lengthOfService > 10 && lengthOfService < 15)
            {
                this.percent = 15m;
            }
            else if (lengthOfService > 15 && lengthOfService < 20)
            {
                this.percent = 20m;
            }
            else
            {
                this.percent = 25m;
            }
        }

        public decimal CalculationOfEmployeeSalary()
        {
            decimal awardForWorkExperience;

            awardForWorkExperience = this.salary * this.percent / 100;
            this.salary = this.salary + awardForWorkExperience;
            this.tax = this.salary * this.taxRevenue / 100;
            return this.salary = this.salary - this.tax;
        }

        public void CalculationOfEmployeeSalary(string position)
        {      
            switch (position)
            {
                case "Директор":
                    {
                        this.salary = 2500m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                case "Заведующий производством":
                    {
                        this.salary = 1500m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                case "Модельер-конструктор":
                    {
                        this.salary = 2000m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                case "Лаборант":
                    {
                        this.salary = 1200m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                case "Закройщик":
                    {
                        this.salary = 800m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                case "Швея":
                    {
                        this.salary = 900m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                case "Контролер":
                    {
                        this.salary = 700m;
                        this.salary = CalculationOfEmployeeSalary();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Должность не найдена.");
                        break;
                    }
            }

            return;
        }

        public void Show()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Зарплата: {salary}");
            Console.WriteLine($"Налоговый вычет: {tax}");
        }
    }
}
