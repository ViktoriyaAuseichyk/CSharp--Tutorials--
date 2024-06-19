using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12._2
{
    public class Model
    {
        private int sek;

        public string Tick(string sek)
        {
            int number = Convert.ToInt32(sek);
            ++number;
            sek = Convert.ToString(number);
            if (sek.Length == 1) 
            {
                return sek = "0" + sek;
            }
            else
            {
                return sek;
            }
        }

        public void Reset()
        {
            this.sek = 0;
        }
    }
}