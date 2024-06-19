using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace Lesson_2._3
{
    public class InsensitiveComparer : IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }

        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }
    }

    internal class CollectionOfEnterprises_FirstVariant
    {
        string nameOfEnterprise { get; set; }
        double budgetOfEnterprise { get; set; }

        OrderedDictionary dictionary;

        public CollectionOfEnterprises_FirstVariant()
        {
            dictionary = new OrderedDictionary(new InsensitiveComparer());
        }

        public void Add(string nameOfEnterprise, double budgetOfEnterprise)
        {
            this.nameOfEnterprise = nameOfEnterprise;
            this.budgetOfEnterprise = budgetOfEnterprise;

            dictionary.Add(this.nameOfEnterprise, this.budgetOfEnterprise);
            
        }

        public void GetAllEnterprise()
        {
            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine("{0} - {1}.bl", entry.Key, entry.Value);
            }
        }

        public void GetCount()
        {
            Console.WriteLine("Dictionary_Count: {0}", dictionary.Count); 
        }

        public void Clear()
        {
            dictionary.Clear();
        }

       
    }
}
