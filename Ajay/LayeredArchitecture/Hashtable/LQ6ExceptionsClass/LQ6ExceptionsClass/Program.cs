using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ6ExceptionsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            void functionToValidate(double amount) {
                if (amount > 50000) {
                    throw new InvalidCreditLimitException();
                }
            }
            try {
                Customer cus = new Customer("ramya", "banglore", "banglore", "9977331155", 60000);
                functionToValidate(cus.CreditLimit);
            }
            catch (InvalidCreditLimitException e) {

                Console.WriteLine(e.Message);
            }

            void validations(double price,int id,string name) {
                if (id == 0 || id < 0)
                {
                    throw new InvalidCreditLimitException(id);
                }
                else if (price == 0 || price < 0) {
                    throw new InvalidCreditLimitException(price);
                }
                else if (name =="" ) {
                    throw new InvalidCreditLimitException(name);
                }
            }

            try {
                ProductsMock pm = new ProductsMock();
                Console.WriteLine("Enter Product Id");
                pm.productID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product name");
                pm.ProductName = (Console.ReadLine());
                Console.WriteLine("Enter Product Price");
                pm.price = double.Parse(Console.ReadLine());
                validations(pm.price,pm.productID,pm.ProductName);
            }


            catch (InvalidCreditLimitException ex) {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
