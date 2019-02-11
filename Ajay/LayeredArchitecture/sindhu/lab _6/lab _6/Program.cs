using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab__6
{
    class Program
    { 
        static void Display(List<Customer> cus)
        {
            foreach (var item in cus)
            {
                Console.WriteLine(item.ToString()); 
            }
        }
        static void Main(string[] args)
        {
            List<Customer> cus = new List<Customer>();
            char choice;
            do
            {
                Console.WriteLine("enter choice '1' for adding '2' for displaying");
                int ch = int.Parse(Console.ReadLine());
                switch (ch) {
                    case 1:
                                                                                                                 
                        Console.WriteLine("enter your deails  CustomerId,CustomerNam,Address,City,Phone,CreditLimit");
                        try
                        {
                            Customer cust = new Customer(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),
                                                            Console.ReadLine(), int.Parse(Console.ReadLine()));

                            if (cust.CreditLimit > 50000 || cust.CreditLimit < 0)
                            {
                                //Customer a = new Customer();
                                throw new Exceptions(Customer.sb);
                            }
                            else
                            {
                                cus.Add(cust);
                            }
                        }
                        catch (Exceptions ex1)
                        {
                            Console.WriteLine(ex1);
                        }
                        break;
                    case 2:Display(cus);
                        break;
                    default: Console.WriteLine("You entered the wrong choice:");
                        break;
                                               
                }

                Console.WriteLine("Do you want to Continue or not Y");
                choice = char.Parse(Console.ReadLine());
                 
            } while (choice=='y'||choice=='Y');
            
            Console.ReadKey();
           
  
           
        }
    }
}
