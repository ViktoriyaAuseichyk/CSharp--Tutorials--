using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название ('Платье', 'Блузка', 'Юбка', 'Брюки', 'Жакет'): ");
            string article = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Введите количество:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Invoice invoice = new Invoice(article, quantity);

            invoice.ArticleCost();

            invoice.CalculationArticleWithoutVAT();

            invoice.CalculationArticleWithVAT();

            invoice.Show();

            Console.ReadKey();
        }
    }
}
