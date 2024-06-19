using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The XML Handler is open");
        }
        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The XML Handler is create");
        }
        public override void Chenge()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The XML Handler is chenge");
        }
        public override void Save()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The XML Handler is save");
        }
    }
}
