using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;
using StudentException;
using StudentBLL;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//added references of entity,BLL and exception classes

namespace StudentManagementSystem
{
    class StudentPL
    {
        static void Main(string[] args)
        {
            //calling printmenu method here
            PrintMenu();
            Console.ReadLine();
        }

        public static void PrintMenu()
        {
            //calling required method by the user choice
            Student student = new Student();
            string choice1;
            do
            {
                Console.WriteLine("\n***********student Management System ***********");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. display student");
                Console.WriteLine("3. serialisation");
                Console.WriteLine("4. deserialisation");

                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayStudent();
                        break;
                    case 3:
                        Serializedata(student);
                        break;
                    case 4:
                        DeSerializeData();
                        break;  

                }
                Console.WriteLine("Do you want to contiue(y/n)?");
                choice1 = Console.ReadLine();
            } while ((choice1 == "y"));
            Console.Read();

        }

        //create method for adding student details
        public static void AddStudent()
        {
            bool studentAdded = false;
            try
            {
                Student student = new Student();
                //accepting values from the user..
                Console.WriteLine("enter studentid:");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student name:");
                student.StudentName = Console.ReadLine();
                Console.WriteLine("enter course name:");
                student.CourseName = Console.ReadLine();
                Console.WriteLine("enter grade:");
                student.Grade = Convert.ToChar(Console.ReadLine());

                studentAdded = StudentBLL.StudentBLL.AddStudent(student);
                if (studentAdded)
                {
                    Console.WriteLine("student added");
                }
                else
                {
                    Console.WriteLine("student not added");
                }
            }
            catch(StudentException.StudentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //create method for displaying student details
        public static void DisplayStudent()
        {

            try
            {
                 List<Student> studentList = StudentBLL.StudentBLL.DisplayStudentsBLL();
                if (studentList != null && studentList.Count > 0)
                {
                    Console.WriteLine("studentID\tstudentname\tcoursename\tgrade\n");
                    
                    foreach (Student st in studentList)
                    {
                        Console.WriteLine(":{0}\t\t{1}\t\t{2}\t\t{3}",st.StudentID,st.StudentName,st.CourseName,st.Grade);
                    }
                    Console.WriteLine("******************************************************************************");

                 }
                else
                {
                Console.WriteLine("No student Details Available");
                }
            }
            catch (StudentException.StudentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //creating serialisedata method for serialising the data
        public static void Serializedata(Student studentdata)
        {
            FileStream fileStream = new FileStream("Student.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, studentdata);
            fileStream.Close();
            Console.WriteLine("Data is Serialised");
        }


        //creating deserialisedata method for deserialising the data and retriving the data
        public static void DeSerializeData()
        {
            FileStream filestream = new FileStream("Student.txt", FileMode.Open);
            BinaryFormatter binaryformatter = new BinaryFormatter();
            Student student = binaryformatter.Deserialize(filestream) as Student;
            Console.WriteLine($"studentid={student.StudentID}, student name={student.StudentName}, course name={student.CourseName},grade={student.Grade}");
            filestream.Close();
            Console.WriteLine("data is deserialised");
        }
    }
}
