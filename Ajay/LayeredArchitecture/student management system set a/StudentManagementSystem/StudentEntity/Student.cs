using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntity
{
    //creating entity class for student management system
    [Serializable]
    public class Student
    {

        //creating properties for above private variables
        
        public int StudentID { get; set; }
        public string StudentName{ get; set; }
        public string CourseName{ get; set; }
        public char Grade{ get; set; }
    }
}
