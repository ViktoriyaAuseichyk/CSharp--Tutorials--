using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._2
{
    internal class IntArray
    {
        // int[] array;
        /* 
            public IntArray(int n)
            {
                array = new int[Math.Abs(n)];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 100);
                    Console.WriteLine("{0}, ", array[i]);
                }
            }
        */


        private int[] array;
        private int size;

        public IntArray(int i)
        {
            this.size = i;
            array = new int[i];
        }

        public int this[int index]
        {
            get    
            {
                if (index >= 0 && index < size)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Попытка обращения за пределы массива.");
                }
                return 0;   
            }
            set   
            {
                if (index >= 0 && index < size)
                {
                    array[index] = value;
                }
                else
                {
                    Console.WriteLine("Попытка записи за пределами массива.");
                }
            }
        }

        public void OutputMinandMaxNumber()
        {
            Array.Sort(array);
            Console.WriteLine($"Максимальное число: {array[size - 1]}");
            Console.WriteLine($"Минимальное число: {array[0]}");
        }

        public void OutputSumAllNumberAndArithmeticMean()
        {
            int sum = 0;

            for (int i = 0; i < size; i++) 
            {
                sum += array[i];
            }
            Console.WriteLine($"Сумма всех чисел: {sum}");

            int arithmeticMean = sum / size;

            Console.WriteLine($"Среднее арифметическое значение: {arithmeticMean}");
        }

        public void OutputOddNumber()
        {
            for (int i = 0;i < size;i++)
            {
               if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Нечетное число: {array[i]}");
                }
            }
        }
    }
}
