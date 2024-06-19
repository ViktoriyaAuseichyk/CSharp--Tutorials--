using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class BYN_Converter
    {
        private decimal usd, eur, rub;

        public BYN_Converter(decimal usd, decimal eur, decimal rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public decimal BYNinUSD(decimal intital)
        {
            decimal result;
            return result = intital * usd;
        }
        public decimal BYNinEUR(decimal intital)
        {
            decimal result;
            return result = intital * eur;
        }
        public decimal BYNinRUB(decimal intital)
        {
            decimal result;
            return result = intital * rub;
        }

        /*public decimal USDinBYN(decimal intital)
        {
            decimal result;
            return result = intital / usd;
        }
        public decimal EURinBYN(decimal intital)
        {
            decimal result;
            return result = intital / eur;
        }
        public decimal RUBinBYN(decimal intital)
        {
            decimal result;
            return result = intital / rub;
        }*/
    }
}
