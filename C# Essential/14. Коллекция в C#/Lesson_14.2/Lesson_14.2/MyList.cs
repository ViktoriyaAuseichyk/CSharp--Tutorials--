using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14._2
{
    internal class MyList<T>
    {
        T[] items;
        int count = 0;
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public void Add(T item)
        {
            if (items == null)
            {
                items = new T[1];
                items[0] = item;
                count++;
            }
            else
            {
                T[] temp = new T[items.Length + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                temp[temp.Length - 1] = item;
                items = temp;
                count++;
            }
        }

        public T this[int index]
        {
            get { return items[index]; }
        }

        public void Clear()
        {
            items = null;
            count = 0;
        }

        public IEnumerable<T> GetArray()
        {
            if (items.Length != 0 )
            {
                for (int i = 0; i < items.Length; i++)
                {
                    yield return items[i];
                }
            }
            else
            {
                yield break;
            }
        }
    }
}
