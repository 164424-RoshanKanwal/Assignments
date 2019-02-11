using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace IOSerialization02
{
    class serializationdemo1
    {
        static void SerializeEmps(ArrayList emps)
        {
            try
            {
                FileStream fs = new FileStream("emps.soap", FileMode.Create);
                SoapFormatter bf = new SoapFormatter();
                bf.Serialize(fs, emps);
                fs.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static ArrayList DeserializeEmps()
        {
            try
            {

                FileStream fs = new FileStream("emps.soap", FileMode.Create);
                SoapFormatter bf = new SoapFormatter();
                ArrayList emps = (ArrayList)bf.Deserialize(fs);
                fs.Close();
                return emps;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        static void Main(string[] args)
        {
            ArrayList emps = new ArrayList();//Collection initializer
            {
                new Emp { Id = 101, Name = "Emp1", DOJ = new DateTime(2018, 3, 2) };//object initializer
                new Emp { Id = 102, Name = "Emp2", DOJ = new DateTime(2018, 3, 23) };
                new Emp { Id = 103, Name = "Emp3", DOJ = new DateTime(2018, 3, 12) };
            };
            try
            {
                SerializeEmps(emps);
                ArrayList cEmps = DeserializeEmps();
                foreach (Emp e in cEmps)
                {
                    Console.WriteLine($"{e.Id},{e.Name},{e.DOJ}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}
