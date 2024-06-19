using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    internal abstract class AbstractBaseClass
    {
        protected string content;
        abstract public string Content { get; set; }
        public abstract void Show();
    }
}
