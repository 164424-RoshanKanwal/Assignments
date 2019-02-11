using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using El_Exceptions;
using El_Entities;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace El_DAL
{
    public class CustomerDal
    {

        public static List<Customer> custs = new List<Customer>();

        public void Insert(Customer customer)//customer refrences is created 
        {
            try
            {
                custs.Add(customer);
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
        }

        

        public List<Customer> SelectAll()
        {
            try
            {
                Console.WriteLine();
                return custs;
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
        }
        public Customer SearchCustomer(int customerid)
        {
            try
            {
                Customer searchedCustomer = null;
                foreach (var customer in custs)
                {
                    if (customer.CustomerId==customerid)
                    {
                        searchedCustomer = customer;
                    }
                }
                return searchedCustomer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void SerializeData()
        {
            FileStream stream;
            try
            {
               
                stream = new FileStream("customer.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream,custs);
                stream.Close();
            }
            catch (IOException e)
            {
                throw e;
            }

        }
        public static List<Customer> DeserializeData()
        {
            FileStream stream = new FileStream("customer.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            custs = formatter.Deserialize(stream) as List<Customer>;
            stream.Close();

            return custs;
        }




    }
}
