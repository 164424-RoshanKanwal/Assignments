using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object with MathOp references
            MathOp math = new MathClass();
            //displaying the results of methods
            Console.WriteLine("add result is: "+ math.AddNumber(10, 20));
            Console.WriteLine("sub result is: "+ math.SubNumber(10, 20));
        }
    }

    //creating abstract class
    public abstract class MathOp
    {
        public abstract int AddNumber(int number1, int number2);
        public abstract int SubNumber(int number1, int number2);

    }
    //inheriting MathOp class and overriding that methods
    public class MathClass: MathOp
    {
        //overriding the abstract methods
        public override int AddNumber(int num1,int num2)
        {
            int num = num1 + num2;
            return num;
        }
        public override int SubNumber(int num1, int num2)
        {
            int num = num1 - num2;
            return num;
        }
    }
}
