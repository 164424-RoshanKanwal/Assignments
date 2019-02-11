using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using El_DAL;
using El_Entities;
using El_Exceptions;

namespace El_BAL
{
    public class CustomerBal
    {
        
        CustomerDal dal = new CustomerDal();
        
        public static void Serialize()
        {
            CustomerDal.SerializeData();
        }
        public static List<Customer> Deserialize()
        {
            return CustomerDal.DeserializeData();
        }

        public bool IsValid(Customer customer)
        {
            bool valid = true;
            StringBuilder sb = new StringBuilder();
            if (customer.CustomerId == null||customer.BillNo==null||customer.CustomerName==null)
            {
                valid = false;
                sb.Append(Environment.NewLine + "field should not be empty");
            }
            if (!(Regex.IsMatch(customer.MobileNo, @"^[7-9][0-9]{9}$")))
            {
                valid = false;
                sb.Append(Environment.NewLine + "student Ph No must contain 10 digits only");
            }
            if (!(Regex.IsMatch(customer.Email, @"\w+\@+\w+.com$")))
            {
                valid = false;
                sb.Append(Environment.NewLine + "Enter valid email");
            }



            //check all attributes
            if (!valid)
            {
                throw new CustomerValidationException(sb.ToString());
            }
            return valid;
        }
        public void Add(Customer customer)
        {
            try
            {
                if (IsValid(customer))
                {
                    dal.Insert(customer);
                }
            }
            catch (CustomerValidationException ex1)
            {
                throw ex1;
            }


            catch (Exception ex2)
            {
                throw ex2;
            }
        }
        
        public List<Customer> GetAll()
        {

            try
            {

                return dal.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer SearchCustomer(int custid)
        {
            Customer customerSearched = null;
            try
            {
                customerSearched = dal.SearchCustomer(custid);
                if (customerSearched == null)
                {
                    throw new CustomerNotFoundException("Customer info does not exist");

                }
            }
            catch (CustomerNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return customerSearched;
        }


    }
}
