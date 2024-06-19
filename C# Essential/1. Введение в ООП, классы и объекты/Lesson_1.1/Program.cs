using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address apartmentInMinsk = new Address();
            apartmentInMinsk.IndexProperty = 211200;
            apartmentInMinsk.CountryProperty = "Belarus";
            apartmentInMinsk.CityProperty = "Minsk";
            apartmentInMinsk.StreetProperty = "Igumensky tract";
            apartmentInMinsk.HouseProperty = 14;
            apartmentInMinsk.ApartmentProperty = 83;
            Console.Write($"{apartmentInMinsk.IndexProperty} /");
            Console.Write($" {apartmentInMinsk.CountryProperty} /");
            Console.Write($" {apartmentInMinsk.CityProperty} /");
            Console.Write($" {apartmentInMinsk.StreetProperty} /");
            Console.Write($" {apartmentInMinsk.HouseProperty} /");
            Console.Write($" {apartmentInMinsk.ApartmentProperty} ");
            Console.ReadKey();
        }
    }
}
