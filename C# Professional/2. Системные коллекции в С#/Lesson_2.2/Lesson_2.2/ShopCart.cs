using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class ShopCart<K, V>
    {
        public K buyer { get; set; }
        public V product { get; set; }  
        public ShopCart(K buyer, V product) 
        { 
            this.buyer = buyer;
            this.product = product;
        }

    }
}
