using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            Car car_1 = new Car("Volvo", 1990);
            carCollection.Add(car_1);
            Car car_2 = new Car("Nissan", 2005);
            carCollection.Add(car_2);
            Car car_3 = new Car("Jeely", 2018);
            carCollection.Add(car_3);
            carCollection.Show();
            Console.WriteLine("Total number of cars: {0}", carCollection.Count);
            Console.WriteLine("Car number '3': {0}", carCollection[2]);
            Console.WriteLine("All cars are being removed from the list...");
            carCollection.Clear();
            Console.WriteLine("Total number of cars: {0}", carCollection.Count);
            Console.ReadKey();
        }
    }
}
