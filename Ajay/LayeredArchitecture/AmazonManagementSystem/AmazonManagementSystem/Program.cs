using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMS_BAL;
using AMS_DAL;
using AMS_Entities;
using AMS_Exceptions;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;



namespace AmazonManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();//calling function

        }

        private static void PrintMenu()

        {

            string choice1;//dsiplaying menu

            do

            {

                Console.WriteLine("\n------------------------- Amazon India Offers -------------------------------------");

                Console.WriteLine("\n***********Customer Data Management System ***********");

                Console.WriteLine("1. Add details of particular Customer");

                Console.WriteLine("2. Serialize the data");

                Console.WriteLine("3. Deserialize the data");

                Console.WriteLine("Enter your choice");

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)

                {

                    case 1:

                        AddCustomer();

                        break;

                    case 2:

                        SerializeData();

                        break;

                    case 3:

                        DeserializeData();

                        break;

                    default:

                        Console.WriteLine("Invalid choice");

                        break;

                }

                Console.WriteLine("Do you want to contiue(y/n)?");

                choice1 = Console.ReadLine();

            } while ((choice1 == "y"));

            Console.Read();

        }

        //Add performance

        private static void AddCustomer()

        {

            try

            {

                Customer newCustomer = new Customer();

                Console.WriteLine("Enter Coupon code :");

                newCustomer.CouponCode = Console.ReadLine();

                Console.WriteLine("Enter user Name :");

                newCustomer.UserName = Console.ReadLine();

                Console.WriteLine("Enter Redeem date :");

                newCustomer.RedeemDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("enter expiry date");

                newCustomer.ExpiryDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter redeem amount");

                newCustomer.RedeemAmount = Int32.Parse(Console.ReadLine());

                Console.WriteLine("product code");

                newCustomer.ProductCode = Console.ReadLine();

                Console.WriteLine("Enter price");

                newCustomer.ProductPricr = Int32.Parse(Console.ReadLine());

                bool customerAdded = AmazonBL.AddCustomerBL(newCustomer);

                if (customerAdded)

                    Console.WriteLine("Customer Added");

                else

                    Console.WriteLine("customer not Added");

            }

            catch (AmazonException ex)

            {

                Console.WriteLine(ex.Message);

            }

        }





        //Perform serialization on the data

        public static void SerializeData()

        {

            try

            {

                Customer newCustomer = new Customer();

                Console.WriteLine("Enter Coupon Code :");

                newCustomer.CouponCode = Console.ReadLine();

                Console.WriteLine("Enter userName:");

                newCustomer.UserName = Console.ReadLine();

                Console.WriteLine("Enter redeem date:");

                newCustomer.RedeemDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter expiry date :");

                newCustomer.ExpiryDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter redeem amount :");

                newCustomer.RedeemAmount = Convert.ToInt32(Console.ReadLine());

                bool CustomerSerialized = AmazonBL.SerializeDataBL(newCustomer);

                if (CustomerSerialized)

                    Console.WriteLine("Customer Serialized");

                else

                    Console.WriteLine("customer not Serialized");

            }

            catch (AmazonException ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        //Perform Deserialization on the data

        private static void DeserializeData()

        {

            try

            {

                List<Customer> CustomerList = AmazonBL.DeserializeDataBL();

                if (CustomerList != null && CustomerList.Count > 0) 

                {

                    Console.WriteLine("******************************************************************************");

                    Console.WriteLine("Salesman Code\t\tName\t\tRegion");

                    Console.WriteLine("******************************************************************************");

                    foreach (Customer Customer in CustomerList)

                    {

                        Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}", Customer.CouponCode, Customer.UserName, Customer.RedeemDate, Customer.ExpiryDate, Customer.RedeemAmount, Customer.ProductCode, Customer.ProductPricr);

                    }

                    Console.WriteLine("******************************************************************************");

                }

                else

                {

                    Console.WriteLine("No Serialized Data Available");

                }

            }

            catch (AmazonException ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

    }

}

　


