using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal PI_Decimal = 3.1415926536m;

            byte PI_Byte = (byte) PI_Decimal;
            sbyte PI_SByte = (sbyte) PI_Decimal;
            ushort PI_UShort = (ushort) PI_Decimal;
            short PI_Short = (short) PI_Decimal;
            uint PI_UInt = (uint)PI_Decimal;
            int PI_Int = (int) PI_Decimal;
            ulong PI_ULong = (ulong) PI_Decimal;
            long PI_Long = (long) PI_Decimal;
            float PI_Float = (float) PI_Decimal;
            double PI_Double = (double) PI_Decimal;

            Console.WriteLine($"Decimal:{PI_Decimal}\nByte:{PI_Byte}\nSByte:{PI_SByte}\nUShort:{PI_UShort}\n" +
                              $"Short:{PI_Short}\nUInt:{PI_UInt}\nInt:{PI_Int}\nULong:{PI_ULong}\nLong:{PI_Long}\n" +
                              $"Float:{PI_Float}\nDouble:{PI_Double}\n");

            Console.ReadKey();
        }
    }
}
