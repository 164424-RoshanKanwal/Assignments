using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMS_Entities;
using FMS_Exceptions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace FMS_DAL
{
    public class Faculty_DAL
    {
        //static list to maintain the Employee Details
        static List<FacultyEntity> facultyList = new List<FacultyEntity>();
        /// <summary>
        /// To add new faculty into the List/Collection
        /// </summary>
        /// <param name="newFaculty"></param>
        /// <returns></returns>
        public bool AddFacultyDAL(FacultyEntity newFaculty)
        {
            bool isFacultyAdded = false;
            try
            {
                facultyList.Add(newFaculty);
                isFacultyAdded = true;
            }
            catch (FacultyException)
            {
                throw;
            }

            return isFacultyAdded;

        }
        public FacultyEntity SearchFacultyDAL(long? phone)
        {
            FacultyEntity searchedFaculty;

            try
            {
                searchedFaculty = facultyList.Find(fac => fac.Phone == phone);

            }
            catch (FacultyException) { throw; }
            return searchedFaculty;

        }

    }
}
