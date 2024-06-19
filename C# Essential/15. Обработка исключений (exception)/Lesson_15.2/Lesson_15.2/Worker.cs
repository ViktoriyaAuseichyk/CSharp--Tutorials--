using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15._2
{
    internal struct Worker
    {
        string fullNameEmployee;
        string employeePosition;
        double yearOfHire;
        double employeeExperience;

        public Worker(string fullNameEmployee, string employeePosition, double yearOfHire)
        {
            this.fullNameEmployee = fullNameEmployee;
            this.employeePosition = employeePosition;
            this.yearOfHire = yearOfHire;
            employeeExperience = DateTime.Now.Year - yearOfHire;
        }
        public string FullNameEmployee
        {
            get { return fullNameEmployee; }
        }
        public string EmployeePosition
        {
            get { return employeePosition; }
        }

        public double YearOfHire
        {
            get { return yearOfHire; }
            set
            {
                if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 50)
                {
                    yearOfHire = value;
                }
                else
                {
                    Exception exception = new Exception("Wrong year. Try again");

                    try
                    {
                        throw exception;
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Exception Handking...");
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        Console.ResetColor();
                    }
                }
            }
        }

        public double EmployeeExperience
        {
            get { return employeeExperience; }   
        }

        public void Show()
        {
            Console.WriteLine("FullName Employee: {0}", fullNameEmployee);
            Console.WriteLine("Employee Position: {0}", employeePosition);
            Console.WriteLine("Year Of Hire: {0}", yearOfHire);
            Console.WriteLine("Employee Experience: {0}", employeeExperience);
            Console.WriteLine();
        }     
    }
}
