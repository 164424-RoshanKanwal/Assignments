using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ8_HashTable
{
    class Program
    {
        public Hashtable this[int i]
        {
            get { return GetHashtable(); }
            
        }
        public Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);



            return hashtable;
        }

        enum functionsTocall { AddFunction=1,displayFunction, searchFunction,removefunction }
        static void Main(string[] args)
        {
            Program pg = new Program();
            Hashtable tb =pg.GetHashtable();
            if (tb.ContainsKey("Perimeter")) {
                Console.WriteLine("Yes it containskey :");
                
            }
            if (tb.Contains("Perimeter"))
            {
                Console.WriteLine("yes it contains ");
            }
            tb.Remove("Mortgage");


            //int funcNum;
            //do {
            //    Console.WriteLine(functionsTocall.AddFunction +" "+ (int)functionsTocall.AddFunction);
            //    Console.WriteLine(functionsTocall.displayFunction + " " + (int)functionsTocall.displayFunction);
            //    Console.WriteLine(functionsTocall.searchFunction + " " + (int)functionsTocall.searchFunction);
            //    Console.WriteLine(functionsTocall.removefunction + " " + (int)functionsTocall.removefunction);
            //    Console.WriteLine("Enter the function number or enter 5 to exit:");
            //    funcNum = int.Parse(Console.ReadLine());
            //    HashTableClass ht = new HashTableClass();
            //    switch (funcNum) {
            //        case 1:
            //            Console.WriteLine("enter the key:");
            //            string key = (Console.ReadLine());
            //            Console.WriteLine("enter the Values:");
            //            string value = Console.ReadLine();
            //            ht.addFunction(key,value);
            //            break;
            //        case 2:ht.displayFunction();
            //            break;
            //        case 3:
            //            Console.WriteLine("enter the key to search:");
            //            ht.searchFunction(Console.ReadLine());
            //            break;
            //        case 4:Console.WriteLine("enter the key to remove/delete:");
            //            ht.removeFunction(Console.ReadLine());
            //            break;
            //        case 5:
            //            break;
            //    }
            //} while (funcNum !=5);



            Console.ReadKey();
        }
      
    }
}
