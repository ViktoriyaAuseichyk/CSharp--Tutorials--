using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class USD_Converter
    {
        private decimal eur, rub, byn;

        public USD_Converter(decimal eur, decimal rub, decimal byn)
        {
            this.eur = eur;
            this.rub = rub;
            this.byn = byn;
        }

        public decimal USDinEUR(decimal intital)
        {
            decimal result;
            return result = intital * eur;
        }
        public decimal USDinRUB(decimal intital)
        {
            decimal result;
            return result = intital * rub;
        }
        public decimal USDinBYN(decimal intital)
        {
            decimal result;
            return result = intital * byn;
        }
    }
}
