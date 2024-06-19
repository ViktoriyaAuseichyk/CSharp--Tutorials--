using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                { new {Key = "apple"}, new {value = "jabłko"} },
                { new {Key = "pen"},   new {value = "długopis"} },
                { new {Key = "book"},  new {value = "książka"} },
                { new {Key = "mouse"}, new {value = "mysz"} },
                { new {Key = "cup"},   new {value = "kubek"} }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine("ENG: {0}, POL: {1}", item.Key, item.Value);
            }

            Console.ReadKey();  
        }
    }
}
