using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._1
{
    internal class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int IndexProperty
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string CountryProperty
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string CityProperty
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string StreetProperty
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int HouseProperty
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int ApartmentProperty
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
}
