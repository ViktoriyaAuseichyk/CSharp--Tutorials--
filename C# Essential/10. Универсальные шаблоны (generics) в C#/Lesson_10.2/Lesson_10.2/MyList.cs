using System;
using System.Security.Cryptography;

namespace Lesson_10._2
{
    interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
    internal class MyList<T> 
    {
        private T[] array;
        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a)
        {
            T[] newArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = a;
            array = newArray;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public int Count
        {
            get
            { 
                return array.Length; 
            }
        }

        public void Clear()
        {
            array = new T[0];
        }
        
        public bool Contains(T item)
        {
            for (int i = 0;i < array.Length;i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }  
            }
            return false;
        }
    }
}
