using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelEntity;
using HotelException;
using HotelBAL;

namespace HotelmanagementSystem
{
    class Program
    {
        public static int ID;
        //static Program()
        //{
        //    Console.WriteLine("enter workerID:");
            
        //}
        static void AddStudent(hmsbal bAL)
        {
            Worker w1 = new Worker();
            try
            {
                Console.WriteLine("enter details of worker \n Id\n Name\n Salary\n type\n DOJ\n worktime");
                w1.ID = int.Parse(Console.ReadLine());
                //w1.ID = ID++;
                w1.Name = Console.ReadLine();
                Console.Write("DOJ (dd/mm/yyyy):");
                w1.DOJ = DateTime.Parse(Console.ReadLine());
                w1.Salary = double.Parse(Console.ReadLine());
                Console.Write("Working hours (dd/mm/yyyy):");
                w1.WorkTime = DateTime.Parse(Console.ReadLine());
                Console.Write("select your category(\npress 1. for chef\npress 2 for service boy\npress 3 for receptionist)");
                w1.type = (category)int.Parse(Console.ReadLine());
                bAL.Add(w1);
                hmsbal.SerializeData();
            }
            catch (WorkerNotFoundException ex1)
            {
                Console.WriteLine(ex1.Message);
                ID--;
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            Console.WriteLine("worker added succesfully");
        }

        static void Display(hmsbal worker)
        {

            //student.GetAll();

            foreach (var item in worker.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Delete(hmsbal worker)
        {
            try
            {
                Console.WriteLine("Enter ID to delete");

                int ID = int.Parse(Console.ReadLine());
                foreach (var item in worker.GetAll())
                {
                    // Console.WriteLine(item.RollNo);
                    if (ID == item.ID)
                        worker.Remove(ID);
                }
            }
            catch (WorkerNotFoundException ex1)
            {
                Console.WriteLine(ex1.Message);
                
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            //Worker wr = new Worker();
            //int ID = int.Parse(Console.ReadLine());
            //worker.Remove(ID);
        }
        static void Modify(hmsbal worker)
        {
            //Student st = new Student();
            //student.Modify(st);

            Worker wr = new Worker();
            Console.WriteLine("Enter ID");
            int ID1 = int.Parse(Console.ReadLine());

            foreach (var item in worker.GetAll())
            {
                // Console.WriteLine(item.RollNo);
                if (ID1 == item.ID)
                {
                    wr = item;
                    worker.Modify(wr);
                }
            }
            
        }



        static void Main(string[] args)
        {
            char ch;
            int num;
            hmsbal bal = new hmsbal();
            //AddStudent(bal);
            //AddStudent(bal);
            //Display(bal);
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1)add 2)delete 3)update 4)display");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        AddStudent(bal);
                        break;
                    case 2:
                        Delete(bal);
                        break;

                    case 3:
                        Modify(bal);
                        break;
                    case 4:
                        Display(bal);
                        break;
                    default:
                        Console.WriteLine("Enter choice is wrong");
                        break;

                }
                Console.WriteLine("Do you want to continue or not if u want press Y");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');





            //  string str = $"RollNo:{student.RollNo},DOB:{student.DOB},Qual:{student.Qualification}"
            Console.ReadKey();
        }
    }
}
