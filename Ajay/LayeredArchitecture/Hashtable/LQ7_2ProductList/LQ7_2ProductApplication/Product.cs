using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ7_2ProductApplication
{
    class Product
    {
        public int ProductNo { get; set; }
        public string ProductName { get; set; }
        public double Rate { get; set; }
        public int Stock { get; set; }
        
        List<Product> MyAll = new List<Product>();

        public void addfunction(int no,string name,double rate,int stock) {
            Product p = new Product();
            p.ProductNo = no;
            p.ProductName = name;
            p.Rate = rate;
            p.Stock = stock;
            MyAll.Add(p);
        }
        public void deletefunction(int no) {
            //var obj="";
            Product[] output = MyAll.ToArray();

            foreach (var item in output)
            {
                if (item.ProductNo == no) {
                    Product obj = item;
                    int j = MyAll.IndexOf(obj);
                    MyAll.RemoveAt(j);
                }
            }
           
        }
        public void searchFunction(int no) {
            foreach (var item in MyAll)
            {
                if (item.ProductNo == no)
                {
                    Console.WriteLine($"item found: {item.ProductNo},{item.ProductName},{item.Rate},{item.Stock}");
                }
                else {
                    Console.WriteLine($"Enterred product is not found:{item.ProductNo}");
                }
            }
        }

        public void sortFunction() {
            Product[] output = MyAll.ToArray();

            foreach (var item in output)
            {
                Console.WriteLine($"{item.ProductNo}");
            }
            
            foreach (var item in MyAll)
            {
                Console.WriteLine($" {item.ProductNo} , {item.ProductName} , {item.Rate} , {item.Stock} ");
               
            }
        }
    }
}
