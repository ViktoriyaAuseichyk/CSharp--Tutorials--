using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._3
{
    internal class Word<TKey, TValue>
    {
        TKey key;
        TValue value;

        public Word()
        {
           
        }
        public Word(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
        public TKey Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }
        public TValue Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
    }

}
