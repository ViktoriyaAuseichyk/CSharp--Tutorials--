using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._4
{
    internal class Point
    {
        private double x;
        private double y;
        private string name;

        public double XProperty
        {
            get
            {
                return x;
            }
        }
        public double YProperty
        {
            get
            {
                return y;
            }
        }
        public string NameProperty
        {
            get
            {
                return name;
            }
        }

        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
