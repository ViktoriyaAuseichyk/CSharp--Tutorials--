using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14._2
{
    internal static class MyStaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] arr = new T[list.Count()];

            int i = 0;

            foreach (T item in list)
            {
                arr[i] = item;
                i++;
            }
            return arr;
        }
    }
}
