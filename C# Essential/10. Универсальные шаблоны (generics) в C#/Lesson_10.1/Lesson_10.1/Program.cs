using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FacrotyMethod();
            Console.WriteLine(i.GetType().Name);
            Program j = MyClass<Program>.FacrotyMethod();
            Console.WriteLine(j.GetType().Name);
            Console.ReadKey();
        }
    }
}
