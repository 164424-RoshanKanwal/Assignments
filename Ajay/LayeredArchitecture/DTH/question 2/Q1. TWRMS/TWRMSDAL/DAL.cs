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
                SerializeDAL();
                isStudentAdded = true;
            }

            catch (ExceptionDTH)
            {
                throw;
            }
            return isStudentAdded;
        }

        public static List<Entity> DisplayDALList()
        {
            return DeserializeDAL();
        }

        public static void SerializeDAL()
        {
            FileStream fStream = null;

            try
            {
                List<Entity> List1 = new List<Entity>();

                foreach (var temp in List)
                {
                    if (temp.unsubscription == "false")
                    {
                        List1.Add(temp);
                    }
                }

                fStream = new FileStream("ChannelList.ser", FileMode.Create, FileAccess.Write);
                BinaryFormatter Formatter = new BinaryFormatter();
                Formatter.Serialize(fStream, List1);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fStream.Close();
            }
        }

        public static List<Entity> DeserializeDAL()
        {
            List<Entity> deserializedData = null;
            FileStream fStream = null;
            try
            {
                fStream = new FileStream("ChannelList.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter Formatter = new BinaryFormatter();
                deserializedData = (List<Entity>)Formatter.Deserialize(fStream);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fStream.Close();
            }
            return deserializedData;
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
            List<Entity> List2 = new List<Entity>();

            List2 = DisplayDALList();
            return List;
        }

    }
}
