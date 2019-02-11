using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;
using StudentException;
//added references of entity and exception

namespace StudentDAL
{
    public class StudentDAL
    {
        //creating list collection for storing student details..
        public static List<Student> studentslist = new List<Student>();

        //creating Addstudent method for adding opertion
        public bool AddStudentDAL(Student newstudent)
        {

            bool studentAdded = false;
            try
            {

                studentslist.Add(newstudent);
                studentAdded = true;


            }
            catch (Exception ex)
            {
                throw new StudentException.StudentException(ex.Message);
            }
            return studentAdded;
        }

        //creating method for displaying details for user

        public List<Student> DisplayStudentDAL()
        {
            return studentslist;
        }
    }
}
