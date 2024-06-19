using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._4
{
    internal class Store
    {
        Article[] products;
        int size;

        public Store(int size)
        {
            this.size = size;
            products = new Article[size];
        }

        public Article this[int index]
        {
            get
            {
                return products[index];
            }
            set
            {
                products[index] = value;
            }
        }

        public void Show()
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].ShowArticle();
            }
        }

        public Article this[string index]
        {
            get
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].NameOfProduct == index)
                    {
                        return products[i];
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].NameOfProduct == index)
                    {
                        products[i] = value;
                    }
                }
            }
        }
    }
}

