using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EntityDTH;
using DTHExceptions;

namespace DAL
{
    public class DTHDAL
    {
        static List<Entity> List = new List<Entity>();

        public static bool AddStudentDAL(Entity newapplicant)
        {
            bool isStudentAdded = false;
            try
            {
                List.Add(newapplicant);
                
                isStudentAdded = true;
            }

            catch (ExceptionDTH)
            {
                throw;
            }
            return isStudentAdded;
        }

        

        public Entity SearchDAL(string applicantName)
        {
            Entity search;

            try
            {
                search = List.Find(Applicant => Applicant.Email == applicantName);

            }
            catch (ExceptionDTH) { throw; }
            return search;

        }


        public static bool UnsubscribePL(string email, string name)
        {
            Entity search;
            Entity search1;
            bool check = false;
            try
            {
                search = List.Find(Applicant => Applicant.Email == email && Applicant.ChannelName==name);
                search.unsubscription = "true";
                search.unsubscription_date = DateTime.Now;
                search1 = search;
                List.Remove(search);
                AddStudentDAL(search1);
                check = true;
                return check;
            }
            catch
            {
                return check;
            }


        }


        public static List<Entity> DisplayPL()
        {

            
            return List;
        }

    }
}
