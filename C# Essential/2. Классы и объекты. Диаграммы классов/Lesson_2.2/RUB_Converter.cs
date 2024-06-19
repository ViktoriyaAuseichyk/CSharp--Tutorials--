using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class RUB_Converter
    {
        private decimal byn, usd, eur;

        public RUB_Converter(decimal byn, decimal usd, decimal eur)
        {
            this.byn = byn;
            this.usd = usd;
            this.eur = eur;
        }

        public decimal RUBinBYN(decimal intital)
        {
            decimal result;
            return result = intital * byn;
        }
        public decimal RUBinUSD(decimal intital)
        {
            decimal result;
            return result = intital * usd;
        }
        public decimal RUBinEUR(decimal intital)
        {
            decimal result;
            return result = intital * eur;
        }
    }
}
