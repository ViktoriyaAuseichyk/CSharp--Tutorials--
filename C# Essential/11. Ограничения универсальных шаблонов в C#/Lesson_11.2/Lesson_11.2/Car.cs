using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._2
{
    internal class Car
    {
        private string nameOfTheCar;
        private int yearOfRelease;
        public Car(string nameOfTheCar, int yearOfRelease)
        {
            this.NameOfTheCar = nameOfTheCar;
            this.YearOfRelease = yearOfRelease;
        }

        public string NameOfTheCar
        {
            get
            {
                return nameOfTheCar;
            }
            set 
            { 
                nameOfTheCar = value; 
            }
        }

        public int YearOfRelease
        {
            get
            {
                return yearOfRelease;
            }
            set
            {
                yearOfRelease = value;
            }
        }

        public static Car ShowTheCar(Car cars)
        {
            Console.WriteLine("Name Of The Car: {0}, Year Of Release: {1}", cars.NameOfTheCar, cars.YearOfRelease);
            return cars;
        }
    }
}
