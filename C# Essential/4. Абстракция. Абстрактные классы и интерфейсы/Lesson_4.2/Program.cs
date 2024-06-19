using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип документа: 'XML', 'TXT', 'DOC':");
            string documentType = Console.ReadLine();

            AbstractHandler handler = AbstractHandler.CreateHadler(documentType);

            Console.WriteLine("Выберите функционал документа: 'Open', 'Create', 'Chenge', 'Save':");
            string documentFunctional = Console.ReadLine();

            switch (documentFunctional)
            {
                case "Open":
                    {
                        handler.Open();
                        break;
                    }
                case "Create":
                    {
                        handler.Create();
                        break;
                    }
                case "Chenge":
                    {
                        handler.Chenge();
                        break;
                    }
                case "Save":
                    {
                        handler.Save();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такой функционал документа не существует");
                        handler = null;
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
