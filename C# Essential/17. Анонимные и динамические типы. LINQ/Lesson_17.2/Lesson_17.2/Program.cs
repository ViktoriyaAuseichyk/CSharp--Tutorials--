using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car("Honda", "Pilot", "2008", "Blue"),
                new Car("BMW", "7", "2005", "Gray"),
                new Car("Nissan", "Terrano", "2017", "Red"),
                new Car("Toyota", "Supra", "2022", "Metallic") 
            };

            var customers = new List<Customer>
            {
                new Customer("BMW", "Alberto Fillini", "+48 585 569 874"),
                new Customer("Nissan", "Pawel Luno", "+48 213 258 874"),
                new Customer("Toyota", "Max Ricco", "+48 124 458 785")
            };

            var query_1 = from customer in customers
                          join car in cars on customer.Brand equals car.Brand
                          select new
                          {
                              NameOfCustomer = customer.NameOfCustomer,
                              PhoneNumber = customer.PhoneNumber,
                              Brand = car.Brand,
                              Model = car.Model,
                              YearOfManufacture = car.YearOfManufacture,
                              Colour = car.Colour
                          };

            foreach (var item in query_1)
            {
                Console.WriteLine("Name of customer: {0}, Phone number: {1}, Brand: {2}, " +
                                  "Model: {3}, Year of Manufacture: {4}, Colour: {5}", item.NameOfCustomer, 
                                  item.PhoneNumber, item.Brand, item.Model, item.YearOfManufacture, 
                                  item.Colour);
            }

            Console.WriteLine(new string('-', 25));

            var query_2 = from quary in query_1
                          orderby quary.NameOfCustomer
                          select new
                          {
                              NameOfCustomer = quary.NameOfCustomer,
                              PhoneNumber = quary.PhoneNumber,
                              Brand = quary.Brand,
                              Model = quary.Model,
                              YearOfManufacture = quary.YearOfManufacture,
                              Colour = quary.Colour
                          };

            foreach (var item in query_2)
            {
                Console.WriteLine("Name of customer: {0}, Phone number: {1}, Brand: {2}, " +
                                  "Model: {3}, Year of Manufacture: {4}, Colour: {5}", item.NameOfCustomer,
                                  item.PhoneNumber, item.Brand, item.Model, item.YearOfManufacture,
                                  item.Colour);
            }

            Console.ReadKey();
        }
    }
}



