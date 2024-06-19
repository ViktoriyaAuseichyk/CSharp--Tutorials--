using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    internal class ExcelentPupil : Pupil 
    {
        public ExcelentPupil(string name)
        {
            base.name = name;
        }

        public override void Study()
        {
            Console.Write("Отлично учусь\n");
        }
        public override void Read()
        {
            Console.Write("Отлично читаю\n");
        }
        public override void Write()
        {
            Console.Write("Отлично пишу\n");
        }
        public override void Relax()
        {
            Console.Write("Плохо отдыхаю\n");
        }
    }
}
