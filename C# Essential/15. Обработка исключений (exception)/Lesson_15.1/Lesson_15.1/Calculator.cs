using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15._1
{
    internal class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        /*public double Div(double x, double y)
        {
            if (y == 0)
            {
                Exception exception = new Exception("Error. You can't devide by zero!");

                try
                {
                    throw exception;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Exception handling...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.ResetColor();
                }
            }
            else
            {
                return x / y;
            }

            return 0;
        }*/

        public double? Div(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception handling...");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
