using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8._3
{
    enum StaffPositions
    {
        DIRECTOR = 180,
        DESIGNER = 182,
        LABORATORY_ASSISTANT = 184,
        HEAD_OF_PRODUCTION = 186,
        QUALITY_CONTROLLER = 188,
        CUTTER = 190,
        DRESSMAKER = 192
    }
    internal class Accauntantcs
    {
        public bool AskForBonus(StaffPositions staffPositions, int hours)
        {
           if ((int)staffPositions < hours)
            {
                return true;
            }
           else
            {
                return false;   
            }
        }

        public bool CheckHours(int hours)
        {
            if (hours < 0)
            {
                Console.WriteLine("Hours can't be negative");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
