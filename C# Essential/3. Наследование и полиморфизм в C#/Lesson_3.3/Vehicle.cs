using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    internal class Vehicle
    {
        protected string nameOfTransport;
        protected string costOfTransport;
        protected string yearOfManufacture;
        protected string color;
        protected string transportNumber;
        protected string standartSpeed;
        protected string maxNumberOfPassengers;
        protected string pricePerTicket;

        protected string NameOfTransport { get { return nameOfTransport; } set { nameOfTransport = value; } }
        protected string CostOfTransport { get { return costOfTransport; } set { costOfTransport = value; } }
        protected string YearOfManufacture { get { return yearOfManufacture; } set { yearOfManufacture = value; } }
        protected string Color { get { return color; } set { color = value; } }
        protected string TransportNumber { get { return transportNumber; } set { transportNumber = value; } }
        protected string StandartSpeed { get { return standartSpeed; } set { standartSpeed = value; } }
        protected string MaxNumberOfPassengers { get { return maxNumberOfPassengers; } set { maxNumberOfPassengers = value; } }
        protected string PricePerTicket { get { return pricePerTicket; } set { pricePerTicket = value; } }

        public void Show()
        {
            Console.WriteLine($"Название транспорта: {nameOfTransport};");
            Console.WriteLine($"Стоимость транспорта: {costOfTransport};");
            Console.WriteLine($"Год выпуска: {yearOfManufacture};");
            Console.WriteLine($"Цвет: {color};");
            Console.WriteLine($"Номер транспорта: {transportNumber};");
            Console.WriteLine($"Скорость транспорта: {standartSpeed};");
            Console.WriteLine($"Максимальное количество пассажиров: {maxNumberOfPassengers};");
            Console.WriteLine($"Стоимость билета: {pricePerTicket};");
        }
    }
}
