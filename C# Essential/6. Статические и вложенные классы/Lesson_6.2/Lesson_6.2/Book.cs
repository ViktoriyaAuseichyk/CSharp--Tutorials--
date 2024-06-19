using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine($"There is a search for the string '{str}'. Wait a minute...");
        }

        public class Notes
        {
            public string SaveNext(string str)
            {
                string text = null;

                Console.WriteLine($"'{str}' is being saved...\n");

                return text += str;
            }
        }
    }
}
