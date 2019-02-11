using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using HotelEntity;
using HotelException;

namespace HotelDAL
{
    public class hmsdal
    {
        static List<Worker> workers = new List<Worker>();
        public void Insert(Worker worker)
        {
            try
            {
                workers.Add(worker);

            }
            catch (Exception ex1)
            {
                throw ex1;

            }

        }
        public void Update(Worker worker)
        {
            try
            {
                var work = workers.Find(W => W.ID == worker.ID);
                if (work != null)
                {
                    Console.WriteLine("update block");
                    Console.WriteLine("Enter change name of worker,  Salary, category, Date of Joining, Working Hours,");

                    work.Name = Console.ReadLine();
                    work.Salary = Convert.ToDouble(Console.ReadLine());
                    work.type = (category)int.Parse(Console.ReadLine());
                    work.DOJ = DateTime.Parse(Console.ReadLine());
                    work.WorkTime = DateTime.Parse(Console.ReadLine());
                }
            }
            catch (Exception ex2)
            {
                throw ex2;
            }

        }
        public void Delete(int ID)
        {
            try
            {
                var work = workers.Find(W => W.ID == ID);
                if (work != null)
                {
                    workers.Remove(work);
                    Console.WriteLine("deleted succsfully");
                }
                else
                {
                    throw new WorkerNotFoundException($"worker with worker_Id:{work.ID} Not Found");

                }
                //workers.Remove(worker);
                //Console.WriteLine("deleted succsfully");

            }

            catch (Exception ex1)
            {
                throw ex1;
            }
        

        }

       

        public List<Worker> SelectAll()
        {
            try
            {
                workers = DeserializeData();
                return workers;
            }
            catch (Exception ex3)
            {
                throw ex3;
            }
        }

        public static void SerializeData()
        {
            FileStream stream;
            try
            {
                stream = new FileStream("worker.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, workers);
                stream.Close();
            }
            catch (IOException e)
            {
                throw e;
            }

        }
        public static List<Worker> DeserializeData()
        {
            FileStream stream = new FileStream("worker.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            workers = formatter.Deserialize(stream) as List<Worker>;
            return workers;
        }

    }
}
