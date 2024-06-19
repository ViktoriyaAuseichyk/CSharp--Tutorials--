using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._1
{
    class MyClass
    {
        public int MyIntProperty { get; set; }
        public string MyStrProperty { get; set; }

        public override string ToString()
        {
            return MyIntProperty +" "+ MyStrProperty;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(new MyClass() { MyIntProperty = 10, MyStrProperty = "Hello" });

            // Все элементы 'upcast to object' и свойства в классе MyClass будут не доступны. 
            // Нужно переопределить метод ToString()

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
           
            Console.ReadKey();
        }
    }
}
