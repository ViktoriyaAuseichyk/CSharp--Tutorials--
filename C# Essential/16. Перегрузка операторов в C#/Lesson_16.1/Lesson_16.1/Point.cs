using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._1
{
    internal class Point
    {
        double x, y, z;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point a, Point b) 
        {
            return new Point(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Point operator *(Point a, Point b)
        {
            return new Point(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Point operator /(Point a, Point b)
        {
            if (a.x != 0 && a.y != 0 && a.z != 0)
            {
                return new Point(a.x / b.x, a.y / b.y, a.z / b.z);
            }
            else
            {
                Console.WriteLine("You can't devide by zero!"); 
                return null;
            }
        }

        public string Show(Point x)
        {
            return string.Format($"[x: {x.x}, b: {x.y}, c: {x.z}]");
        }
    }
}
