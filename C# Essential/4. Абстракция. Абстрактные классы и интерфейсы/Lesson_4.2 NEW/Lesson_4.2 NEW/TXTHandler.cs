using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2_NEW
{
    internal class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {

        }

        public override void Save()
        {
            Console.WriteLine($"{fileName} сохранен в формате TXT");
        }
    }
}
