﻿using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] agesList = { 23, 30, 35 };

            int index = 0;

            while(index < 3)
            {
                byte age = agesList[index];
                Console.WriteLine(age);

                index++;
            }

            // Delay
            Console.ReadKey();
        }
    }
}
