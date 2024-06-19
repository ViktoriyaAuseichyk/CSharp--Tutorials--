using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"D:\Vika\C# Professional\ДЗ\3. Программирование ввода-вывода С#\Lesson_3.1");

            directory.CreateSubdirectory("Test");

            for (int i = 0; i < 100; i++) 
            {
                directory.CreateSubdirectory($@"Test\Test_{i}");
            }

            Console.ReadKey();

            Directory.Delete(@"D:\Vika\C# Professional\ДЗ\3. Программирование ввода-вывода С#\Lesson_3.1\Test", true);

            Console.ReadKey();


        }
    }
}
