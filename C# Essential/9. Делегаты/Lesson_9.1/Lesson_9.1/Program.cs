using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9._1
{
    internal class Program
    {
        public double Fill()
        {
            Console.WriteLine("Enter any number");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public delegate double ArithmeticMean(double x, double y, double z);
        static void Main(string[] args)
        {
            ArithmeticMean arithmeticMean = (x, y, z) => (x + y + z) / 3;
            //ArithmeticMean arithmeticMean = delegate (double x, double y, double z) { return (x + y + z) / 3; };
            Program program = new Program();
            double firstNumber = program.Fill();
            double secondNumber = program.Fill();
            double thirdNumber = program.Fill();
            double result = arithmeticMean(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();

        }
    }
}
