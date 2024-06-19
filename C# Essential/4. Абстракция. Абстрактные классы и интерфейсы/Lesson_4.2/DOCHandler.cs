using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The DOC Handler is open");
        }
        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The DOC Handler is create");
        }
        public override void Chenge()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The DOC Handler is chenge");
        }
        public override void Save()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The DOC Handler is save");
        }
    }
}
