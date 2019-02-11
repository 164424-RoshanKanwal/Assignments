using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    class RefDemo
    {
            static void Main(string[] args)


            {



                Type t = typeof(CustomerInfo);


                //Fields


                FieldInfo[] fi = t.GetFields();



                Console.WriteLine("**********FieldsInformation**********" + Environment.NewLine);


                foreach (FieldInfo f in fi)


                {



                    Console.WriteLine("FieldName : " + f.Name);


                    Console.WriteLine("FieldModule : " + f.Module);


                    Console.WriteLine("FieldReflectedType : " + f.ReflectedType + Environment.NewLine);


                }



                //Properties


                PropertyInfo[] property = t.GetProperties();



                Console.WriteLine("**********PropertiesInformation**********" + Environment.NewLine);


                foreach (PropertyInfo p in property)


                {



                    Console.WriteLine("PropName : " + p.Name);


                    Console.WriteLine("PropPropertyType : " + p.PropertyType);


                    Console.WriteLine("PropModule : " + p.Module + Environment.NewLine);


                }





                //Constructors


                ConstructorInfo[] ci = t.GetConstructors();



                Console.WriteLine("**********ConstructorsInformation**********" + Environment.NewLine);


                foreach (ConstructorInfo c in ci)


                {



                    Console.WriteLine("ConstructorName : " + c.Name);


                    Console.WriteLine("ConstructorMethodHandle : " + c.MethodHandle);


                    Console.WriteLine("ConstructorIsStatic : " + c.IsStatic);


                    Console.WriteLine("ConstructorModule : " + c.Module + Environment.NewLine);


                }



                //Toread the main


                Console.ReadLine();


            }


    }
}

