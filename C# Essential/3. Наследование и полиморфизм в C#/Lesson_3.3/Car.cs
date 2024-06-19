using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    internal class Car : Vehicle
    {
        public Car() : base()
        {
            NameOfTransport = "Honda Elysion";
            CostOfTransport = "15 350 $";
            YearOfManufacture = "2003";
            Color = "Dark Green";
            TransportNumber = "AB 8125";
            StandartSpeed = "120 km/h";
            MaxNumberOfPassengers = "7";
            PricePerTicket = "20 $";
        }
    }
}
