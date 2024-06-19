using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The TXT Handler is open");
        }
        public override void Create()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The TXT Handler is create");
        }
        public override void Chenge()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The TXT Handler is chenge");
        }
        public override void Save()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The TXT Handler is save");
        }
    }
}
