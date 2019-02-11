using FacultyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyDAL
{
    public class FacultyDAL
    {
        static List<Faculty> facultyList = new List<Faculty>();
        public bool AddFacultyDAL(Faculty newFaculty)
        {
            bool facultyAdded = false;
            try
            {

                facultyList.Add(newFaculty);
                facultyAdded = true;


            }
            catch (Exception ex)
            {
                throw new FacultyException.FacultyException(ex.Message);
            }
            return facultyAdded;

        }

        public Faculty SearchFacultyDAL(int searchFacultyID)
        {
            Faculty SearchFaculty = null;
            try
            {
                for (int i = 0; i < facultyList.Count; i++)
                {
                    Faculty faculty= facultyList[i];
                    if (faculty.FacultyId== searchFacultyID)
                    {
                        SearchFaculty = facultyList[i];
                        break;
                    }
                }
            }
            catch (FacultyException.FacultyException ex)
            {
                throw new FacultyException.FacultyException(ex.Message);
            }
            return SearchFaculty;

        }
    }
}
