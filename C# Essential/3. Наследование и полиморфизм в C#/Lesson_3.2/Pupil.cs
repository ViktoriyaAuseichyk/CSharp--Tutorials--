using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{ 
    internal abstract class Pupil 
    {
        public string name;

        public abstract void Study();

        public abstract void Read();

        public abstract void Write();

        public abstract void Relax();
    }
}
