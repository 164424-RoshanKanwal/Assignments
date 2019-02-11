using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{

        public class CustomerInfo

        {

            //Defining Field

            public int priceTogetRedeemAmount = 20000;

            //Defining AutoImplemented Property

            public string CouponCode { get; set; }

            public string UserName { get; set; }

            public DateTime RedeemDate { get; set; }

            public DateTime ExpiryDate { get; set; }

            public int RedeemAmount { get; set; }

            public string ProductCode { get; set; }

            public double ProductPrice { get; set; }

        }

}
