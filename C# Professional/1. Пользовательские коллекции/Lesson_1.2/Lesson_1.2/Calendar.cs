using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._2
{
    internal class Calendar
    {

        string[] months = new string[13] { "-", "Januar", "February", "March", "April", "May", "June",
                                           "July", "August", "Semtember", "October", "November", "December"};
        int[] sequenceNumbers = new int[13] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        int[] daysInMonths;
        int sequenceNumber;
        int daysInMonth;

        public Calendar(int year, int sequenceNumber, int daysInMonth)
        {
            this.sequenceNumber = sequenceNumber;
            this.daysInMonth = daysInMonth;

            if (year % 4 == 0)
            {
                daysInMonths = new int[13] { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            }
            else
            {
                daysInMonths = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            }
        }

        public void GetMonthBySequenceNumber()
        {
            for (int i = 0; i < sequenceNumbers.Length; i++)
            {
                if (sequenceNumbers[i] == sequenceNumber)
                {
                    Console.WriteLine("Month: {0}, Sequance Number: {1}, Number of days: {2}", months[i], sequenceNumbers[i], daysInMonths[i]);
                }
            }
        }

        public IEnumerable<string> GetMonthsByNumberOfDaysInMonth()
        {
            for (int j = 0; j < daysInMonths.Length; j++)
            {
                if (daysInMonths[j] == daysInMonth)
                {
                    yield return $"Month: {months[j]}, Sequance Number: {sequenceNumbers[j]}, Number of days: {daysInMonths[j]}";

                }
            }
        }
    }
}
