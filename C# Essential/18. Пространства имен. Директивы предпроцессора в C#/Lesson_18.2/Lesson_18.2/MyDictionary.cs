using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._3
{
    interface IMyDictionary<TKey, TValue>
    {
        void Add(Word<TKey, TValue> word);
        void Clear();
        Word<TKey, TValue> this[int index] { get; }
        int Count { get; }
        void Show();
    }
    internal class MyDictionary<TKey, TValue> : Word<TKey, TValue>, IMyDictionary<TKey, TValue> 
    {
        public Word<TKey, TValue>[] array;

        public MyDictionary()
        {
            this.array = new Word<TKey, TValue>[0];
        }

        public void Add(Word<TKey, TValue> word)
        {
            Word<TKey, TValue>[] tempArray = new Word<TKey, TValue>[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = word;

            array = tempArray;
        }

        public Word<TKey, TValue> this[int index]
        {
            get
            {
                if (array[index] == null)
                {
                    Console.WriteLine("Not found");
                    return null;
                }
                else
                {
                    return array[index];
                }
            }
        }

        public void Clear()
        {
            array = new Word<TKey, TValue>[0];
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Key: {0} - Value: {1}", array[i].Key, array[i].Value);
            }
        }
    }
}
