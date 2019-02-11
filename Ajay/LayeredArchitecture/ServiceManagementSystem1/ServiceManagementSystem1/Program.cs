using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerMS_BAL;
using SerMS_Entities;
using SerMS_Exception;


namespace ServiceManagementSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
          

                int flag;

                char option;

                do

                {

                    Console.WriteLine("enter the flag");

                    flag = Int32.Parse(Console.ReadLine());

                    switch (flag)

                    {

                        case 1:

                            {

                                AddService();

                                break;

                            }

                        case 2:

                            {

                                DisplayAllService();

                                break;

                            }

                        case 3:

                            {

                                SearchServiceByVechicleNo();

                                break;

                            }

                        default:

                            {

                                Console.WriteLine("Enter appropriate flag");

                                break;

                            }

                    }

                    Console.WriteLine("Do you want to continue press 'y' else 'n'");

                    option = char.Parse(Console.ReadLine());

                } while (option == 'y');

            }

            private static void PrintMenu()

            {

                Console.WriteLine("\n *** Service Maintenance Tracker Menu ***");

                Console.WriteLine("1. Add Service");

                Console.WriteLine("2. Display all service");

                Console.WriteLine("3. Search by vechicle number");

                Console.WriteLine("4. Exit");

                Console.WriteLine("****");

            }

            private static void AddService()

            {

                try

                {

                    Service newService = new Service();

                    Console.WriteLine("enter the vechicle num");

                    newService.Vechicleno = (Console.ReadLine());

                    Console.WriteLine("enter the Owner name");

                    newService.OwnerName = Console.ReadLine();

                    Console.WriteLine("enter the vechicle type");

                    newService.VechicleType = Console.ReadLine();

                   

                    Console.WriteLine("enter centre details");

                    newService.CentreDetails = Console.ReadLine();

                    bool serviceAdded = ServiceBAL.AddServiceBL(newService);

                    if (serviceAdded)

                    {

                        Console.WriteLine("Service Added");

                    }

                    else

                    {

                        Console.WriteLine("Service not added");

                    }

                }

                catch (ServiceEntryValidationException ex)

                {

                    Console.WriteLine(ex.Message);

                }

            }

            private static void DisplayAllService()

            {

                try

                {
                    
                    List<Service> serviceList = ServiceBAL.DisplayServiceBL();

                    if (serviceList != null)

                    {

                        //Console.WriteLine("****");
                        

                        //Console.WriteLine("Vechicle Num \t \t Owner Name \t\t Vechicle type \t\t Service Centre Details\t\t");

                        //Console.WriteLine("****");

                        foreach (Service service in serviceList)

                        {
                        //Console.WriteLine("Ha");

                        //Console.WriteLine("{0} +\t \t {1} +\t \t {2} +\t\t {3}+ \t\t {4}", service.Vechicleno, service.OwnerName, service.VechicleType, service.CentreDetails);
                        Console.WriteLine(service.ToString());
                        }

                        /*onsole.WriteLine("*****");*/

                    }

                    else

                    {

                        Console.WriteLine("No Service Details Available");

                    }

                }

                catch (SystemException ex)

                {

                    Console.WriteLine(ex.Message);

                }

                catch (ServiceEntryValidationException ex)

                {

                    Console.WriteLine(ex.Message);

                }

            }

            private static void SearchServiceByVechicleNo()

            {

                try

                {

                    string searchService;

                    Console.WriteLine("enter vechicle num by search");

                    searchService = (Console.ReadLine());

                    Service searchServicenum = ServiceBAL.SearchServiceBL(searchService);

                    if (searchServicenum != null)

                    {

                        Console.WriteLine("******");

                        Console.WriteLine("Vechicle Num \t \t Owner Name \t \t Vechicle type \t\t Center Details");

                        Console.WriteLine("{0} \t \t{1} \t \t {2}", searchService, searchServicenum.OwnerName, searchServicenum.VechicleType, searchServicenum.CentreDetails);

                        Console.WriteLine("****");

                    }

                    else

                    {

                        Console.WriteLine("no service available");

                    }

                }

                catch (ServiceEntryValidationException ex)

                {

                    Console.WriteLine(ex.Message);

                }
            }
    }
}
