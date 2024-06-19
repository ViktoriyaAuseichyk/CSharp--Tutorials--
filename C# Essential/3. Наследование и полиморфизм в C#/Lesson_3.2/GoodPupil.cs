using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string name)
        {
            base.name = name;
        }

        public override void Study()
        {
            Console.Write("Хорошо учусь\n");
        }
        public override void Read()
        {
            Console.Write("Хорошо читаю\n");
        }
        public override void Write()
        {
            Console.Write("Хорошо пишу\n");
        }
        public override void Relax()
        {
            Console.Write("Хорошо отдыхаю\n");
        }
    }
}
