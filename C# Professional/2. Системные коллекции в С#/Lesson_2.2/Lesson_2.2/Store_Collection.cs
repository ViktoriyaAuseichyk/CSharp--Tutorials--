using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class Store_Collection<K, V>
    {
        ShopCart<K, V>[] collection;
        int count;

        public Store_Collection()
        {
            this.collection = new ShopCart<K, V>[0];
        }

        public void GrowArr()
        {
            if (collection == null)
            {
                collection = new ShopCart<K, V>[2];
            }
            else if (collection.Length == count)
            {
                ShopCart<K, V>[] tempArr = new ShopCart<K, V>[collection.Length + 1];
                for (int i = 0; i < collection.Length; i++)
                {
                    tempArr[i] = collection[i];
                }
                collection = tempArr;
            }
            else
            {
                ;
            }

        }

        public void Add(ShopCart<K, V> shopCart)
        {
            GrowArr();

            int i = count;
            
            collection[i] =  shopCart;
            count++;
        }

        public bool Contains_Key(K key)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].buyer.Equals(key))
                {
                    return true;
                }
                else
                {
                    ;
                }

            }
            return false;
        }

        public bool Contains_Value(V value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].product.Equals(value))
                {
                    return true;
                }
                else
                {
                    ;
                }

            }
            return false;
        }

        public void GetCount()
        {
            Console.WriteLine("Count: {0}", count);
        }

        public IEnumerable<ShopCart<K, V>> GetCollection() 
        {
            for (int i = 0; i < collection.Length; i++)
            {
                yield return collection[i];
            }
        }

        public void Clear()
        {
            collection = new ShopCart<K, V>[0];
            count = 0;
        }
    }
}
