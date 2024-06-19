using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._1
{
    internal struct Notebook
    {
        string model;
        string manufacturer;
        double price;

        public string Model
        { 
            get 
            { 
                return model; 
            } 
            set 
            {
                model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Model: {model}, Manufacture: {manufacturer}, Price: {price} dollar");
        }

    }
}
