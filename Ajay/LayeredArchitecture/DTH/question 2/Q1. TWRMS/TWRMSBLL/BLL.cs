using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using EntityDTH;
using DTHExceptions;

namespace BLL
{
    public class DTHBLL
    {

        static List<Entity> List = new List<Entity>();

        public bool AddBL(Entity twoWheelerApplicant)
        {
            bool isAdded = false;
            try
            {
                DTHDAL applicantOperations = new DTHDAL();
                if (ValidateApplicant(twoWheelerApplicant))
                {
                    isAdded = DTHDAL.AddStudentDAL(twoWheelerApplicant);
                }
                else
                {
                    throw new ExceptionDTH("Validation Failed!!! details could not be added");
                }
                if (isAdded == false)
                {
                    throw new ExceptionDTH("Applicant Details not Added");
                }
            }
            catch (ExceptionDTH e)
            {
                throw e;
            }
            return isAdded;
        }

        //public List<TwoWheelerApplicant> DisplayApplicantBL()
        //{
        //    TwoWheelerApplicantDAL applicantOperations = new TwoWheelerApplicantDAL();
        //    try
        //    {
        //        applicantList = applicantOperations.DisplayTwoWheelerApplicantDAL();
        //        if (applicantList.Count <= 0)
        //        {
        //            throw new TwoWheelerApplicantException("No Records Found!!!");

        //        }
        //    }
        //    catch (TwoWheelerApplicantException e)
        //    {
        //        throw e;
        //    }

        //    return applicantList;
        //}

        private static bool ValidateApplicant(Entity twoWheelerApplicant)
        {
            bool validApplicant = true;
            StringBuilder message = new StringBuilder();
            if (twoWheelerApplicant.Email == null || twoWheelerApplicant.ChannelName == string.Empty)
            {
                message.Append(Environment.NewLine + "Email or Channel Name should not be blank");
                validApplicant = false;
            }
            if (validApplicant == false)
            {
                throw new ExceptionDTH(message.ToString());
            }
            return validApplicant;
        }

        public Entity SearchBLL(string applicantName)
        {
            Entity searchedApplicant = null;
            try
            {
                DTHDAL twoWheelerApplicantDAL = new DTHDAL();
                searchedApplicant = twoWheelerApplicantDAL.SearchDAL(applicantName);
                if (searchedApplicant == null) throw new ExceptionDTH("Applicant not found");

            }
            catch (ExceptionDTH Exception) { throw Exception; }
            return searchedApplicant;
        }


        public static bool UnsubscribePL(string email,string name)
        {
            
            return DTHDAL.UnsubscribePL(email, name);
        }


        public static List<Entity> DisplayPL()
        {
            
            List<Entity> details = new List<Entity>();
            details = DTHDAL.DisplayPL();
            return details;
        }

    }
}
