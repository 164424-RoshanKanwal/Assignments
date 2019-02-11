using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDAL;
using StudentEntity;
using StudentException;
//added references of entity and exception and DAL...


namespace StudentBLL
{
    public class StudentBLL
    {
        //validating student details
        private static bool ValidateStudent(Student student)
        {

            StringBuilder sb = new StringBuilder();
            bool validstudent = true;
            if (student.StudentID <=0 )
            {
                validstudent = false;
                sb.Append(Environment.NewLine + "Invalid student ID");

            }
            if (student.StudentName == string.Empty)
            {
                validstudent = false;
                sb.Append(Environment.NewLine + "student Name Required");

            }
            if (student.CourseName == string.Empty)
            {
                student.CourseName = "Computer";
               
            }
            ////if (student.Grade != 'A' || student.Grade != 'B' || student.Grade != 'C' || student.Grade != 'F')
            ////{
            ////    validstudent = false;
            ////    sb.Append(Environment.NewLine + "please enter A, B ,C, F values only");
            ////}
            if (validstudent == false)
                throw new StudentException.StudentException(sb.ToString());
            return validstudent;
        }

        //creating method in BLL for adding student
        public static bool AddStudent(Student student)
        {

            bool studentAdded = false;
            try
            {
                if (ValidateStudent(student))
                {
                    StudentDAL.StudentDAL studentDAL = new StudentDAL.StudentDAL();
                    studentAdded = studentDAL.AddStudentDAL(student);
                }

            }
            catch (StudentException.StudentException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return studentAdded;
        }

        //create method for displaying student details

        public static List<Student> DisplayStudentsBLL()
        {
            List<Student> studtlist = null ;
            try
            {
                StudentDAL.StudentDAL studentDal = new StudentDAL.StudentDAL();
                studtlist = studentDal.DisplayStudentDAL();
                return studtlist;
            }
            catch(StudentException.StudentException ex)
            {
                throw ex;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}
