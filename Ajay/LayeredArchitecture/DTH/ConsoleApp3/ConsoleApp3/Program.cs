using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ConsoleApp3
{

    /// <summary>
    /// Console Application to find the return type and member type
    /// Author: Rajat Yadav
    /// DOC: 23 Oct 2018
    /// </summary>

    class Program
    {
        public Assembly LoadAssembly(string path)
        {
            return Assembly.LoadFile(path);
        }

        public Type[] TypeAssembly(Assembly ass)
        {
            return ass.GetTypes();
        }

        static void Main(string[] args)
        {  
            Console.WriteLine("Enter the path for the file");
            string path = Console.ReadLine();
            Console.WriteLine("Enter the user name you want to find");
            var user = Console.ReadLine();
            Program pro = new Program();
            Assembly ass = pro.LoadAssembly($@"{path}");
            Type[] types = pro.TypeAssembly(ass);
            foreach(var i in types)
            {
                var b = i.GetMembers();
                foreach (var j in b)
                {
                    MemberInfo jminfo = (MemberInfo)j;
                    
                    if (jminfo.Name == user)
                    {
                        Console.WriteLine("User type:" + j.MemberType.ToString());
                        if (j.MemberType.ToString() == "Method")
                        {
                            MethodInfo jinfo = (MethodInfo)j;
                            Console.WriteLine("Return type:" + jinfo.ReturnType);
                        }

                    }

                    else
                    {
                        Console.WriteLine("Member not found!!!!!");
                    }

                    
                    Console.ReadLine();
                }
            }

        }
    }
}
