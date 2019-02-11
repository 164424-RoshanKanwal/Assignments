using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Employee
    {
        public int EmpId{ get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public Employee()
        {

        }
        public Employee(int empId, string empName, string gender, DateTime dob)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.Gender = gender;
            this.DOB = dob;
        }
        public void DisplayDetails()
        {
            Console.WriteLine ($"empId: {EmpId} empName:{EmpName} gender:{Gender} dob:{DOB}");
        }
    }
    
}
