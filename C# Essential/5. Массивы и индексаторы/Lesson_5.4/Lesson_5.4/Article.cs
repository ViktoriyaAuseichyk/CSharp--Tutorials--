using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._4
{
    internal class Article
    {
        string nameOfProduct;
        string nameOfStore;
        double costOfProduct;

        public string NameOfProduct 
        { 
            get 
            {  
                return nameOfProduct; 
            }
            set
            {
                nameOfProduct = value;
            }
        }
        
        public string NameOfStore 
        { 
            get 
            {  
                return nameOfStore; 
            }
            set
            {
                nameOfStore = value;
            }
        }
        public double CostOfProduct 
        { 
            get 
            { 
                return costOfProduct; 
            }
            set
            {
                if (value >= 0)
                {
                    costOfProduct = value;
                }
                else
                {
                    Console.WriteLine("Стоимость не может быть отрицательной");
                }
            }
        }
        public void ShowArticle()
        {
            Console.WriteLine(string.Format($"Название тавара: {this.nameOfProduct}\nНазвание магазина, в котором продается товар: " +
                $"{this.nameOfStore}\nСтоимость товара в долларах: {this.costOfProduct}"));

        }
    }
}
