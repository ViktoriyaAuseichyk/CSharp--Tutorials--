using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_13._2
{
    internal class Program
    {
        static int count = 1;
        static void ShowMatrix()
        {
                Matrix matrix = new Matrix(count);
                ThreadStart threadStart = new ThreadStart(matrix.ShowColumnOFChars);
                Thread thread = new Thread(threadStart);
                thread.Start();
                Thread.Sleep(1000);
                count = count + 3;
        }
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 40);

            for (int i = 0; i < 15; i++)
            {
                ShowMatrix();
            }
            Console.ReadKey();
        }
    }
}
