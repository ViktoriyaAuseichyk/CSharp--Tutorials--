using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._4
{
    internal class Date
    {
        int day;
        int month;
        int year;
        readonly DateTime date;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            date = new DateTime(year, month, day);
        }
        public Date(int day)
        {
            this.day = day;
        }

        public static Date operator -(Date date_1, Date date_2)
        {
            TimeSpan result = date_1.date - date_2.date;
            Date date = new Date(result.Days);
            return date;
        }

        /*public static Date operator +(Date date_1, Date date_2)
        {
            TimeSpan result = date_1.date + date_2.day;
            Date date = new Date(result.Days);
            return date;
        }*/

        public string ToStringDays()
        {
            return "Days: " + this.day;
        }

        public string ToStringDate()
        {
            return "Days: " + this.day + " " + "Month: " + this.month + " " + "Year: " + this.year;
        }
    }
}
