using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ10Delegates
{
    class Program
    {
        enum functiontocall { delegatadd, delegatesubtract, delegatemultiply, delegatedivide }

        static void Main(string[] args)
        {
            Delegatesclass dc = new Delegatesclass();
            void function() { 
            Console.WriteLine("enter the values to calculate");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            }
            delgatename delegatadd , delegatesubtract, delegatemultiply, delegatedivide;
            //funct delone, deltwo, mul,add;
            // delone = dc.first;
            //deladd delegatadd;
            delegatadd = dc.add;
            delegatedivide = dc.divide;
            delegatemultiply = dc.multiply;
            delegatesubtract = dc.subtract;
            int select;
            char j;
            do
            {
                Console.WriteLine(functiontocall.delegatadd + " " + (int)functiontocall.delegatadd);
                Console.WriteLine(functiontocall.delegatesubtract + " " + (int)functiontocall.delegatesubtract);
                Console.WriteLine(functiontocall.delegatemultiply + " " + (int)functiontocall.delegatemultiply);
                Console.WriteLine(functiontocall.delegatedivide + " " + (int)functiontocall.delegatedivide);
                Console.WriteLine("enter the function number");
                
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 0:
                        Console.WriteLine("enter the values to calculate");
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        delegatadd(first, second);
                        
                        break;
                    case 1:
                        Console.WriteLine("enter the values to calculate");
                        int sfirst = int.Parse(Console.ReadLine());
                        int ssecond = int.Parse(Console.ReadLine());
                        delegatesubtract(sfirst, ssecond);

                        break;
                    case 2:
                        Console.WriteLine("enter the values to calculate");
                        int mfirst = int.Parse(Console.ReadLine());
                        int msecond = int.Parse(Console.ReadLine());
                        delegatemultiply(mfirst, msecond);
                        break;
                    case 3:
                        Console.WriteLine("enter the values to calculate");
                        int dfirst = int.Parse(Console.ReadLine());
                        int dsecond = int.Parse(Console.ReadLine());
                        delegatedivide(dfirst, dsecond);
                        break;
                }
                Console.WriteLine("enter y to continue and n to exit");
                 j = char.Parse(Console.ReadLine());
            } while (j!='n');

            Console.ReadKey();
        }
        
    }
}
