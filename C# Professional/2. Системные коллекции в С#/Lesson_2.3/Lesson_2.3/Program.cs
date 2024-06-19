using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionOfEnterprises_FirstVariant collectionOfEnterprises_FirstVariant = new CollectionOfEnterprises_FirstVariant();

            collectionOfEnterprises_FirstVariant.Add("Saudi Aramco", 2050.0);
            collectionOfEnterprises_FirstVariant.Add("Industrial and Commercial Bank of China", 203.0);
            collectionOfEnterprises_FirstVariant.Add("Alphabet", 1340.0);
            collectionOfEnterprises_FirstVariant.Add("Microsoft", 2300.0);
            collectionOfEnterprises_FirstVariant.Add("Apple", 2740.0);

            collectionOfEnterprises_FirstVariant.GetCount();

            Console.WriteLine();

            collectionOfEnterprises_FirstVariant.GetAllEnterprise();

            Console.WriteLine();

            Enterprise enterprise_1 = new Enterprise("Saudi Aramco", 2050.0);
            Enterprise enterprise_2 = new Enterprise("Industrial and Commercial Bank of China", 203.0);
            Enterprise enterprise_3 = new Enterprise("Alphabet", 1340.0);
            Enterprise enterprise_4 = new Enterprise("Microsoft", 2300.0);
            Enterprise enterprise_5 = new Enterprise("Apple", 2740.0);

            CollectionOfEnterprise_SecondVariant collectionOfEnterprise_SecondVariant = new CollectionOfEnterprise_SecondVariant();

            collectionOfEnterprise_SecondVariant.Add(enterprise_1);
            collectionOfEnterprise_SecondVariant.Add(enterprise_2);
            collectionOfEnterprise_SecondVariant.Add(enterprise_3);
            collectionOfEnterprise_SecondVariant.Add(enterprise_4);
            collectionOfEnterprise_SecondVariant.Add(enterprise_5);

            collectionOfEnterprise_SecondVariant.GetCount();

            Console.WriteLine();

            collectionOfEnterprise_SecondVariant.GetAllEnterprise();

            Console.ReadKey();
        }
    }
}
