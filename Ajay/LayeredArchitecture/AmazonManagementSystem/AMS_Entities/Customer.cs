using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS_Entities
{
    [Serializable]
    public class Customer
    {
        
        public string CouponCode { get; set; }

        public string UserName { get; set; }

        public DateTime RedeemDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int RedeemAmount { get; set; }

        public string ProductCode { get; set; }

        public int ProductPricr { get; set; }

    }

}

　

　


   