using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_13._1
{
    internal class Program
    {
        static int count;
        static void RecursiveMethod()
        {
            Console.WriteLine("{0} - {1}", Thread.CurrentThread.Name = "Thread", count);
            Thread.Sleep(500);
            ++count;
            ThreadStart recursiveMethod = new ThreadStart(RecursiveMethod);
            Thread thread = new Thread(recursiveMethod);
            thread.Start();
        }

        static void Main(string[] args)
        {
            ThreadStart recursiveMethod = new ThreadStart(RecursiveMethod);
            Thread thread = new Thread(recursiveMethod);
            thread.Start();
        }
    }
}
