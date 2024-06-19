using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите общее количество товаров:");
            int amountOfproduct = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Store store = new Store(amountOfproduct);


            for (int i = 0; i < amountOfproduct; i++)
            {
                Article article = new Article();
                Console.WriteLine("Введите название тавара:");
                article.NameOfProduct = Console.ReadLine();
                Console.WriteLine("Введите  название магазина, в котором продается товар:");
                article.NameOfStore = Console.ReadLine();
                Console.WriteLine("Введите стоимость товара в долларах:");
                article.CostOfProduct = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                store[i] = article;
            }

            Console.WriteLine();

            store.Show();

            Console.WriteLine();

            Console.WriteLine("Введите название тавара, информацию о котором вы хотите узнать:");
            string userInput = Console.ReadLine();

            Console.WriteLine();

            Article temp = store[userInput];

            if (temp != null)
            {
                store[userInput].ShowArticle();
            }
            else
            {
                Console.WriteLine("Товар не найден!");
            }

            Console.ReadKey();

        }
    }
}
