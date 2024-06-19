using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Show();

            Console.WriteLine();

            Ship ship = new Ship();
            ship.Show();

            Console.WriteLine();

            Plane plane = new Plane();
            plane.Show();

            Console.ReadKey();
        }
    }
}
