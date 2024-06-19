using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15._2
{
    internal class Staff
    {
        Worker[] staff;
        int numberOfStaff;
        Worker worker;

        /*public Staff(int numberOfStaff)
        {
            this.numberOfStaff = numberOfStaff;
            staff = new Worker[numberOfStaff];

            for (int i = 0; i < numberOfStaff; i++)
            {
                Console.WriteLine("Enter the employee's full name:");
                string FullNameEmployee = Console.ReadLine();
                Console.WriteLine("Enter the employee's position:");
                string EmployeePosition = Console.ReadLine();
                Console.WriteLine("Enter the year the employee was hired:");
                double YearOfHire = Convert.ToDouble(Console.ReadLine());

                staff[i] = new Worker(FullNameEmployee, EmployeePosition, YearOfHire);

                Console.WriteLine();
            }

            staff = staff.OrderBy(worker => worker.FullNameEmployee).ToArray<Worker>();
        }*/


        public int this[int index]
        {
            get
            {
                int i = 0;
                while (i < numberOfStaff)
                {
                    if (staff[i].EmployeeExperience == index)
                    {
                        Show(i);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                return -1;
            }
        }

        public void Show(int index)
        {
            if (index != -1)
            {
                staff[index].Show();
                Console.WriteLine();
            }
            else
            {
                ;
            }
        }

        public Staff(int numberOfStaff)
        {
            this.numberOfStaff = numberOfStaff;
            staff = new Worker[numberOfStaff];
            string FullNameEmployee;
            string EmployeePosition;
            double YearOfHire;

            Console.Write("Enter the employee's full name: ");
            FullNameEmployee = "B";
            Console.Write(FullNameEmployee);
            Console.WriteLine();
            Console.Write("Enter the employee's position: ");
            EmployeePosition = "R";
            Console.Write(EmployeePosition);
            Console.WriteLine();
            Console.Write("Enter the year the employee was hired: ");
            YearOfHire = 2021;
            Console.Write(YearOfHire);
            Console.WriteLine();

            staff[0] = new Worker(FullNameEmployee, EmployeePosition, YearOfHire);

            Console.Write("Enter the employee's full name: ");
            FullNameEmployee = "M";
            Console.Write(FullNameEmployee);
            Console.WriteLine();
            Console.Write("Enter the employee's position: ");
            EmployeePosition = "F";
            Console.Write(EmployeePosition);
            Console.WriteLine();
            Console.Write("Enter the year the employee was hired: ");
            YearOfHire = 2020;
            Console.Write(YearOfHire);
            Console.WriteLine();

            staff[1] = new Worker(FullNameEmployee, EmployeePosition, YearOfHire);

            Console.Write("Enter the employee's full name: ");
            FullNameEmployee = "A";
            Console.Write(FullNameEmployee);
            Console.WriteLine();
            Console.Write("Enter the employee's position: ");
            EmployeePosition = "W";
            Console.Write(EmployeePosition);
            Console.WriteLine();
            Console.Write("Enter the year the employee was hired: ");
            YearOfHire = 2021;
            Console.Write(YearOfHire);
            Console.WriteLine();

            staff[2] = new Worker(FullNameEmployee, EmployeePosition, YearOfHire);

            staff = staff.OrderBy(worker => worker.FullNameEmployee).ToArray<Worker>();

            Console.WriteLine();

        }
    }
}

