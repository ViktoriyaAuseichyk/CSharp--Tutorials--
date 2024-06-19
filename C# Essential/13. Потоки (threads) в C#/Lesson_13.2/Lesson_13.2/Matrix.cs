using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_13._2
{

    internal class Matrix
    {
        public object key = new object();
        char[] allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();  // 35
        Random rnd;
        int windowSize_Row = 40;
        int sizeArray;
        char[] ColumnOfChars;
        int column;

        public Matrix(int column)
        {
            rnd = new Random();
            sizeArray = rnd.Next(4, 8);
            ColumnOfChars = new char[sizeArray];
            this.column = column;
        }

        public char[] AddCharsInArray(char[] array)
        {
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = allChars[rnd.Next(1, 35)];
            }
            return array;
        }

        public void ShowCharsPerColumn(char[] array, int column, int row)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 3)
                {
                    Console.CursorLeft = column;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(array[i]);
                }
                else if (i == array.Length - 2)
                {
                    Console.CursorLeft = column;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(array[i]);
                }
                else if (i == array.Length - 1)
                {
                    Console.CursorLeft = column;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(array[i]);
                }
                else
                {
                    Console.ResetColor();
                }
            }
        }

        public void ClearElement(int column, int row)
        {
            Console.CursorTop = row;
            Console.CursorLeft = column;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("█");
        }

        public void ShowColumnOFChars()
        {
            while (true)
            {               
                for (int row = 0; row < windowSize_Row; row++)
                {
                    lock (key)
                    {

                        Console.CursorTop = row;
                        Console.CursorLeft = column;

                        if (row == 0)
                        {
                            Thread.Sleep(100);
                            AddCharsInArray(ColumnOfChars);
                            if (windowSize_Row - sizeArray > row)
                            {
                                ShowCharsPerColumn(ColumnOfChars, column, row);
                            }
                            else
                            {
                                ;
                            }
                            ClearElement(column, row);
                        }
                        else if (row % 2 == 0)
                        {
                            Thread.Sleep(100);
                            AddCharsInArray(ColumnOfChars);
                            if (windowSize_Row - sizeArray > row)
                            {
                                ShowCharsPerColumn(ColumnOfChars, column, row);
                            }
                            else
                            {
                                ;
                            }
                            ClearElement(column, row);
                        }
                        else
                        {
                            Thread.Sleep(100);
                            AddCharsInArray(ColumnOfChars);
                            if (windowSize_Row - sizeArray > row)
                            {
                                ShowCharsPerColumn(ColumnOfChars, column, row);
                            }
                            else
                            {
                                ;
                            }
                            ClearElement(column, row);
                        }
                        Thread.Sleep(2000);
                    }
                }
            }

        }
    }
}