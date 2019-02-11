using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ9Dictionary
{
    class Dictionaries
    {
       IDictionary<string, string> fileDictionary = new Dictionary<string, string>();

        //public string this[string index, string val]
        //{
        //    get
        //    {
        //        string temp;
        //        if (index != "")
        //            Console.WriteLine("Hey m Zero");
        //        return fileDictionary[index];
        //    }
        //    set
        //    {
        //        if (!fileDictionary.ContainsKey(index)) { 
        //            Console.WriteLine("Setting up");
        //        fileDictionary.Add(index, val);
        //        }
        //    }
        //}

        public void add(string k,string value) {
            
            for (int i = 0; i < fileDictionary.Count; i++)
            {
                if (fileDictionary.ContainsKey(k))
                {
                    throw new ContainingException();
                }
                else {
                    fileDictionary.Add(k, value);
                    Console.WriteLine("Added succesfully");
                }
            }
            
        }
        public void display() {
            foreach (object item in fileDictionary)
            {
                Console.WriteLine(item);
            }


            foreach (KeyValuePair<string ,string> item in fileDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            for (int i = 0; i < fileDictionary.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", fileDictionary.Keys.ElementAt(i),
                fileDictionary[fileDictionary.Keys.ElementAt(i)]);
            }
        }
        public void remove(string key) {
            foreach (KeyValuePair<string, string> item in fileDictionary)
            {
                if (fileDictionary.ContainsKey(key))
                {
                    fileDictionary.Remove(key);
                }
                else {
                    throw new ContainingException();
                }
            }
        }
       
    }
}
