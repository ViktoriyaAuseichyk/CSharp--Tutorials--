using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    internal abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Chenge();
        abstract public void Save();

        static public AbstractHandler CreateHadler(string documentType)
        {
            AbstractHandler handler;

            switch (documentType)
            {
                case "XML":
                    {
                        handler = new XMLHandler();
                        break;
                    }
                case "TXT":
                    {
                        handler = new TXTHandler();
                        break;
                    }
                case "DOC":
                    {
                        handler = new DOCHandler();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такой тип документа не существует");
                        handler = null;
                        break;
                    }
            }
            return handler;
        }
    }
}
