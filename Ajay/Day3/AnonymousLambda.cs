using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates Anonymous Method and Lambda Expression
 */ 

namespace DelegateEvents03
{
  
    public class usingFuncAction
    {
        static void Main(string[] args)
        {
            
            //using Action<> 
            //Use Action for invoking the Functions/Anonymous Methods/Lambda Expressions that have no return type

            Action<int> sqrAction = (n) => { Console.WriteLine("Action Square: "+(n * n)); };

            sqrAction(5);

            //using Func<> : Func<inputparam1,inputparam2,..., outputparam>
            //Use Func for invoking the Functions/Anonymous Methods/Lambda Expressions that have return type

            Func<int,int,int> addfun= delegate(int n1,int n2)
            { return (n1+n2);};
            int firstnumber=10;
            int secondnumber=20;
            //Invoking the anonymous method using Func.Invoke method
            int result= addfun.Invoke(firstnumber,secondnumber);
            Console.WriteLine("Addition of {0} and {1} is {2}", firstnumber, secondnumber, result );
         
        
            //Defining Lambda Expressions using Func
            Func<double,double > sqrtlambda=(n1)=>
            {
                return Math.Sqrt(n1);
            };
            bool chknum;
            double number;
            Console.WriteLine("Enter a number to find its SquareRoot");
            chknum =  double.TryParse(Console.ReadLine(),out number);
            if(!chknum) Console.WriteLine("Enter a Valid number");
            else{
                double sqrt= sqrtlambda.Invoke(number);

                Console.WriteLine("The Square root of {0} is {1}", number, sqrt);
            }
            Console.ReadKey();
        }
    }
}
