using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopCart<string, string> shopCart_1 = new ShopCart<string, string>("Nicolas", "Shorts");
            ShopCart<string, string> shopCart_2 = new ShopCart<string, string>("Milla", "Dress");
            ShopCart<string, string> shopCart_3 = new ShopCart<string, string>("Serge", "Cap");
            ShopCart<string, string> shopCart_4 = new ShopCart<string, string>("Pol", "Trousets");
            ShopCart<string, string> shopCart_5 = new ShopCart<string, string>("George", "Skirt");
            ShopCart<string, string> shopCart_6 = new ShopCart<string, string>("Piotr", "Shirt");

            Store_Collection<string, string> store = new Store_Collection<string, string>();
            
            store.Add(shopCart_1);
            store.Add(shopCart_2);
            store.Add(shopCart_3);
            store.Add(shopCart_4);
            store.Add(shopCart_5);
            store.Add(shopCart_6);
            
            store.GetCount();
            
            Console.WriteLine();
            
            IEnumerable<ShopCart<string, string>> collection = store.GetCollection();

            foreach (var item in collection)
            {
                Console.WriteLine("Buyer: {0}, Product: {1}", item.buyer, item.product);
            }

            Console.WriteLine();

            Console.WriteLine(store.Contains_Value(shopCart_3.product));

            Console.ReadKey();
            
        }
    }
}
