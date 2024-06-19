using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._2
{
    static class ExtensionMyList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] tempArray = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                tempArray[i] = list[i];
            }
            return tempArray;
        }
    }
}
