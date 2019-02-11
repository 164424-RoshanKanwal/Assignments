using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ8_HashTable
{
    class HashTableClass
    {
       public static Hashtable ht = new Hashtable();
        public void addFunction(string key , string value) {

            string k = key;
            string val = value;
            if (ht.ContainsKey(k))
            {
                Console.WriteLine("Found in table ");
                Console.WriteLine("Enter new values");
            }
            else { 
            ht.Add(key,value);
                Console.WriteLine("Added Successfully");
            }
        }
        public string searchFunction(string k) {
            ICollection key = ht.Keys;
            string items="";
            foreach (string item in key)
            {
                if (ht.ContainsKey(k))
                {
                    Console.WriteLine("Found at: " + item);
                    items = item;
                }
                else {
                    Console.WriteLine( "enter the valid key" );
                }
            }
            return items;
        }
        public void displayFunction() {
            Console.WriteLine("Data in Hashtable:");
            ICollection key = ht.Keys;
            foreach (string entry in key)
            {

                string k = entry;
                    string val=(string)ht[k];
                Console.WriteLine("values are:{0} : {1}",k,val );
               
            }
            Console.Write("Total count of hashtable: ");
            Console.WriteLine(ht.Count);
        }
        public void removeFunction(string k) {
            ICollection key = ht.Keys;
          string keyss=  searchFunction(k);
            if (keyss == k) {
                ht.Remove(k);
            }
        }

    }
}
