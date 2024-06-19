using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._3
{
    internal class House
    {
        string adress;
        int flatNumber;
        
        public House(string adress, int flatNumber)
        {
            this.adress = adress;
            this.flatNumber = flatNumber;
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int FlatNumber
        {
            get { return flatNumber; }
            set { flatNumber = value; }
        }

        public House Clone()
        {
            return this; 
        }

        public House DeepClone()
        {
            return new House(this.adress, this.flatNumber);
        }

        public override string ToString()
        {
            return "Adress: " + adress + ", " + "Flat Number: " + flatNumber;
        }
    }
}
