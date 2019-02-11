using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using AMS_DAL;
using AMS_Entities;
using AMS_Exceptions;


namespace AMS_DAL
{
    public class AmazonDal
    {
        //Creating list

        public static List<Customer> customerList = new List<Customer>();

        //Adding Customer

        public bool AddCustomerDAL(Customer newCustomer)

        {

            bool customerAdded = false;

            try

            {

                customerList.Add(newCustomer);

                customerAdded = true;

            }

            catch (SystemException ex)

            {

                throw new AmazonException(ex.Message);

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return customerAdded;

        }

        //serialize data

        public bool SerializeDataDAL(Customer newCustomer)

        {

            bool customerSerialized = false;

            try

            {

                customerList.Add(newCustomer);

                customerSerialized = true;

                FileStream fs = new FileStream("CouponCodesData.txt", FileMode.Create);

                BinaryFormatter bff = new BinaryFormatter();

                bff.Serialize(fs, customerList);

                fs.Close();

            }

            catch (Exception ex)

            {

                throw new AmazonException(ex.Message);

            }

            return customerSerialized;

        }

        //deserialize data

        public List<Customer> DeserializeDataDAL()

        {

            //Reading file named "CouponCodesData.txt"

            FileStream fs = new FileStream("CouponCodesData.txt", FileMode.Open);

            BinaryFormatter bff = new BinaryFormatter();

            List<Customer> SalesmanList = bff.Deserialize(fs) as List<Customer>;

            fs.Close();

            return customerList;

        }

    }
}
