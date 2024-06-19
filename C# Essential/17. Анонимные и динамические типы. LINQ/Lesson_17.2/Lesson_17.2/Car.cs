using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._2
{
    struct Car
    {
        string brand;
        string model;
        string yearOfManufacture;
        string colour; 

        public Car(string brand, string model, string yearOfManufacture, string colour)
        {
            this.brand = brand;
            this.model = model;
            this.yearOfManufacture = yearOfManufacture;
            this.colour = colour;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        { 
            get { return model; } 
            set {  model = value; } 
        }

        public string YearOfManufacture
        {
            get { return yearOfManufacture; }
            set { yearOfManufacture = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
