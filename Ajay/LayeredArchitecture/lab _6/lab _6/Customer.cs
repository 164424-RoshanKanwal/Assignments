using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab__6
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int CreditLimit { get; set; }
        public static string sb = "Credit card limit should be in limits(0,50000)";
        public Customer()
        {

        }
        public Customer(int CustomerId, string CustomerName, string Address, string City, string Phone, int CreditLimit)
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            this.Address = Address;
            this.Phone = Phone;
            this.City = City;
          
                this.CreditLimit = CreditLimit;
            
        }
        public override string ToString()
        {
            return $"CustomerID={CustomerId},CustomerName={CustomerName},Address={Address},City={City},Phone={Phone},CreditLimit={CreditLimit}";
        }
    }

}
