using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the employee id:");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the employee name:");
            string empName =Console.ReadLine();
            Console.WriteLine("enter the gender :");
            string gender = Console.ReadLine();
            Console.WriteLine("enter the dob:");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Employee em = new Employee(empId,empName,gender,dob);

            em.DisplayDetails(); 
            Console.ReadKey();
        }
       
    }
}
