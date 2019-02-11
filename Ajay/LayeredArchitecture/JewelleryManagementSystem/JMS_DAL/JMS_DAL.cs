using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Exceptions;
using Entities;

namespace DAL
{
    public class JMS_DAL
    {
        public static List<JMS_Entities> SMS = new List<JMS_Entities>();


        //public int CustomerID { get; set; }
        //public string CusotmerPhNo { get; set; }

        public static bool AddSalesMan(JMS_Entities SalesManName)
        {
            bool SalesManAdded = false;
            try
            {
                SMS.Add(SalesManName);
                SalesManAdded = true;
            }
            catch (JMS_Exceptions ex)
            {
                throw ex;
            }
            return SalesManAdded;
        }

        public static List<JMS_Entities> ReturnSalesManInformation()
        {
            return SMS;
        }
        //public static bool DeleteCustomer(JMS_Entities SalesManToBeDeleted)
        //{
        //    try
        //    {
        //        //Removing SalesMan from the list
        //        SMS.Remove(SalesManToBeDeleted);
        //        return true;
        //    }
        //    catch (SystemException e)
        //    {
        //        throw e;
        //    }
        //}
        public static JMS_Entities SearchSalesMan(int SalesManCode)
        {
            try
            {

                JMS_Entities searchedSalesMan = null;

                //foreach (var JMS_Entities in SMS)
                //{
                //   // Cheking the SalesManCode
                //      if (JMS_Entities.SalesManCode == SalesManCode)
                //    {
                //        //If guest found store the guest details to searchedguest
                //        searchedSalesMan = SalesMan;
                //    }
                //}
                searchedSalesMan = SMS.Find(p => p.SalesManCode == SalesManCode);//null;

                return searchedSalesMan;
            }
            catch (JMS_Exceptions e)
            {
                throw e;
            }
        }

        public static bool UpdateSalesMan(JMS_Entities SalesManToBeUpdated)
        {
            bool SalesManUpdated = false;

            for (var i = 0; i < SMS.Count; i++)
            {
                //Find the Customer to be updated & update record
                if (SMS[i].SalesManCode == SalesManToBeUpdated.SalesManCode)
                {
                    SMS[i].SalesManName = SalesManToBeUpdated.SalesManName;
                    SMS[i].Region2 = SalesManToBeUpdated.Region2;
                    SalesManUpdated = true;
                }
            }

            return SalesManUpdated;
        }
        public static bool DeleteSalesMan(JMS_Entities salesmanToBeDeleted)
        {
            try
            {
                //Removing Customer from the list
                SMS.Remove(salesmanToBeDeleted);
                return true;
            }
            catch (SystemException e)
            {
                throw;
            }
        }
       




        public static void SerializeData()
        {
            FileStream FileStream;
            try
            {
                FileStream = new FileStream("SMS.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(FileStream, SMS);
                FileStream.Close();
            }
            catch (IOException e)
            {
                throw e;
            }

        }
        public static List<JMS_Entities> DeserializeData()
        {
            FileStream stream = new FileStream("SMS.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            SMS = formatter.Deserialize(stream) as List<JMS_Entities>;
            return SMS;
        }
        public static List<JMS_Entities> DisplaySalesManFromFile()
        {
            SerializeData();
            SMS = DeserializeData();
            return SMS;
        }

    }
}
