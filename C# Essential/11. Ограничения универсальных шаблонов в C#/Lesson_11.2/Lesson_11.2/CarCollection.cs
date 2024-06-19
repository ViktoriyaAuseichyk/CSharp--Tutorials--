using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._2
{
    internal class CarCollection<T>
    {
        private Car[] cars;
        private int count;

        public CarCollection()
        {
            cars = new Car[0];
        }

        public int Count
        {
            get 
            {
                return count;   
            }
        }

        public void Add(Car car)
        {
            Car[] temp = new Car[cars.Length + 1];
            for (int i = 0; i < cars.Length; i++)
            {
                temp[i] = cars[i];
            }
            temp[cars.Length] = car;
            cars = temp;
            count++;
        }

        public Car this[int index]
        {
            get
            {
                return Car.ShowTheCar(cars[index]);
            }
        }

        public void Clear()
        {
            Car[] cars = new Car[0];
            count = 0;
        }

        public void Show()
        {
            for(int i = 0; i < count; i++)
            {
                Car.ShowTheCar(cars[i]);
            }
        }
    }
}
