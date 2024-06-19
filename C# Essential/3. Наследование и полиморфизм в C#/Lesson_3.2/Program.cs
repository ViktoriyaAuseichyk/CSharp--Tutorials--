using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoodPupil pupil_1 = new GoodPupil("Светлана");
            BadPupil pulil_2 = new BadPupil("Петр");
            ExcelentPupil pupil_3 = new ExcelentPupil("Татьяна");
            BadPupil pupil_4 = new BadPupil("Евгений");

            ClassRoom group = new ClassRoom(pupil_1, pulil_2, pupil_3, pupil_4);

            group.StudentStudy();

            Console.WriteLine(new string('-', 50));

            group.StudentRead();

            Console.WriteLine(new string('-', 50));

            group.StudentWrite();

            Console.WriteLine(new string('-', 50));

            group.StudentRelax();

            Console.ReadKey();
        }
    }
}
