using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._1
{
    internal class User
    {
        private string login;

        public string Login
        {
            set { login = value; }

            get
            {
                if (login == null)
                {
                    Console.WriteLine("Поле 'Логин' не заполнено");
                }
                return login;
            }

        }


        private string name;

        public string Name
        {
            set { name = value; }

            get
            {
                if (name == null)
                {
                    Console.WriteLine("Поле 'Имя' не заполнено");
                }
                return name;
            }
        }


        private string surname;

        public string Surname
        {
            set { surname = value; }

            get
            {
                if (surname == null)
                {
                    Console.WriteLine("Поле 'Фамилия' не заполнено");
                }
                return surname;
            }
        }


        private string age;

        public string Age
        {
            set { age = value; }

            get
            {
                if (age == null)
                {
                    Console.WriteLine("Поле 'Возраст' не заполнено");
                }
                return age;
            }
        }

        public readonly DateTime date;

        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string name, string surname, string age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = DateTime.Now;
        }
    }
}
