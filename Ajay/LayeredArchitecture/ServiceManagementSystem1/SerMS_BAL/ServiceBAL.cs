using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerMS_DAL;
using SerMS_Entities;
using SerMS_Exception;

namespace SerMS_BAL
{
    public class ServiceBAL
    {

        private static bool ValidateService(Service service)

        {

            StringBuilder sb = new StringBuilder();

            bool validService = true;

            if (service.Vechicleno.Length != 9)

            {

                validService = false;

                sb.Append(Environment.NewLine + "Invalid Vechicle Num");

            }

            if (service.VechicleType == string.Empty)

            {

                validService = false;

                sb.Append(Environment.NewLine + "Vechicle Type required");

            }

            if (service.OwnerName == string.Empty)

            {

                validService = false;

                sb.Append(Environment.NewLine + "Owner Name is required");

            }

            if (service.CentreDetails == string.Empty)

            {

                validService = false;

                sb.Append(Environment.NewLine + "Centre details are required");

            }

            if (validService == false)

                throw new ServiceEntryValidationException(sb.ToString());

            return validService;

        }

        public static bool AddServiceBL(Service newService)

        {

            bool serviceAdded = false;

            try

            {

                if (ValidateService(newService))

                {

                    serviceDAL serviceDAL = new serviceDAL();

                    serviceAdded = serviceDAL.AddService(newService);



                }

            }

            catch (ServiceEntryValidationException)

            {

                throw;

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return serviceAdded;

        }

        public static List<Service> DisplayServiceBL()

        {

            List<Service> serviceList = null;

            try

            {

                serviceDAL serviceDAL = new serviceDAL();

                serviceList = serviceDAL.DisplayService();

            }

            catch (ServiceEntryValidationException ex)

            {

                throw ex;

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return serviceList;

        }

        public static Service SearchServiceBL(string vechicleno)

        {

            Service searchService = null;

            try

            {

                serviceDAL serviceDAL = new serviceDAL();

                searchService = serviceDAL.SearchServiceRecord((vechicleno));

            }

            catch (ServiceEntryValidationException ex)

            {

                throw ex;

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return searchService;

        }
    }
}
