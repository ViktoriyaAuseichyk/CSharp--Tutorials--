using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2_NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите полное название файла");
            string fileName = Console.ReadLine();
            Redactor redactor = new Redactor();
            redactor.ChooseDocument(fileName);

            redactor.Open();
            redactor.Create();
            redactor.Charge();
            redactor.Save();

            Console.ReadKey();


        }
    }
}
