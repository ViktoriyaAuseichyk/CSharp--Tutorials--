using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ доступа к версии:");
            string key = Console.ReadLine();

            DocumentWorker worker = new DocumentWorker();
            worker.OpenDocument();

            if (key == "pro") 
            {
                worker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                worker = new ExpertDocumentWorker();
            }
            else 
            {
                Console.WriteLine("Неверный ввод данных"); 
            }

            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }
    }
}
