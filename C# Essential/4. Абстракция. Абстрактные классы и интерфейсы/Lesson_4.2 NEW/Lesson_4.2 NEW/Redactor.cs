using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2_NEW
{
    internal class Redactor
    {
        AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 3);
            switch (format.ToLower())
            {
                case "txt":
                    {
                        handler = new TXTHandler(fileName);
                        break;
                    }
                case "doc":
                    {
                        handler = new DOCHandler(fileName);
                        break;
                    }
                case "xml":
                    {
                        handler = new XMLHandler(fileName);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неопознаный формат");
                        break;
                    }
            }
        }

        public void Open()
        {
            handler.Open();
        }
        public void Create()
        {
            handler.Create();
        }
        public void Charge()
        {
            handler.Change();
        }
        public void Save()
        {
            handler.Save();
        }

    }
}
