using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * Program demonstrating BinaryReader and BinaryWriter
 */

namespace IOSerialization02
{
    //[Serializable]
    class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOJ { get; set; }
    }

class Program
{
    static void Main(string[] args)
    {
        List<Emp> emps = new List<Emp>//Collection initializer
            {
                new Emp{Id=101,Name="Emp1",DOJ= new DateTime(2018,3,2)},//object initializer
                new Emp{Id=102,Name="Emp2",DOJ= new DateTime(2018,3,23)},
                 new Emp{Id=103,Name="Emp3",DOJ= new DateTime(2018,3,12)}
            };

        FileStream fileStream01 = new FileStream("Emps.bin", FileMode.Create, FileAccess.Write);
        writeEmp(fileStream01, emps);
        FileStream fileStream02 = new FileStream(@"Emps.bin", FileMode.Open, FileAccess.Read);
        List<Emp> cEmps = ReadEmp(fileStream02);
        foreach (var emp in cEmps)
        {
            Console.WriteLine($"{emp.Id},{emp.Name},{emp.DOJ}");
        }

        Console.ReadKey();
    }

        private static List<Emp> ReadEmp(FileStream fileStream02)
        {
            List<Emp> emps = new List<Emp>();
            BinaryReader binaryReader = new BinaryReader(fileStream02);
            try
            {
                while (true)
                {
                    Emp e = new Emp
                    {
                        Id = binaryReader.ReadInt32(),
                        Name = binaryReader.ReadString(),
                        DOJ = DateTime.Parse(binaryReader.ReadString())

                    };
                    emps.Add(e);
                }
            }
            catch (Exception ex)
            { }
            binaryReader.Close();
            fileStream02.Close();
            return emps;

        }
    private static void writeEmp(FileStream fileStream01, List<Emp> emps)
    {
        BinaryWriter binaryWriter = new BinaryWriter(fileStream01);
        foreach (var emp in emps)
        {
            binaryWriter.Write(emp.Id);
            binaryWriter.Write(emp.Name);
            binaryWriter.Write(emp.DOJ.ToString());
        }

        binaryWriter.Close();
        fileStream01.Close();
    }
}
}
