using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    internal class Enterprise
    {
        public string nameOfEnterprise {  get; set; }
        public double budgetOfEnterprise { get; set; }

        public Enterprise(string nameOfEnterprise, double budgetOfEnterprise) 
        { 
            this.nameOfEnterprise = nameOfEnterprise;
            this.budgetOfEnterprise = budgetOfEnterprise;
        }
    }
}
