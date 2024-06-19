using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> en_pl = new SortedList<string, string>();;

            en_pl.Add("pen", "długopis");
            en_pl.Add("joke", "żart");
            en_pl.Add("table", "stół");
            en_pl.Add("oven", "piekarnik");
            en_pl.Add("socket", "gniazdo");

            foreach (var s in en_pl)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            foreach (var s in en_pl.Reverse())
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
