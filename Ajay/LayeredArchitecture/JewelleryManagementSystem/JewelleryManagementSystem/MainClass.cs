using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Exceptions;
using BAL;



namespace JewelleryManagementSystem
{
    class MainClass
    {
        
        

        /// <summary>
        /// Purpose: This class is used for the working functionalities and also the main function, from which, the user will input data and run the whole program, to store, retrieve and save in file and fetch from file.
        /// Author Name: IGate
        /// Created On: 10/1/2015
        /// </summary>
        class GuestPresentation
        {
            //Method to Add a Customer and calling the validation methods from the CustomerBal class
            public static void AddSalesMan()
            {
                try
                {
                    //Creating object of Customer class to access the values being stored through the properties
                   JMS_Entities  newSalesMan = new JMS_Entities();

                    //User Inputs
                    //Console.Write("Enter SalesManCode ID : ");
                    //newSalesMan.SalesManCode = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter SalesManName  : ");
                    newSalesMan.SalesManName = Console.ReadLine();
                    Console.Write(" Enter the Region: (1- East, 2- West, 3- North, 4-south) ");
                    newSalesMan.Region2 = (Region)Enum.Parse(typeof(Region), Console.ReadLine());
                    Console.Write("Enter TargetSet  (0% - 100%): ");
                    newSalesMan.TargetSet = float.Parse(Console.ReadLine());
                    Console.Write("Enter Actualtarget 0% - 100% : ");
                    newSalesMan.ActualSales = float.Parse(Console.ReadLine());

                    //Checking if all validations by calling the CustomerBL class to use it's function AND using are true AND using NAMED ARGUMENTS
                    bool SalesManAdded = JMS_BAL.AddSalesMan(newSalesMan);
                    if (SalesManAdded == true)
                        Console.WriteLine("SalesMan Added Successfully!");
                    else
                        throw new JMS_Exceptions("SalesMan not added! Please try again following the validations mentioned!");
                    JMS_BAL.SerializeData();
                }
                //Catching user defined exception
                catch (JMS_Exceptions p)
                {
                    Console.WriteLine(p.Message);
                }

                //Catching System exception
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static void SearchSalesMan()
            {
                int SalesManCode;
                JMS_Entities searchedSalesMan;

                try
                {
                    Console.Write("Enter  code for search : ");
                    SalesManCode = Convert.ToInt32(Console.ReadLine());

                    //Checking if all validations by calling the customerBiz class to use it's function AND using are true AND using NAMED ARGUMENTS
                    searchedSalesMan = JMS_BAL.SearchSalesMan(SalesManCode: SalesManCode);

                    if (searchedSalesMan != null)
                    {
                        Console.WriteLine("SalesMan   : " + searchedSalesMan.SalesManCode);
                        Console.WriteLine("Guest Name : " + searchedSalesMan.SalesManName);
                        Console.WriteLine("SalesManRegion: " + searchedSalesMan.Region2);

                    }
                    else
                    {
                        throw new JMS_Exceptions("SalesMan not found!");
                    }
                }
                //Catching User defined exception
                catch (JMS_Exceptions p)
                {
                    Console.WriteLine(p.Message);
                }
                //Catching System exception
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            //Method to Update a Customer and calling the validation methods from the CustomerBiz class
            public static void UpdateSalesMan()
            {
                JMS_Entities SalesManToBeUpdated = new JMS_Entities();
                bool SalesManUpdated;

                try
                {

                    //User inputs
                    Console.Write("Enter SalesManCode for which you would like to update the record : ");
                    SalesManToBeUpdated.SalesManCode = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter SalesManName to be updated : ");
                    SalesManToBeUpdated.SalesManName = Console.ReadLine();
                    Console.Write("Enter SalesMan Region to be updated : ");
                    SalesManToBeUpdated.Region2 = (Region)Enum.Parse(typeof(Region), Console.ReadLine());
                    //Checking if all validations by calling the customerBL class to use it's function AND using are true AND using NAMED ARGUMENTS
                    SalesManUpdated = JMS_BAL.UpdateSalesMan(SalesManToBeUpdated);

                    //Checking if validations are true or not
                    if (SalesManUpdated == true)
                        Console.WriteLine("SalesMan Updated Successfully!");
                    else
                        throw new JMS_Exceptions("SalesMan not updated!");
                }
                //Catching User defined exception
                catch (JMS_Exceptions p)
                {
                    Console.WriteLine(p.Message);
                }
                //Catching System exception
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static void DisplaySalesMan()
            {
                //Creating List object to store n number of inputs from the user
                List<JMS_Entities> SMS = new List<JMS_Entities>();

                try
                {
                    SMS = JMS_BAL.ReturnSalesManInformation1();
                    if (SMS.Count > 0)
                    {
                        Console.WriteLine("*******************All SalesMan Detail****************");
                        Console.WriteLine("SalesManCode     -    SalesManName   -    SalesManRegion   ");
                        Console.WriteLine("--------------------------------------------------------");
                        foreach (JMS_Entities p in SMS)
                        {
                            Console.WriteLine(p.SalesManCode + "\t\t\t" + p.SalesManName + "\t\t\t" + p.Region2);
                        }
                    }
                    else
                    {
                        throw new JMS_Exceptions("There are no records!");
                    }
                }
                //Catching User defined exception
                catch (JMS_Exceptions p)
                {
                    Console.WriteLine(p.Message);
                }
                //Catching System exception
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static void DeleteSalesMan()
            {
                int SalesManCode;
                bool SalesManDeleted;

                try
                {
                    //User Inputs
                    Console.Write("Enter the SalesManCode to be deleted : ");
                    SalesManCode = Convert.ToInt32(Console.ReadLine());
                    //Calling the customerBL class to use it's function AND using NAMED ARGUMENTS
                    SalesManDeleted = JMS_BAL.DeleteSalesMan(SalesManCode);

                    if (SalesManDeleted == true)
                        Console.WriteLine("SalesMan Deleted Successfully!");
                    else
                        throw new JMS_Exceptions("SalesMan not deleted!");
                }
                //Catching User defined exception
                catch (JMS_Exceptions p)
                {
                    Console.WriteLine(p.Message);
                }
                //Catching System exception
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            //public static void AddRecordsToFile()
            //{
            //    JMS_BAL.SerializeData();
            //    Console.WriteLine("Records Serialized and Successfully added to the file");
            //    Console.WriteLine();
            //}

            //private static void ListAllSalesMan()
            //{
            //    List<JMS_Entities> SalesMen = JMS_BAL.ReturnSalesManInformation1();
            //    foreach (JMS_Entities JMS_Entities in SalesMen)
            //    {
            //        Console.WriteLine("SalesManCode is : {0}", JMS_Entities.SalesManCode);
            //        Console.WriteLine("SalesManName is : {0}", JMS_Entities.SalesManName);
            //        Console.WriteLine("Region is : {0}", JMS_Entities.Region2);

            //    }
            //}

            //Method to print menu to the user for user's choice
            public static void PrintMenu()
            {
                Console.WriteLine();
                Console.WriteLine("*************Guest Menu*************");
                Console.WriteLine("1.  Add SalesMan");
                
                Console.WriteLine("2.  Search SalesMan ");
                Console.WriteLine("3.  Update SalesMen ");

                Console.WriteLine("4. Display SalesMen");
                Console.WriteLine("5. Delete SalesMan");
              
                Console.WriteLine("6.  Exit");
                Console.WriteLine("**************************************");
            }

            //Main method to call all the functions as per the need of the user
            static void Main(string[] args)
            {
                int choice;

                // Attribute[] arr = Attribute.GetCustomAttributes(typeof(Guest), typeof(GuestCategoryAttribute));


                do
                {
                    //Calling PrintMenu() function to print menu
                    PrintMenu();

                    bool validchoice;
                    Console.Write("Enter your choice please : ");
                    validchoice = Int32.TryParse(Console.ReadLine(), out choice);

                    //Switch case to allow the user choose the option as per choice
                    if (!validchoice)
                        Console.WriteLine("Enter the Choice from 1-8");
                    else
                    {
                        switch (choice)
                        {
                            case 1:
                                AddSalesMan();
                                break;
                            
                            case 2:
                                SearchSalesMan();
                                break;
                            case 3:
                                UpdateSalesMan();
                                break;
                            //case 4:
                            //    AddRecordsToFile();
                            //    break;
                            //case 5:
                            //    Deserialize();
                            //    break;
                                    case 4:
                               DisplaySalesMan ();
                                break;
                            case 5:DeleteSalesMan();
                                break;

                            case 6: return;
                            default:
                                Console.WriteLine("Invalid Choice!");
                                break;
                        }
                        //While loop to ensure the program runs as per user's choice, unit he/she presses exit
                    }
                } while (choice != 6);
            }

        }
    }


}
    


