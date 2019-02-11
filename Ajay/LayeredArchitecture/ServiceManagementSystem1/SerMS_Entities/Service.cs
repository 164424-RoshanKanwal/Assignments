using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerMS_Entities
{
    public class Service
    {
        private int entryId;

        //private string vechicleNo;

        //private string vechicleType;

        //private string ownerName;

        //private DateTime serviceDate;

        //private string centreDetails;

        public string Vechicleno { get; set; }

        public string VechicleType { get; set; }

        public string OwnerName { get; set; }

        public DateTime ServiceDate { get; set; }

        public string CentreDetails { get; set; }

        
        public override string ToString()
        {
            return $"{Vechicleno}\n{VechicleType}\n{OwnerName}\n{ServiceDate}\n{CentreDetails}";
        }
    }
}
