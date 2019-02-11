using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ10Delegates
{
    delegate int delgatename(int first, int second);
    //delegate void deladd(int f,int s);
    // delegate int funct(int num);
    class Delegatesclass
    {

        public int firstValue { get; set; }
        public int secondvalue { get; set; }

        public int first(int number) {

            return number;
        }
        //$"EmpId: {empId}\nEmpName: {empName}\nEmpAddress: {empAddress}\nEmpHRA: {empHRA()}";
        //public void add(int a, int b) =>$"addition is : {a}"


        public int add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Result is:" + res);
            return res;
        }

        public int multiply(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("Result is:" + res);
            return res;
        }
        public int divide(int a, int b)
        {
            int res = a % b;
            Console.WriteLine("Result is:" + res);
            return res;
        }
        public int subtract(int a, int b)
        {
            int res = a - b;
            Console.WriteLine("Result is:" + res);
            return res;
        }
    }
}
