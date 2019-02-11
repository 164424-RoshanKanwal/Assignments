using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Entities
{
    [Serializable]
    public class Customer
    {
        public int BillNo { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNo { get; set; }
        public double UnitsConsumed { get; set; }
        public double Rate { get; set; }
        private double Amount { get; set; }
        private double Surcharge;
        private double GrossAmount { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public double Charge()
        {
            Surcharge = 0.05 * Amount;
            return Surcharge;
        }
        public double calculate()
        {
            Amount = Rate * UnitsConsumed;
            double surCharge = Charge();
            GrossAmount = Amount + surCharge;
            return GrossAmount;
        }

        public override string ToString()
        {
            return $"customerid:{CustomerId},customername:{CustomerName},address:{Address},email:{Email},gross amount:{calculate()}";
        }
    }
}
