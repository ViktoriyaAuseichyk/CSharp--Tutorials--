using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    internal class Invoice
    {
        private readonly int account = 0;
        private readonly string costomer = null;
        private readonly string provider = null;

        /*public Invoise(int account, string costomer, string provider)
        {
        this.account = account;
        this.costomer = costomer;
        this.provider = provider;
        }*/

        private string article;
        private int quantity;
        private int cost;
        private readonly int VAT = 25;

        private int costWithoutVAT;
        private int costWithVAT;

        //public string Article { get; set; }
        //public string Quantity { get; set; }

        public Invoice(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public int ArticleCost()
        {
            switch (this.article)
            {
                case "Платье":
                    {
                        this.cost = 250;
                        break;
                    }
                case "Блузка":
                    {
                        this.cost = 100;
                        break;
                    }
                case "Юбка":
                    {
                        this.cost = 120;
                        break;
                    }
                case "Брюки":
                    {
                        this.cost = 150;
                        break;
                    }
                case "Жакет":
                    {
                        this.cost = 350;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }
            }

            return this.cost;
        }

        public int CalculationArticleWithoutVAT()
        {
            this.costWithoutVAT = this.cost * this.quantity;
            return this.costWithoutVAT;
        }

        public int CalculationArticleWithVAT()
        {
            int VAT = this.costWithoutVAT * this.VAT / 100;
            this.costWithVAT = this.costWithoutVAT + VAT;
            return this.costWithVAT;
        }

        public void Show()
        {
            Console.WriteLine($"Стоимость без НДС: {this.costWithoutVAT}");
            
            Console.WriteLine();

            Console.WriteLine($"Стоимость c НДС: {this.costWithVAT}");
        }
    }
}
