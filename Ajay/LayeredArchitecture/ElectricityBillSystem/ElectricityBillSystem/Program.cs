using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using El_Entities;
using El_Exceptions;
using El_DAL;
using El_BAL;

namespace ElectricityBillSystem
{
    class Program
    {
        
        
            static void AddCustomer(CustomerBal bal)
            {
                Customer customer = new Customer();

                try
                {
                    Console.WriteLine("Bill no:");
                    customer.BillNo= int.Parse(Console.ReadLine());
                    Console.WriteLine("Name:");
                    customer.CustomerName = Console.ReadLine();
                    Console.WriteLine("Customer id");//cursor has to wait in same line therefore only write
                    customer.CustomerId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mobile Number");
                    customer.MobileNo =(Console.ReadLine());
                    Console.WriteLine("Email:");
                    customer.Email = Console.ReadLine();
                    Console.WriteLine("Units consumed");
                    customer.UnitsConsumed= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Rate:");
                    customer.Rate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ADDRESS");
                    customer.Address = Console.ReadLine();
                    bal.Add(customer);
                    Console.WriteLine("customer inserted succesfully");


                }
                catch (CustomerValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
               
            }
            static void DisplayAllDetails(CustomerBal bal)
            {
                try
                {
                   
                    List<Customer> allCust = bal.GetAll();
                    foreach (var item in allCust)
                    {
                        Console.WriteLine(item);//tostring method is called internally when u call Write Line  
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            static void SearchCustomer(CustomerBal bal)
            {
                int customerID;
                Customer searchCustomer;
                try
                {
                    Console.Write("Enter customer ID for search");
                    customerID = Convert.ToInt32(Console.ReadLine());
                    searchCustomer = bal.SearchCustomer(custid: customerID);
                    if (searchCustomer != null)
                    {
                        Console.WriteLine("customer id:" + searchCustomer.CustomerId);
                        Console.WriteLine("customer name:" + searchCustomer.CustomerName);
                        Console.WriteLine("customer  email :" + searchCustomer.Email);
                        Console.WriteLine("customer address:" + searchCustomer.Address);
                        Console.WriteLine("customer grossamount:" + searchCustomer.calculate());
                    }
                    else
                    {
                        throw new CustomerNotFoundException("customer not found");
                    }
                }
                catch (CustomerNotFoundException s)
                {
                    Console.WriteLine(s.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void Main(string[] args)
            {
                CustomerBal bal = new CustomerBal();
                Customer student = new Customer();
                char choice;
                do
                {
                    Console.WriteLine("\n***********customer Management System ***********");
                    Console.WriteLine("1. Add customer");
                    Console.WriteLine("2. Display customer");
                    Console.WriteLine("3. SEARCH");
                    Console.WriteLine("4. serialize");
                    Console.WriteLine("5. deserialize");
                    Console.WriteLine("6. quit");
                    int num = Int32.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            AddCustomer(bal);
                            break;
                        case 2:
                            DisplayAllDetails(bal);
                            break;
                        case 3:
                            SearchCustomer(bal);
                            break;

                    case 4:
                       CustomerBal.Serialize();
                        break;

                    case 5:
                       CustomerBal.Deserialize();
                        break;
                    default:
                        //System.Environment.Exit(1);
                        Console.WriteLine("entered choice is wrong");
                            break;


                    }


                    Console.WriteLine("Do you want to contiue (y/n)?");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'y');


                Console.ReadKey();

            }


        
    }
}
