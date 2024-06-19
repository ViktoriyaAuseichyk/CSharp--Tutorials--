using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    internal class CollectionOfEnterprise_SecondVariant
    {
        List<Enterprise> list;

        public CollectionOfEnterprise_SecondVariant()
        {
            list = new List<Enterprise>();
        }

        public void Add(Enterprise enterprise)
        {
            list.Add(enterprise);
        }

        public void GetCount()
        {
            Console.WriteLine("List_Count: {0}", list.Count);
        }

        public void GetAllEnterprise()
        {
            foreach (var entry in list)
            {
                Console.WriteLine("{0} - {1}.bl", entry.nameOfEnterprise, entry.budgetOfEnterprise);
            }
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
