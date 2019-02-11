using FacultyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacultyDAL;
using System.Text.RegularExpressions;

namespace FacultyBLL
{
    public class FacultyBLL
    {
        private static bool ValidateFaculty(Faculty faculty)
        {

            StringBuilder sb = new StringBuilder();
            bool validFaculty = true;
            if (faculty.FacultyId <= 0)
            {
                validFaculty = false;
                sb.Append(Environment.NewLine + "Invalid Faculty ID");

            }

            if (!Regex.Match(faculty.FacultyName, "^[a-zA-Z]*$").Success)
            {
                validFaculty = false;
                sb.Append(Environment.NewLine + "Invalid Faculty Name");
            }
            if (faculty.Phoneno.Length!=10)
            {
                validFaculty = false;
                sb.Append(Environment.NewLine + "Invalid Faculty phone No");
            }
            
            
            if (validFaculty == false)
                throw new FacultyException.FacultyException(sb.ToString());
            return validFaculty;
        }
        public static bool AddFacultyBL(Faculty newFaculty)
        {
            bool facultyAdded = false;
            try
            {
                if (ValidateFaculty(newFaculty))
                {
                    FacultyDAL.FacultyDAL facultyDAL = new FacultyDAL.FacultyDAL();
                   facultyAdded = facultyDAL.AddFacultyDAL(newFaculty);
                }
            }
            catch (FacultyException.FacultyException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return facultyAdded;
        }


        public static Faculty SearchFacultyBL(int searchFacultyID)
        {
            Faculty searchFaculty = null;
            try
            {
                FacultyDAL.FacultyDAL facultyDAL = new FacultyDAL.FacultyDAL();
                searchFaculty = facultyDAL.SearchFacultyDAL(searchFacultyID);
            }
            catch (FacultyException.FacultyException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchFaculty;

        }
    }
}
