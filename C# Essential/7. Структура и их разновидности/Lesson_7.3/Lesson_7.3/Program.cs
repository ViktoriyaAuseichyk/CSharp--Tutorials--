using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._3
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }

        static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            //ClassTaker(myClass);
            //StructTaker(myStruct);
            myClass.change = "Не изменено";
            myStruct.change = "Не изменено";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine($"My Class : {myClass.change}\nMy Struct : {myStruct.change}");

            Console.WriteLine();

            ClassTaker(myClass);
            StructTaker(ref myStruct);

            Console.WriteLine($"My Class : {myClass.change}\nMy Struct : {myStruct.change}"); 
            Console.ReadKey();
        }
    }
}
