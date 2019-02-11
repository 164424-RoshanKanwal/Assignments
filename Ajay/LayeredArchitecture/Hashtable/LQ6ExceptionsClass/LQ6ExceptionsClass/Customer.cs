using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ6ExceptionsClass
{
    class Customer
    {
        static int id = 1;
        public static int CustomerId { get; set; }
        public string Customer_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public double CreditLimit { get; set; }

        Customer() {
            CustomerId = id++;
        }
        public Customer(string name,string add,string city,string phone, double crlmt) {
            Customer_Name = name;
            Address = add;
            City = city;
            Phone = phone;
            CreditLimit = crlmt;
        }
    }
}
