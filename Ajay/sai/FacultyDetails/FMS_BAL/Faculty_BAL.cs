using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMS_DAL;
using FMS_Entities;
using FMS_Exceptions;
using System.IO;
using System.Text.RegularExpressions;


namespace FMS_BAL
{
    public class Faculty_BAL
    {
        Faculty_DAL operationsObj;
        static List<FacultyEntity> facultyList = new List<FacultyEntity>();


        public bool ValidateFaculty(FacultyEntity newFaculty)
        {
            bool isValidFaculty = true;
            StringBuilder sbFMSError = new StringBuilder();

            if (newFaculty.FacultyId.ToString().Equals(string.Empty))
            {
                isValidFaculty = false;
                sbFMSError.Append("Faculty Id cannot be blank " + Environment.NewLine);

            }
           
            if (!(Regex.IsMatch(newFaculty.FacultyName, "[A-Z][a-z]{3,}")))
            {
                isValidFaculty = false;
                sbFMSError.Append("Faculty Name must have only characters starting with uppercase " + Environment.NewLine);
            }
            if (newFaculty.DOJ >= DateTime.Now)
            {
                isValidFaculty = false;
                sbFMSError.Append("Faculty DOJ must not be a future Date " + Environment.NewLine);

            }
            if (!(Regex.IsMatch(newFaculty.Phone.ToString(), "[1-9][0-9]{9}")))
            {
                isValidFaculty = false;
                sbFMSError.Append("Faculty phone should have 10 digits and first digit cannot be 0 " + Environment.NewLine);
            }

            if (!isValidFaculty)
            { throw new FacultyException(sbFMSError.ToString()); }

            return isValidFaculty;
        }

        public bool AddFacultyBAL(FacultyEntity newFaculty)
        {
            bool isFacultyAdded = false;

            try
            {
                operationsObj = new Faculty_DAL();
                if (ValidateFaculty(newFaculty))
                    isFacultyAdded = operationsObj.AddFacultyDAL(newFaculty);
                else
                    throw new FacultyException("Validation Failed!!!Faculty Record could not be added");
            }
            catch (FacultyException)
            {

                throw;
            }
            return isFacultyAdded;
        }
        public FacultyEntity SearchFacultyBAL(long? phone)
        {
            FacultyEntity searchedFaculty = null;
            try
            {
                operationsObj = new Faculty_DAL();
                searchedFaculty = operationsObj.SearchFacultyDAL(phone);
                if (searchedFaculty == null) throw new FacultyException("Faculty not found");

            }
            catch (FacultyException ex) { throw ex; }
            return searchedFaculty;


        }
    }
}
