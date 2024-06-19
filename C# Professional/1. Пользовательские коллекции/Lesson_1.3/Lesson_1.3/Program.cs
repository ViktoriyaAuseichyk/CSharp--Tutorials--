using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen_Queue citizen_Queue = new Citizen_Queue();
            Random rnd = new Random();

            Student student_1 = new Student();
            student_1.ID = rnd.Next(1000, 9999);
            citizen_Queue.AddCitizen(student_1);

            Pensioner pensioner_1 = new Pensioner();
            pensioner_1.ID = rnd.Next(1000, 9999);
            citizen_Queue.AddCitizen(pensioner_1);

            Student student_2 = new Student();
            student_2.ID = rnd.Next(1000, 9999);
            citizen_Queue.AddCitizen(student_2);

            Worker worker_1 = new Worker();
            worker_1.ID = rnd.Next(1000, 9999);
            citizen_Queue.AddCitizen(worker_1);

            Pensioner pensioner_2 = new Pensioner();
            pensioner_2.ID = rnd.Next(1000, 9999);
            citizen_Queue.AddCitizen(pensioner_2);

            Student student_3 = new Student();
            student_3.ID = rnd.Next(1000, 9999); 
            citizen_Queue.AddCitizen(student_3);

            citizen_Queue.GetCount();

            Console.WriteLine();

            IEnumerable<Citizen> citizens_1 = citizen_Queue.GetCitizen_Queue();

            foreach (Citizen citizen in citizens_1)
            {
                Console.WriteLine("{0}", citizen);
            }

            citizen_Queue.RemoveCitizen();

            Console.WriteLine();

            citizen_Queue.GetCount();

            Console.WriteLine();

            foreach (Citizen citizen in citizens_1)
            {
                Console.WriteLine("{0}", citizen);
            }

            Console.WriteLine();

            IEnumerable<Citizen> citizens_2 = citizen_Queue.ReturnLast();

            foreach (Citizen citizen in citizens_2)
            {
                Console.WriteLine("{0}", citizen);
            }


            Console.ReadKey();
        }
    }
}
