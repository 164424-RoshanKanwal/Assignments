using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents01
{
    //Creating a Delegate
    public delegate void ArithmeticHandler(int firstNumber, int secondNumber);
    public delegate int ArithmeticHandler1(int firstNumber, int secondNumber);

    public class Operations
    {
        public void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Addtion of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber + secondNumber);
        }
        public void Subtraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber - secondNumber);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operations operationObj = new Operations();

            ArithmeticHandler arithObj1, arithObj2, arithObj3;
            arithObj1 = new ArithmeticHandler(operationObj.Addition);
            arithObj1 += new ArithmeticHandler(operationObj.Subtraction);
            arithObj2 = new ArithmeticHandler(operationObj.Addition);
            arithObj2 -= new ArithmeticHandler(operationObj.Subtraction);
            ////Multicasting a delegate
            //arithObj3 = arithObj1 + arithObj2;
            //Anonymous Method
            ArithmeticHandler arithobj1 = delegate (int n1, int n2) { Console.WriteLine("Addition of {0} and {1} is {2}",n1,n2,n1+n2); };
            ArithmeticHandler1 arithobj2 = delegate (int n1, int n2) { return n1 - n2; };

            ////Lambda Expression
            ArithmeticHandler arithobj3 =( n1, n2)=>{Console.WriteLine("Addition of {0} and {1} is {2}", n1, n2, n1 + n2);Console.WriteLine("Hello"); };
            ArithmeticHandler1 arithobj4 = (n1, n2) =>  n1 - n2;//(x)=>n;()=>2;
            //arithObj1(2, 3);
           // arithObj2(30, 2);
            arithobj3(6, 20);
           // arithobj2(6, 3);
          // arithobj1(20, 4);
            //arithobj4(10, 4);
            Console.WriteLine(arithobj4(10, 4));
            Console.ReadKey();
        }
    }
}
