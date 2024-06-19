using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    internal class EUR_Converter
    {
        private decimal rub, byn, usd;

        public EUR_Converter(decimal rub, decimal byn, decimal usd)
        {
            this.rub = rub;
            this.byn = byn;
            this.usd = usd;
        }

        public decimal EURinRUB(decimal intital)
        {
            decimal result;
            return result = intital * rub;
        }
        public decimal EURinBYN(decimal intital)
        {
            decimal result;
            return result = intital * byn;
        }
        public decimal EURinUSD(decimal intital)
        {
            decimal result;
            return result = intital * usd;
        }
    }
}
