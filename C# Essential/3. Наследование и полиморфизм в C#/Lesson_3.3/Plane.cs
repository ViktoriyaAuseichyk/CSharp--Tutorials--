using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    internal class Plane : Vehicle 
    {
        public Plane() : base()
        {
            NameOfTransport = "TУ-134";
            CostOfTransport = "112000000";
            YearOfManufacture = "1963";
            Color = "Silver";
            TransportNumber = "FR 7712";
            StandartSpeed = "880 km/h";
            MaxNumberOfPassengers = "270";
            PricePerTicket = "92 $";
        }
    }
}
