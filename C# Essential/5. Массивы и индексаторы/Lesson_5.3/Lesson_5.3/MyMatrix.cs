using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._3
{
    internal class MyMatrix
    {
        private int[,] firstMatrix;
        private int[,] secondMatrix;

        Random rnd = new Random();

        public MyMatrix(int a, int b)
        {
            this.firstMatrix = new int[Math.Abs(a), Math.Abs(b)];
            Fill();
        }

        public void Fill()
        {
            for (int i = 0; i < this.firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.firstMatrix.GetLength(1); j++)
                {
                    this.firstMatrix[i, j] = rnd.Next(1, 10);
                }
            }
        }

        public void ShowBaseArray()
        {
            Console.WriteLine($"Базовый массив: {firstMatrix.GetLength(0)}, {firstMatrix.GetLength(1)}");
            for (int i = 0; i < this.firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.firstMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", firstMatrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void ResizeArray()
        {
            this.secondMatrix = new int[rnd.Next(10, 20), rnd.Next(10, 20)];

            for (int i = 0; i < Math.Min(firstMatrix.GetLength(0), secondMatrix.GetLength(0)); i++)
            {
                for (int j = 0; j < Math.Min(firstMatrix.GetLength(1), secondMatrix.GetLength(1)); j++)
                {
                    secondMatrix[i, j] = firstMatrix[i, j];
                }
            }

            if (secondMatrix.GetLength(0) > firstMatrix.GetLength(0) || secondMatrix.GetLength(1) > firstMatrix.GetLength(1))
            {
                for (int i = Math.Min(firstMatrix.GetLength(0), secondMatrix.GetLength(0)); i < secondMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < secondMatrix.GetLength(1); j++)
                    {
                        secondMatrix[i, j] = rnd.Next(1, 10);
                    }
                }

                for (int i = 0; i < secondMatrix.GetLength(0); i++)
                {
                    for (int j = Math.Min(firstMatrix.GetLength(1), secondMatrix.GetLength(1)); j < secondMatrix.GetLength(1); j++)
                    {
                        secondMatrix[i, j] = rnd.Next(1, 10);
                    }
                }
            }
        }

        public void ShowDerivedArray()
        {
            Console.WriteLine($"Производный массив: {secondMatrix.GetLength(0)}, {secondMatrix.GetLength(1)}");
            for (int i = 0; i < this.secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.secondMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", secondMatrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void InputUser()
        {
            Console.WriteLine("Условия: ");
            Console.WriteLine($"1. Введенные значения должны быть от 0 до {secondMatrix.GetLength(0)} для строк.");
            Console.WriteLine($"2. Введенные значения должны быть от 0 до {secondMatrix.GetLength(1)} для столбцов.");
            Console.WriteLine("3. Начальная строка должна быть меньше конечной строки.");
            Console.WriteLine("4. Начальный столбец должен быть меньше конечного столбца.");

            Console.WriteLine("Введите номер начальной строки");
            int startCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер начального столбца");
            int startRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер конечной строки");
            int endCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер конечного столбца");
            int endRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            ShowPart(startRow, startCol, endRow, endCol);

        }
        public void ShowPart(int startRow, int startCol, int endRow, int endCol)
        {
            bool checkStartRow = startRow <= secondMatrix.GetLength(1) && startRow >= 0 && startRow < endRow;
            bool checkStartCol = startCol <= secondMatrix.GetLength(0) && startCol >= 0 && startCol < endCol;
            bool checkEndRow = startRow <= secondMatrix.GetLength(1) && startRow >= 0;
            bool checkEndCol = startCol <= secondMatrix.GetLength(0) && startCol >= 0;
            if (checkStartRow && checkStartCol && checkEndRow && checkEndCol)
            {
                for (int i = startCol; i < endCol; i++)
                {
                    for (int j = startRow; j < endRow; j++)
                    {
                        Console.Write("{0} ", secondMatrix[i, j]);
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введенные значения не удовлетворяют условиям. Попробуйте еще раз!");
                Console.ForegroundColor = ConsoleColor.Gray;
                InputUser();
            }
        }

    }
}
