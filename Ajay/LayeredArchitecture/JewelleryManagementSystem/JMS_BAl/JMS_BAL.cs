using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Exceptions;
using DAL;



namespace BAL
{
    public class JMS_BAL
    {

        private static bool ValidateSalesMan(JMS_Entities SalesMan)
        {
            StringBuilder sb = new StringBuilder();

            bool ValidSalesMan = true;
            if (SalesMan.SalesManCode <= 0)
            {
                ValidSalesMan = false;
                sb.Append(Environment.NewLine + "Invalid Guest ID");
            }

            return ValidSalesMan;


        }

        public static bool AddSalesMan(JMS_Entities newSalesMan)
        {
            bool SalesManAdded = false;
            try
            {
                if (ValidateSalesMan(newSalesMan))
                {
                    SalesManAdded = JMS_DAL.AddSalesMan(newSalesMan);
                }
            }
            catch (JMS_Exceptions)
            {
                throw;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return SalesManAdded;
        }

        public static JMS_Entities SearchSalesMan(int SalesManCode)
        {
            JMS_Entities SalesManSearched = null;

            try
            {
                //Searching Customer
                SalesManSearched = JMS_DAL.SearchSalesMan(SalesManCode);

                //If searched Customer is null raise exception
                if (SalesManSearched == null)
                {
                    throw new JMS_Exceptions("SalesMan Info does not exist!");
                }
            }
            catch (JMS_Exceptions p)
            {
                throw;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            return SalesManSearched;
        }

        public static bool DeleteSalesMan(int SalesManCode)
        {
            bool SalesManDeleted = true;
            JMS_Entities salesmanToBeDeleted = null;

            try
            {
                //Search customer in the records
                salesmanToBeDeleted = JMS_DAL.SearchSalesMan(SalesManCode);

                //If Guest is not null delete customer otherwise raise exception
                if (salesmanToBeDeleted != null)
                {
                    SalesManDeleted = JMS_DAL.DeleteSalesMan(salesmanToBeDeleted);
                }
                else
                {
                    SalesManDeleted = false;
                    throw new JMS_Exceptions("SalesMan Info does not exists to delete");
                }
            }
            catch (JMS_Exceptions p)
            {
                throw;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            return SalesManDeleted;
        }

        public static bool UpdateSalesMan(JMS_Entities SalesManToBeUpdated)
        {
            bool SalesManUpdated = true;

            try
            {
                //Searching customer, if found update or raise exception
                if (JMS_DAL.SearchSalesMan(SalesManToBeUpdated.SalesManCode) != null)
                {
                    //validating customer, if valid update o.w. raise exception
                    if (ValidateSalesMan(SalesManToBeUpdated))
                    {
                        SalesManUpdated = JMS_DAL.UpdateSalesMan(SalesManToBeUpdated);
                    }
                    else
                    {
                        SalesManUpdated = false;
                        throw new JMS_Exceptions("SalesMan Info is not updated because it is not valid!");
                    }
                }
                else
                {
                    SalesManUpdated = false;
                    throw new JMS_Exceptions("SalesMan id not exists for update!");
                }
            }
            catch (JMS_Exceptions e)
            {
                throw;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            return SalesManUpdated;
        }

        public static List<JMS_Entities> ReturnSalesManInformation1()
        {
            return JMS_DAL.ReturnSalesManInformation();
        }
        public static void SerializeData()
        {
            JMS_DAL.SerializeData();
        }
        public static List<JMS_Entities> DisplayFromFile()
        {
            List<JMS_Entities> SMS = JMS_DAL.DisplaySalesManFromFile();
            return SMS;
        }
    }

    

}