using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

        Label:

            Console.WriteLine("Введите 'Логин'");
            user.Login = Console.ReadLine();

            Console.WriteLine("Введите 'Имя'");
            user.Name = Console.ReadLine();

            Console.WriteLine("Введите 'Фамилию'");
            user.Surname = Console.ReadLine();

            Console.WriteLine("Введите 'Возраст'");
            user.Age = Console.ReadLine();

            Console.WriteLine(new string('-', 30));

            Console.Write($"Логин: {user.Login}; \nИмя: {user.Name}; \nФамилия: {user.Surname}; \nВозраст: {user.Age}; \nДата заполнения анкеты: {user.date}; \n");

            Console.WriteLine(new string('-', 30));

            goto Label;

            Console.ReadKey();
        }
    }
}
