using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    internal class BadPupil : Pupil
    {
        public BadPupil(string name)
        {
            base.name = name;
        }

        public override void Study()
        {
            Console.Write("Плохо учусь\n");
        }
        public override void Read()
        {
            Console.Write("Плохо читаю\n");
        }
        public override void Write()
        {
            Console.Write("Плохо пишу\n");
        }
        public override void Relax()
        {
            Console.Write("Отлично отдыхаю\n");
        }
    }
}
