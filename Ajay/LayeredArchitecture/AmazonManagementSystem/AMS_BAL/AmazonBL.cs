using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMS_DAL;
using AMS_Entities;
using AMS_Exceptions;

namespace AMS_BAL
{
    public class AmazonBL
    {
        private static bool ValidateCustomer(Customer customer)

        {

            StringBuilder sb = new StringBuilder();

            bool validCustomer = true;

            if (customer.CouponCode == string.Empty)

            {

                validCustomer = false;

                sb.Append(Environment.NewLine + "Coupon Code cannot be empty");

            }

            if (customer.CouponCode.Length != 8)

            {

                validCustomer = false;

                sb.Append(Environment.NewLine + "Required 8 Digit Coupon code");

            }

            if (customer.UserName.Length >= 30)

            {

                validCustomer = false;

                sb.Append(Environment.NewLine + " Username should be less than 30 characters");

            }

            if (customer.RedeemDate >= DateTime.Now)

            {

                validCustomer = false;

                sb.Append(Environment.NewLine + " Redeem date should be less than Expiry date");

            }

            if (customer.ExpiryDate >= DateTime.Now)

            {

                validCustomer = false;

                sb.Append(Environment.NewLine + " expiry date should be less than Expiry date");

            }

            if (customer.RedeemAmount <  customer.ProductPricr)

            {

                validCustomer = false;

                sb.Append(Environment.NewLine + " Redeem amount should be less than the product price");

            }

            if (customer.ProductPricr > customer.RedeemAmount)

            {

                validCustomer = true;

                sb.Append(Environment.NewLine + "Redeem amount is calculated when product price is more than 20000");

            }

            if (validCustomer == false)

                throw new AmazonException(sb.ToString());

            return validCustomer;

        }

        public static bool AddCustomerBL(Customer newCustomer)

        {

            bool customerAdded = false;

            try

            {

                if (ValidateCustomer(newCustomer))

                {

                    AmazonDal amazonDal = new AmazonDal();

                    customerAdded = amazonDal.AddCustomerDAL(newCustomer);

                }

            }

            catch (AmazonException)

            {

                throw;

            }

            return customerAdded;

        }

        public static bool SerializeDataBL(Customer customer)

        {

            bool CustomerSerialized = false;

            try

            {

                if (ValidateCustomer(customer))

                {

                    AmazonDal amazonDal = new AmazonDal();

                    CustomerSerialized = amazonDal.SerializeDataDAL(customer);

                }

            }

            catch (AmazonException e)

            {

                throw;

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return CustomerSerialized;

        }

        public static List<Customer> DeserializeDataBL()

        {

            List<Customer> CustomerList = null;

            try

            {

                AmazonDal customerDAL = new AmazonDal();

                CustomerList = customerDAL.DeserializeDataDAL();

            }

            catch (AmazonException ex)

            {

                throw ex;

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return CustomerList;

        }

        public static bool SerializeDataBL()

        {

            throw new NotImplementedException();

        }

    }
}
