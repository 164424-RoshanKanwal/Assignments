using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ10Delegates
{
    //delegate int delgatenames(int first, int second);
    delegate void delgatenew(int f, int s);


    class ExpressionBodied
    {
        public int firstValue { get; set; }
        public int secondvalue { get; set; }

        public int first(int number) => number = number;
       
        //$"EmpId: {empId}\nEmpName: {empName}\nEmpAddress: {empAddress}\nEmpHRA: {empHRA()}";
        //Action<int> sqrAction = (n) => { Console.WriteLine("Action Square: " + (n * n)); };

        public void add(int a, int b) => Console.WriteLine("adition :"+(a+b));
        public void multiply(int a, int b) => Console.WriteLine("multiply :" + (a * b));

        //public int add(int a, int b)
        //{
        //    int res = a + b;
        //    Console.WriteLine("Result is:" + res);
        //    return res;
        //}

        //public int multiply(int a, int b)
        //{
        //    int res = a * b;
        //    Console.WriteLine("Result is:" + res);
        //    return res;
        //}
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

        public static void Main(string[] args)
        {
            ExpressionBodied eb = new ExpressionBodied();
            delgatenew adss,multiply;
            adss = eb.add;
            multiply = eb.multiply;
            Console.WriteLine("enter the values to calculate");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
          // Console.WriteLine
            adss(first, second);
            Console.WriteLine("enter the values to calculate");
            int firs = int.Parse(Console.ReadLine());
            int secon = int.Parse(Console.ReadLine());
            multiply(firs, secon);
            Console.ReadKey();
        }
    }

   
}
