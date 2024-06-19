using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"D:\Vika\C# Professional\ДЗ\3. Программирование ввода-вывода С#\Lesson_3.2");

            directory.CreateSubdirectory("Test");

            Console.ReadKey();

            var file = new FileInfo(directory.FullName + @"\Test\Test.txt");

            FileStream stream_1 = file.Create();

            stream_1.Close();

            Console.ReadKey();

            StreamWriter writer = file.CreateText();

            writer.WriteLine("The first string of text...");
            writer.WriteLine("The second string of text...");
            writer.WriteLine("The third string of text...");

            writer.Close();

            Console.ReadKey();

            Console.WriteLine();

            StreamReader reader = File.OpenText(file.FullName);

            string input;

            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            reader.Close();

            Console.ReadKey();
        }
    }
}
