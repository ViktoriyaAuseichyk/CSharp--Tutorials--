using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._4
{
    internal class Figure
    {
        private Point[] points = new Point[5];
        private string type;

        public string Type
        {
            get
            {
                return type;
            }
        }

        public Figure(Point A, Point B, Point C)
        {
            points = new Point[3];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            type = "Tringle";
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            points = new Point[4];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            type = "Tetragon";
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points = new Point[5];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            points[4] = E;
            type = "Pentagon";
        }
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.YProperty - A.YProperty), 2) + Math.Pow((B.XProperty - A.XProperty), 2));
        }
        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sum += LengthSide(points[i], points[i + 1]);
            }
            sum += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine(sum);
        }
    }
}
