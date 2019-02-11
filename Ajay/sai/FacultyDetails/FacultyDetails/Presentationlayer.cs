using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMS_BAL;
using FMS_Entities;
using FMS_Exceptions;
using System.IO;

//faculty id is not auto incremented




namespace FacultyDetails
{
    class Presentationlayer
    {
        
            static Faculty_BAL objValidation;
      
            public static void AddFaculty()
            {
                try
                {
                    objValidation = new Faculty_BAL();
                    FacultyEntity empNew = new FacultyEntity();
                    
                    Console.WriteLine("Enter faculty Id :");

                     
                   
                empNew.FacultyId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter faculty Name :");
                    empNew. FacultyName = Console.ReadLine();
                    Console.WriteLine("Enter faculty DOJ :");
                    empNew.DOJ = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter faculty email :");
                    empNew.Email = Console.ReadLine();
                    Console.WriteLine("Enter faculty phone :");
                    empNew.Phone = Int64.Parse(Console.ReadLine());

                    if (objValidation.AddFacultyBAL(empNew))
                        Console.WriteLine("faculty Record added successfully");

                }
                catch (FacultyException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            private static void SearchFaculty()
            {
                FacultyEntity empSearch = null;
                try
                {
                    Console.WriteLine("Enter faculty phone no to be searched:");
                    long? phone = Int64.Parse(Console.ReadLine());

                    empSearch = objValidation.SearchFacultyBAL(phone);
                    if (empSearch != null)
                    {
                        Console.WriteLine("Searched Employee Details:");
                        Console.WriteLine("Employee id: {0}", empSearch.FacultyId);
                        Console.WriteLine("Employee Name: {0}", empSearch.FacultyName);
                        Console.WriteLine("Employee email: {0}", empSearch.Email);
                        Console.WriteLine("Employee Contact: {0}", empSearch.Phone);
                        Console.WriteLine("Employee DOJ : {0}", empSearch.DOJ.ToShortDateString());
                    }
                }
                catch (FacultyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        public static void PrintMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Faculty Management System Menu");
            Console.WriteLine("Press 1 To Add New Employee");
            Console.WriteLine("Press 2 To Search All Employees");
            Console.WriteLine("Press 3 To Exit");
            Console.WriteLine("============================================");

        }
        static void Main(string[] args)
        {
            byte choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter Your Choice:");
                bool chkChoice;

                chkChoice = byte.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input "); }
                switch (choice)
                {
                    case 1:
                        AddFaculty();
                        break;
                    case 2:
                        SearchFaculty();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 3);

            Console.ReadKey();




        }
    }
}
