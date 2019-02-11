using SerMS_Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerMS_Entities;
//using SerMS_Exception;

namespace SerMS_DAL
{
    public class serviceDAL
    {
        public static List<Service> serviceList = new List<Service>();

        public bool AddService(Service newservice)

        {

            bool serviceadded = false;

            try

            {

                serviceList.Add(newservice);
                Console.WriteLine(serviceList.Count);
                serviceadded = true;

            }

            catch (SystemException ex)

            {

                throw new ServiceEntryValidationException(ex.Message);

            }

            return serviceadded;

        }

        public List<Service> DisplayService()

        {

            return serviceList;

        }

        public Service SearchServiceRecord(string vechicleno)

        {

            Service searchRecord = null;

            try

            {

                searchRecord = serviceList.Find(service => service.Vechicleno == vechicleno);

            }

            catch (SystemException ex)

            {

                throw new ServiceEntryValidationException(ex.Message);

            }

            return searchRecord;
        }
    }
}