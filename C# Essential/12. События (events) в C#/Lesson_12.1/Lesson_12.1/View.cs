using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12._1
{
    public class View
    {
        public delegate void MyDelegate(string str);
        
        public static event MyDelegate TextAdd;

        static void Main(string[] args)
        {
            //new Presenter(this);
            new Presenter();
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    TextAdd.Invoke(str);
                }
            }
        }
    }
}