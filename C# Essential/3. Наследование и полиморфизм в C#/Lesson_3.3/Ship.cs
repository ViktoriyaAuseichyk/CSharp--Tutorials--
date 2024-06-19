using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    internal class Ship : Vehicle
    {
        public Ship() : base()
        {
            NameOfTransport = "Symphony of the Seas";
            CostOfTransport = "1 400 000 000 $";
            YearOfManufacture = "2018";
            Color = "White";
            TransportNumber = "СD 9631";
            StandartSpeed = "40 km/h";
            MaxNumberOfPassengers = "6000";
            PricePerTicket = "1300 $";
        }
    }
}
