using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ9Dictionary
{
    class Program
    {
        enum functiontocall { add,display,delete}
        static void Main(string[] args)
        {
            int select; string j;
            do {
                Console.WriteLine(functiontocall.add +" "+ (int)functiontocall.add);
                Console.WriteLine(functiontocall.display + " " + (int)functiontocall.display);
                Console.WriteLine(functiontocall.delete + " " + (int)functiontocall.delete);
                Console.WriteLine("enter the function number");
                select = int.Parse(Console.ReadLine());
                Dictionaries dic = new Dictionaries();
                switch (select) {

                    case 0:
                        try {
                            Console.WriteLine("Enter the File name");
                            string var = Console.ReadLine();
                            Console.WriteLine("Enter the file ext");
                            string ext = Console.ReadLine();

                            dic.add(var, ext);
                        }
                        catch (ContainingException ex) {
                            Console.WriteLine( ex.Message);
                        }
                        break;
                    case 1:
                        dic.display();
                        break;
                    case 2:
                        Console.WriteLine("enter the filename");
                        string file = Console.ReadLine();
                        break;
                }
                Console.WriteLine("Enter yes to continue and no to exit:");
                j = Console.ReadLine();
            } while (j !="no");
        }
    }
}
