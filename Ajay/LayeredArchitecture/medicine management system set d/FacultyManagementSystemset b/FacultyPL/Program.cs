using FacultyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacultyBLL;
using FacultyException;

namespace FacultyPL
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            Console.ReadLine();
        }
        private static void PrintMenu()
        {
            string choice1;
            do
            {
                Console.WriteLine("\n***********Faculty Management System ***********");
                Console.WriteLine("1. Add Faculty");
                
                
                Console.WriteLine("2. Search Faculty");
                
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddFaculty();
                        break;


                    case 2:
                        SearchFacultyByID();
                        break;
                
                }
                Console.WriteLine("Do you want to contiue(y/n)?");
                choice1 = Console.ReadLine();
            } while ((choice1 == "y"));
            Console.Read();


        }
        public static void AddFaculty()
        {
            

            try
            {
                Faculty newFaculty = new Faculty();




                Console.WriteLine("Enter faculty ID :");
                newFaculty.FacultyId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Facuulty Name :");
                newFaculty.FacultyName = Console.ReadLine();
                Console.WriteLine("Enter DOJ :");
                newFaculty.FDoj = DateTime.Parse( Console.ReadLine());
                Console.WriteLine("Enter faculty email :");
                newFaculty.Email = Console.ReadLine();
                Console.WriteLine("Enter Faculty Phone No :");
                newFaculty.Phoneno = Console.ReadLine();




                bool facultyAdded = FacultyBLL.FacultyBLL.AddFacultyBL(newFaculty);
                if (facultyAdded)
                    Console.WriteLine("Faculty Added");
                else
                    Console.WriteLine("Faculty not Added");
            }
            catch (FacultyException.FacultyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        private static void SearchFacultyByID()
        {
            try
            {
                int searchFacultyID;
                Console.WriteLine("Enter FacultyID to Search:");
                searchFacultyID = Convert.ToInt32(Console.ReadLine());
                Faculty searchFaculty = FacultyBLL.FacultyBLL.SearchFacultyBL(searchFacultyID);
                if (searchFaculty != null)
                {
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("FacultyID\t\tName\t\tFDoj\t\tEmail\t\tPhoneno");
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", searchFaculty.FacultyId, searchFaculty.FacultyName, searchFaculty.FDoj,searchFaculty.Email,searchFaculty.Phoneno);
                    Console.WriteLine("******************************************************************************");
                }
                else
                {
                    Console.WriteLine("No faculty Details Available");
                }
            }
            catch (FacultyException.FacultyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
