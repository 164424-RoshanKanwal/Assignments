using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Entities
{

    public class FacultyEntity
    {
         public int FacultyId { get; set; } 
        public string FacultyName { get; set; }
        public DateTime DOJ { get; set; }
        public string Email { get; set; }
        public long? Phone { get; set; }
       
    }
}
