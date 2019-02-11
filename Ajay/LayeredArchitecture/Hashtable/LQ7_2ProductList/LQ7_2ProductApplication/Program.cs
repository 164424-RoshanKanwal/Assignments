using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ7_2ProductApplication
{
    class Program
    {
        enum methodtocall{ addfunction,searchfunction,deletefunction,sortfunction }
        void functionToEnterTheValues() {
           
       }
        static void Main(string[] args)
        {
            int functioncall;
            Product pd = new Product();
            do {
                Console.WriteLine(methodtocall.addfunction +" "+ (int)methodtocall.addfunction);
                Console.WriteLine(methodtocall.searchfunction + " " + (int)methodtocall.searchfunction);
                Console.WriteLine(methodtocall.deletefunction + " " + (int)methodtocall.deletefunction);
                Console.WriteLine(methodtocall.sortfunction + " " + (int)methodtocall.sortfunction);
                Console.WriteLine("Select the function");
                functioncall = int.Parse(Console.ReadLine());
                switch (functioncall) {
                    case 0:
                        Console.WriteLine("Enter the Product No:");
                        int ProductNo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Product Name:");
                        string ProductName = Console.ReadLine();
                        Console.WriteLine("Enter the Product Rate:");
                        double Rate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Product Stock:");
                        int Stock = int.Parse(Console.ReadLine());
                        pd.addfunction(ProductNo,ProductName,Rate,Stock);
                        break;
                    case 1:
                        Console.WriteLine("enter the product no to search:");
                        int no = int.Parse(Console.ReadLine());
                        pd.searchFunction(no);
                        break;
                    case 2:
                        Console.WriteLine("enter the product no to delete:");
                        int num = int.Parse(Console.ReadLine());
                        pd.deletefunction(num);
                        break;
                    case 3:
                        Console.WriteLine("To sort array and to display");
                        pd.sortFunction();
                        break;
                    case 4:
                        Console.WriteLine("exited");
                        break;
                }
            } while (functioncall !=4);

        }
    }
}
