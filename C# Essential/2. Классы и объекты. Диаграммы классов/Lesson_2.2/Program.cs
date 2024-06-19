using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Label_4:

        Label_1:
            Console.WriteLine("Введите начальную валюту: 'USD', 'EUR', 'RUB', 'BYN':");
            string initialCurrency = Console.ReadLine();
            if (initialCurrency != "USD" && initialCurrency != "EUR" && initialCurrency != "RUB" && initialCurrency != "BYN")
            {
                Console.WriteLine("Валюта не найдена. Попробуйте снова.");
                goto Label_1;
            }

            Console.WriteLine();

        Label_2:
            Console.WriteLine("Введите количество денег, которое хотите конвертировать: ");
            decimal initial = Convert.ToDecimal(Console.ReadLine());
            if (initial <= 0)
            {
                Console.WriteLine("Введенное число меньше либо равно '0'.");
                goto Label_2;
            }

            Console.WriteLine();

        Label_3:
            Console.WriteLine("Введите конечную валюту: 'USD', 'EUR', 'RUB', 'BYN': ");
            string finalCurrency = Console.ReadLine();
            if (finalCurrency != "USD" && finalCurrency != "EUR" && finalCurrency != "RUB" && finalCurrency != "BYN")
            {
                Console.WriteLine("Валюта не найдена. Попробуйте снова.");
                goto Label_3;
            }

            Console.WriteLine();

            switch (initialCurrency)
            {
                case "USD":
                    {
                        USD_Converter USD_converter = new USD_Converter(0.9195m, 76.4304m, 2.852m);

                        switch (finalCurrency)
                        {
                            case "USD":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (USD / USD): {initialCurrency}.");
                                    break;
                                }
                            case "EUR":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (USD / EUR) {USD_converter.USDinEUR(initial)}.");
                                    break;
                                }
                            case "RUB":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (USD / RUB) {USD_converter.USDinRUB(initial)}.");
                                    break;
                                }
                            case "BYN":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (USD / BYN) {USD_converter.USDinBYN(initial)}.");
                                    break;
                                }
                        }
                        break;
                    }
                case "EUR":
                    {
                        EUR_Converter EUR_converter = new EUR_Converter(83.1247m, 3.1018m, 1.0876m);

                        switch (finalCurrency)
                        {
                            case "USD":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (EUR / USD): {EUR_converter.EURinUSD(initial)}.");
                                    break;
                                }
                            case "EUR":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (EUR / EUR) {initialCurrency}.");
                                    break;
                                }
                            case "RUB":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (EUR / RUB) {EUR_converter.EURinRUB(initial)}.");
                                    break;
                                }
                            case "BYN":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (EUR / BYN) {EUR_converter.EURinBYN(initial)}.");
                                    break;
                                }
                        }
                        break;
                    }
                case "RUB":
                    {
                        RUB_Converter RUB_converter = new RUB_Converter(0.0373m, 0.0131m, 0.012m);

                        switch (finalCurrency)
                        {
                            case "USD":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (RUB / USD): {RUB_converter.RUBinUSD(initial)}.");
                                    break;
                                }
                            case "EUR":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (RUB / EUR) {RUB_converter.RUBinEUR(initial)}.");
                                    break;
                                }
                            case "RUB":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (RUB / RUB) {initialCurrency}.");
                                    break;
                                }
                            case "BYN":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (RUB / BYN) {RUB_converter.RUBinBYN(initial)}.");
                                    break;
                                }
                        }
                        break;
                    }
                case "BYN":
                    {
                        BYN_Converter BYN_converter = new BYN_Converter(0.3506m, 0.3224m, 26.7989m);

                        switch (finalCurrency)
                        {
                            case "USD":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (BYN / USD): {BYN_converter.BYNinUSD(initial)}.");
                                    break;
                                }
                            case "EUR":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (BYN / EUR) {BYN_converter.BYNinEUR(initial)}.");
                                    break;
                                }
                            case "RUB":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (BYN / RUB) {BYN_converter.BYNinRUB(initial)}.");
                                    break;
                                }
                            case "BYN":
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"Result (BYN / BYN) {initialCurrency}.");
                                    break;
                                }
                        }
                        break;
                    }
            }

            Console.WriteLine();

            Console.WriteLine(new string('-', 50));

            goto Label_4;

            Console.ReadKey();


        }
    }
}
