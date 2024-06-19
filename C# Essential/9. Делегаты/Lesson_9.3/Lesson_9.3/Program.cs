using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9._3
{
    internal class Program
    {
        public delegate double RandomInt();
        public delegate double MyDelegate(RandomInt[] a);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = (a) =>
            {
                double avg = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    avg += a[i]();
                }
                return avg / a.Length;
            };

            RandomInt[] randomInts = new RandomInt[10];
            Random random = new Random();
            for (int i = 0; i < randomInts.Length; i++)
            {
                randomInts[i] = () =>
                {
                    return random.Next(1, 100);
                    //return 122;
                };
            }

            for (int i = 0; i < randomInts.Length; i++)
            {
                Console.Write($"{randomInts[i].Invoke()} ");
            }

            double result = myDelegate(randomInts);

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
