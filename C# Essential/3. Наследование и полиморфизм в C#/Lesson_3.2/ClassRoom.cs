using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson_3._2
{
    internal class ClassRoom
    {
        public Pupil[] pupil = null;

        public ClassRoom(Pupil pupil_1, Pupil pupil_2)
        {
            pupil = new Pupil[2];
            this.pupil[0] = pupil_1;
            this.pupil[1] = pupil_2;
        }
        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3)
        {
            pupil = new Pupil[3];
            this.pupil[0] = pupil_1;
            this.pupil[1] = pupil_2;
            this.pupil[2] = pupil_3;
        }
        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
        {
            pupil = new Pupil[4];
            this.pupil[0] = pupil_1;
            this.pupil[1] = pupil_2;
            this.pupil[2] = pupil_3;
            this.pupil[3] = pupil_4;
        }

        public void StudentStudy()
        {
            Console.WriteLine("Ученики учатся:");

            for (int i = 0; i < this.pupil.Length; i++)
            {
                Console.Write($"{pupil[i].name}: ");
                pupil[i].Study();
            }
        }

        public void StudentRead()
        {
            Console.WriteLine("Ученики читают:");

            for (int i = 0; i < this.pupil.Length; i++)
            {
                Console.Write($"{pupil[i].name}: ");
                pupil[i].Read();
            }
        }

        public void StudentWrite()
        {
            Console.WriteLine("Ученики пишут:");

            for (int i = 0; i < this.pupil.Length; i++)
            {
                Console.Write($"{pupil[i].name}: ");
                pupil[i].Write();
            }
        }
        public void StudentRelax()
        {
            Console.WriteLine("Ученики отдыхают:");

            for (int i = 0; i < this.pupil.Length; i++)
            {
                Console.Write($"{pupil[i].name}: ");
                pupil[i].Relax();
            }
        }

    }
}
