using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accauntantcs accauntantcs = new Accauntantcs();

            Console.WriteLine("Enter hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            accauntantcs.CheckHours(hours);

            if (accauntantcs.AskForBonus(StaffPositions.DESIGNER, hours))
            {
                Console.WriteLine("Give a bonus");
            }
            else
            {
                Console.WriteLine("Don't give a bonus");
            }
            
            Console.ReadKey();
        }
    }
}
