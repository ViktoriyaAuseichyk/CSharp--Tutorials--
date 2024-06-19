using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number = 2.7182818284590452f;

            System.Byte number_byte = (System.Byte)number;
            System.SByte number_sbyte = (System.SByte)number;
            System.UInt16 number_ushort = (System.UInt16)number;
            System.Int16 number_short = (System.Int16)number;
            System.UInt32 number_uint = (System.UInt32)number;
            System.Int32 number_int = (System.Int32)number;
            System.UInt64 number_ulong = (System.UInt64)number;
            System.Int64 number_long = (System.Int64)number;
            System.Single number_float = (System.Single)number;
            System.Double number_double = (System.Double)number;
            System.Decimal number_decimal = (System.Decimal)number;
            Console.WriteLine("Number: {0}\nSystem.Byte: {1}\nSystem.SByte: {2}\nSystem.UInt16: {3}\n" +               
                              "System.Int16: {4}\nSystem.UInt32: {5}\nSystem.Int32: {6}\nSystem.UInt64: {7}\nSystem.Int64: {8}\n" +
                              "System.Single: {9}\nSystem.Double: {10}\nSystem.Decimal: {11}", number, number_byte, 
                               number_sbyte, number_ushort, number_short, number_uint, number_int, number_ulong,
                               number_long, number_float, number_double, number_decimal);
            Console.ReadKey();
        }
    }
}
