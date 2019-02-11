using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IOSerialization02
{
    class serializationdemo
    {
        static void SerializeEmps(List<Emp> emps)
        {
            try
            {
                FileStream fs = new FileStream("emps.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, emps);
                fs.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private static List<Emp> DeserializeEmps()
        {
            try
            {

                FileStream fs = new FileStream("emps.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                List<Emp> emps = (List<Emp>)bf.Deserialize(fs);
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
            List<Emp> emps = new List<Emp>//Collection initializer
            {
                new Emp{Id=101,Name="Emp1",DOJ= new DateTime(2018,3,2)},//object initializer
                new Emp{Id=102,Name="Emp2",DOJ= new DateTime(2018,3,23)},
                 new Emp{Id=103,Name="Emp3",DOJ= new DateTime(2018,3,12)}
            };
            try
            {
                SerializeEmps(emps);
                List<Emp> cEmps = DeserializeEmps();
                foreach (var e in cEmps)
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

