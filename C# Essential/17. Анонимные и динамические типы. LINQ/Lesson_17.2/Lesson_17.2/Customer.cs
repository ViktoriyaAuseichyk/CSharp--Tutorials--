using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._2
{
    struct Customer
    {
        string brand;
        string nameOfCustomer;
        string phoneNumber; 

        public Customer(string brand, string nameOfCustomer, string phoneNumber)
        {
            this.brand = brand;
            this.nameOfCustomer = nameOfCustomer;
            this.phoneNumber = phoneNumber;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string NameOfCustomer
        {
            get { return nameOfCustomer; }
            set { nameOfCustomer = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
